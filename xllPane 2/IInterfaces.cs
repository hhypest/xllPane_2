using Microsoft.Office.Interop.Excel;
using System;
using DataTable = System.Data.DataTable;

namespace xllPane_2
{
    public interface IBookObject
    {
        (string SheetName, string[] TableName)[] GetTableName(ref Workbook workbook);

        ListObject[] GetListObject((string SheetName, string[] TableName) item, ref Workbook workbook);

        DataTable GetDataSet(ListObject table);

        void SaveTableInFile((string SheetName, string[] TableName)[] item, string patch, ref Workbook workbook);

        void SaveTableInXml((string SheetName, string[] TableName)[] item, string patch, ref Workbook workbook);
    }

    public interface ITextCast
    {
        string[,] GetPasteText(string[,] source, Func<byte, string, string> cast, byte state = 0);

        string[,] GetPasteText(string[,] source, Func<byte, string, string, string> cast, string paste, byte state = 0);

        string[,] ToTrim(string[,] source);

        string[,] ToReplace(string[,] source, string pattern, string replacer);

        string CastProp(byte state, string source);

        string CastPasteText(byte state, string source, string paste);
    }
}