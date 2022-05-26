using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using DataTable = System.Data.DataTable;

namespace xllPane_2
{
    public class BookObject : object, IBookObject
    {
        public DataTable GetDataSet(ListObject table)
        {
            object[,] header = table.HeaderRowRange.Value2;
            object[,] value = table.DataBodyRange.Value;

            using (DataTable dt = new DataTable()
            {
                TableName = table.DisplayName
            })
            {
                for (int i = header.GetLowerBound(1); i <= header.GetUpperBound(1); i++)
                {
                    dt.Columns.Add(header[1, i].To<object, string>(), value[1, i].GetType());
                }

                for (int i = value.GetLowerBound(0); i <= value.GetUpperBound(0); i++)
                {
                    DataRow row = dt.NewRow();

                    for (int j = value.GetLowerBound(1); j <= value.GetUpperBound(1); j++)
                    {
                        row[j - 1] = value[i, j];
                    }
                    dt.Rows.Add(row);
                }

                return dt;
            }
        }

        public ListObject[] GetListObject((string SheetName, string[] TableName) item, ref Workbook workbook)
        {
            Queue<ListObject> result = new Queue<ListObject>();

            foreach (Worksheet sheet in workbook.Sheets)
            {
                if (sheet.Name != item.SheetName)
                    continue;
                foreach ((ListObject table, string name) in from ListObject table in sheet.ListObjects
                                                            from string name in item.TableName
                                                            select (table, name))
                {
                    if (table.Name != name)
                        continue;
                    result.Enqueue(table);
                }
            }

            return result.ToArray();
        }

        public (string SheetName, string[] TableName)[] GetTableName(ref Workbook workbook)
        {
            Queue<(string SheetName, string[] TableName)> result = new Queue<(string SheetName, string[] TableName)>();

            foreach (Worksheet sheet in workbook.Sheets)
            {
                if (sheet.ListObjects.Count < 1)
                    continue;

                Queue<string> names = new Queue<string>();
                foreach (ListObject table in sheet.ListObjects)
                {
                    if (table.ListColumns.Count < 2)
                        continue;

                    names.Enqueue(table.Name);
                }

                result.Enqueue((sheet.Name, names.ToArray()));
            }

            return result.ToArray();
        }

        public void SaveTableInFile((string SheetName, string[] TableName)[] item, string patch, ref Workbook workbook)
        {
            using (DataSet ds = new DataSet()
            {
                DataSetName = workbook.Name
            })
            {
                Queue<ListObject[]> list = new Queue<ListObject[]>();
                foreach ((string SheetName, string[] TableName) key in item)
                {
                    list.Enqueue(GetListObject(key, ref workbook));
                }

                foreach (var table in from ListObject[] tables in list
                                      from ListObject table in tables
                                      select table)
                {
                    ds.Tables.Add(GetDataSet(table));
                }

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (FileStream stream = new FileStream(patch, FileMode.Create, FileAccess.Write))
                {
                    using (ExcelPackage book = new ExcelPackage(stream))
                    {
                        foreach ((DataTable table, ExcelWorksheet sheet) in from DataTable table in ds.Tables
                                                                            let sheet = book.Workbook.Worksheets.Add(table.TableName)
                                                                            select (table, sheet))
                        {
                            sheet.Cells["A5"].LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Light13);
                        }

                        book.SaveAsAsync(stream);
                    }
                }
            }
        }

        public void SaveTableInXml((string SheetName, string[] TableName)[] item, string patch, ref Workbook workbook)
        {
            using (DataSet ds = new DataSet()
            {
                DataSetName = workbook.Name
            })
            {
                Queue<ListObject[]> list = new Queue<ListObject[]>();

                foreach ((string SheetName, string[] TableName) key in item)
                    list.Enqueue(GetListObject(key, ref workbook));

                foreach (ListObject table in from ListObject[] tables in list
                                             from ListObject table in tables
                                             select table)
                {
                    ds.Tables.Add(GetDataSet(table));
                }

                using (FileStream stream = new FileStream(patch, FileMode.Create, FileAccess.Write))
                    ds.WriteXml(stream, XmlWriteMode.WriteSchema);
            }
        }
    }
}