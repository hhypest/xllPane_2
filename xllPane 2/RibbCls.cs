using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;
using ExcelDna.Logging;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace xllPane_2
{
    [ComVisible(true)]
    public class RibbCls : ExcelRibbon
    {
        private const XlCalculation xlManual = XlCalculation.xlCalculationManual;
        private const XlCalculation xlAuto = XlCalculation.xlCalculationAutomatic;
        private const XlFileFormat xlOpenXml = XlFileFormat.xlOpenXMLWorkbook;
        private const XlFileFormat xlBinary = XlFileFormat.xlExcel12;

        private void OnOffSelect(bool state, XlCalculation calculation, ref Application app)
        {
            app.EnableEvents = state;
            app.Calculation = calculation;
            app.StatusBar = state;
            app.DisplayAlerts = state;
            app.ScreenUpdating = state;
        }

        #region[Даты\числа]

        public void OnNumberClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                double cast(object value) => value.IsNumber() ? value.ParseToDouble() : default;
                object[,] values = range.Value2 as object[,];
                double[,] result = ArrMearge.ToParse(values, cast);
                OnOffSelect(false, xlManual, ref app);
                range.Value2 = result;
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnDateClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                DateTime cast(object value) => value.IsDate() ? value.To<object, DateTime>() : default;
                object[,] values = range.Value as object[,];
                DateTime[,] result = ArrMearge.ToParse(values, cast);
                OnOffSelect(false, xlManual, ref app);
                range.Value2 = result;
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        #endregion

        #region[Уникальные значения]

        public void OnUnClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 && range.Columns.Count == 1)
                    return;

                object[,] values = range.Value2 as object[,];
                ParallelQuery<string> result = ArrMearge.UniqVal(values);
                worksheet = (Worksheet)workbook.Worksheets.Add();
                OnOffSelect(false, xlManual, ref app);
                int i = 1;

                foreach (string key in result)
                {
                    worksheet.Range[$"A{i}"].Value2 = key;
                    i += 1;
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnAggrClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                object[,] values = range.Value2 as object[,];
                ParallelQuery<KeyValuePair<string, double>> result = ArrMearge.AgrVal(values, 1);
                worksheet = (Worksheet)workbook.Worksheets.Add();
                int i = 1;
                OnOffSelect(false, xlManual, ref app);

                foreach (KeyValuePair<string, double> key in result)
                {
                    worksheet.Range[$"A{i}"].Value2 = key.Key;
                    worksheet.Range[$"B{i}"].Value2 = key.Value;
                    i += 1;
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        #endregion

        #region[Ячейки]

        public void OnUnMeargeClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;
                OnOffSelect(false, xlManual, ref app);

                foreach (Range cell in range)
                {
                    if ((bool)cell.MergeCells)
                    {
                        var with = cell.MergeArea;
                        with.UnMerge();
                        with.Value2 = cell.Value2;
                    }
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnFormulClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                object[,] values = range.Value2 as object[,];
                OnOffSelect(false, xlManual, ref app);
                range.Value2 = values;
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnClearClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            Range range = worksheet.Application.Selection as Range;
            range.Borders.LineStyle = BorderStyle.None;
            range.ClearFormats();
            range.ClearContents();
        }

        #endregion

        #region[Текст]

        public void OnPropClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                object[,] values = range.Value2 as object[,];
                string[] sample = ArrMearge.ToParse<object, string>(values, 11);

                using (PropFm dialog = new PropFm(sample))
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    byte state = dialog.GetState();
                    string cast(object value) => value != null ? value.To<object, string>() : default;
                    TextPaste prop = new TextPaste();
                    string[,] result = prop.GetPasteText(ArrMearge.ToParse(values, cast), prop.CastProp, state);
                    OnOffSelect(false, xlManual, ref app);
                    range.Value2 = result;
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnTrimClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                string cast(object value) => value != null ? value.To<object, string>() : " ";
                object[,] values = range.Value2 as object[,];

                TextPaste trim = new TextPaste();
                string[,] result = trim.ToTrim(ArrMearge.ToParse(values, cast));
                range.Value2 = result;
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnJoinClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                object[,] values = range.Value2 as object[,];
                string[] sample = ArrMearge.ToParse<object, string>(values, 11);

                using (PasteFm dialog = new PasteFm(sample))
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    byte state = dialog.GetState();
                    string pastetext = dialog.GetPaste();
                    string cast(object value) => value != null ? value.To<object, string>() : default;
                    TextPaste paste = new TextPaste();
                    string[,] result = paste.GetPasteText(ArrMearge.ToParse(values, cast), paste.CastPasteText, pastetext, state);
                    OnOffSelect(false, xlManual, ref app);
                    range.Value2 = result;
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnFindPasteClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                object[,] values = range.Value2 as object[,];
                string[] sample = ArrMearge.ToParse<object, string>(values, 11);

                using (ReplaceFm dialog = new ReplaceFm(sample))
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    (string pattern, string replacer) = dialog.GetState();
                    string cast(object value) => value != null ? value.To<object, string>() : " ";
                    TextPaste replace = new TextPaste();

                    string[,] result = replace.ToReplace(ArrMearge.ToParse(values, cast), pattern, replacer);
                    OnOffSelect(false, xlManual, ref app);
                    range.Value2 = result;
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnSplitTextClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            try
            {
                Range range = worksheet.Application.Selection as Range;

                if ((bool)range.MergeCells)
                    return;

                if (range.Rows.Count == 1 & range.Columns.Count == 1)
                    return;

                object[,] values = range.Value2 as object[,];
                string[] sample = ArrMearge.ToParse<object, string>(values, 8);

                using (SplitFm dialog = new SplitFm(sample))
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    (char[] separator, int count) = dialog.GetState();
                    string cast(string value) => value.Split(separator)
                                                      .Count() >= count ?
                                                      value.Split(separator)[count] :
                                                      value;
                    string[,] result = new string[values.GetLength(0), values.GetLength(1)];

                    for (int i = values.GetLowerBound(0); i <= values.GetUpperBound(0); i++)
                    {
                        for (int j = values.GetLowerBound(1); j <= values.GetUpperBound(1); j++)
                        {
                            result[i - 1, j - 1] = cast(values[i, j].To<object, string>());
                        }
                    }

                    OnOffSelect(false, xlManual, ref app);
                    range.Value2 = result;
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        #endregion

        #region[Книги\листы]

        public void OnMailSendClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            if (!(worksheet.Application.Selection is Range))
                return;

            workbook.EnvelopeVisible = true;
        }

        public void OnSaveShClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Title = $"Куда сохранить лист <{worksheet.Name}>?",
                    RestoreDirectory = true,
                    FileName = worksheet.Name,
                    Filter = "Книга xlsx|*.xlsx|Бинарная книга|*.xlsb"
                })
                {
                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                        return;

                    OnOffSelect(false, xlManual, ref app);
                    worksheet.Copy();

                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            {
                                var with = app.ActiveWorkbook;
                                with.SaveAs(saveFileDialog.FileName, xlOpenXml);
                                with.Close();
                                break;
                            }
                        case 2:
                            {
                                var with = app.ActiveWorkbook;
                                with.SaveAs(saveFileDialog.FileName, xlBinary);
                                with.Close();
                                break;
                            }
                    }
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnSaveClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            try
            {
                string[] names = workbook.Sheets.Cast<Worksheet>()
                                         .Select(sheet => sheet.Name)
                                         .ToArray();

                using (SaveSheetFm dialog = new SaveSheetFm(names))
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog()
                    {
                        Title = $"Куда сохранить листы из книги <{workbook.Name}>?",
                        RestoreDirectory = true,
                        FileName = "SheetsColection",
                        Filter = "Книга xlsx|*.xlsx|Бинарная книга|*.xlsb"
                    })
                    {
                        if (saveFileDialog.ShowDialog() != DialogResult.OK)
                            return;

                        string[] result = dialog.GetNames();
                        OnOffSelect(false, xlManual, ref app);
                        Sheets worksheet = workbook.Sheets[result];

                        worksheet.Copy();

                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                {
                                    var with = app.ActiveWorkbook;
                                    with.SaveAs(saveFileDialog.FileName, xlOpenXml);
                                    with.Close();
                                    break;
                                }
                            case 2:
                                {
                                    var with = app.ActiveWorkbook;
                                    with.SaveAs(saveFileDialog.FileName, xlBinary);
                                    with.Close();
                                    break;
                                }
                        }
                    }
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
            finally
            {
                OnOffSelect(true, xlAuto, ref app);
            }
        }

        public void OnExTableClickAsync(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            try
            {
                BookObject book = new BookObject();

                using (TableFm dialog = new TableFm(book.GetTableName(ref workbook)))
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    (string SheetName, string[] TableName)[] result = dialog.GetNames().ToArray();

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog()
                    {
                        Title = $"Куда сохранить таблицы из книги <{workbook.Name}>?",
                        RestoreDirectory = true,
                        FileName = "TablesColection",
                        Filter = "Книга xlsx|*.xlsx"
                    })
                    {
                        if (saveFileDialog.ShowDialog() != DialogResult.OK)
                            return;

                        book.SaveTableInFile(result, saveFileDialog.FileName, ref workbook);
                    }
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
        }

        public void OnTableToXmlClick(IRibbonControl control)
        {
            Application app = ExcelDnaUtil.Application as Application;

            if (app.ActiveWorkbook == null)
                return;

            Workbook workbook = app.ActiveWorkbook;

            if (workbook.Worksheets.Count == 0)
                return;

            try
            {
                BookObject book = new BookObject();

                using (TableFm dialog = new TableFm(book.GetTableName(ref workbook)))
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    (string SheetName, string[] TableName)[] result = dialog.GetNames().ToArray();

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog()
                    {
                        Title = $"Куда сохранить таблицы из книги <{workbook.Name}>?",
                        RestoreDirectory = true,
                        FileName = "XmlColection",
                        Filter = "XML файл|*.xml"
                    })
                    {
                        if (saveFileDialog.ShowDialog() != DialogResult.OK)
                            return;

                        book.SaveTableInXml(result, saveFileDialog.FileName, ref workbook);
                    }
                }
            }
            catch (InvalidCastException e)
            {
                LogDisplay.RecordLine(e.Message);
                LogDisplay.RecordLine(e.StackTrace);
                LogDisplay.RecordLine(e.Source);
                LogDisplay.Show();
            }
        }

        #endregion
    }
}