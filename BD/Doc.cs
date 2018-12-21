using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace BD
{
    public partial class Doc : Form
    {
        public void CreateBankDocument(int IdReg, int IdDev, double Total)
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
            object missing = System.Reflection.Missing.Value;
            object path = @"E:\Архив\BD\TestDoc.dot";
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref path, ref missing, ref missing, ref missing);

            foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
            {
                Microsoft.Office.Interop.Word.Range headerRange =
                section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);

                headerRange.ParagraphFormat.Alignment =
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                headerRange.Font.Size = 16;
                headerRange.Text = "Расчет клиента " + IdReg;
            }

            //Добавление нижнего колонтитула
            foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
            {
                //
                Microsoft.Office.Interop.Word.Range footerRange =
        wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //Установка цвета текста
                footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdAuto;
                //Размер
                footerRange.Font.Size = 12;
                //Установка расположения по центру
                footerRange.ParagraphFormat.Alignment =
                    Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //Установка текста для вывода в нижнем колонтитуле
                footerRange.Text = "Подпись сотрудника:_____________                                               Подпись клиента:_____________";
            }

            Microsoft.Office.Interop.Word.Paragraph txt = document.Content.Paragraphs.Add(ref missing);

            Table table = document.Tables.Add(txt.Range, 2, 3, ref missing, ref missing);

            table.Borders.Enable = 1;

            winword.Visible = true;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    var cell = table.Cell(i + 1, j + 1);

                    if (cell.RowIndex == 1)
                    {
                        switch (j)
                        {
                            case 0:
                                cell.Range.Text = "Регистрационный номер";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 12;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 1:
                                cell.Range.Text = "Номер События";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 12;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 2:
                                cell.Range.Text = "Итого";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 12;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                        }
                    }
                    else
                    {
                        switch (j)
                        {
                            case 0:
                                cell.Range.Text = IdReg.ToString();
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 1:
                                cell.Range.Text = IdDev.ToString();
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 2:
                                cell.Range.Text = Total.ToString();
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 10;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                        }
                    }
                }
            }
        }

        public void CreateBankRollDocument(double Total)
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
            object missing = System.Reflection.Missing.Value;
            object path = @"E:\Архив\BD\TestDoc.dot";
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref path, ref missing, ref missing, ref missing);

            foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
            {
                Microsoft.Office.Interop.Word.Range headerRange =
                section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);

                headerRange.ParagraphFormat.Alignment =
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                headerRange.Font.Size = 16;
                headerRange.Text = "Справка о Выручке";
            }

            //Добавление нижнего колонтитула
            foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
            {
                //
                Microsoft.Office.Interop.Word.Range footerRange =
        wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //Установка цвета текста
                footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdAuto;
                //Размер
                footerRange.Font.Size = 12;
                //Установка расположения по центру
                footerRange.ParagraphFormat.Alignment =
                    Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //Установка текста для вывода в нижнем колонтитуле
                footerRange.Text = "Подпись сотрудника:_____________                                               Подпись клиента:_____________";
            }

            Microsoft.Office.Interop.Word.Paragraph txt = document.Content.Paragraphs.Add(ref missing);

            Table table = document.Tables.Add(txt.Range, 1, 2, ref missing, ref missing);

            table.Borders.Enable = 1;

            winword.Visible = true;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var cell = table.Cell(i + 1, j + 1);

                    if (cell.RowIndex == 1)
                    {
                        switch (j)
                        {
                            case 0:
                                cell.Range.Text = "Выручка";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 12;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 1:
                                cell.Range.Text = (Total.ToString() + " " + "рублей").ToString();
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 12;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                        }
                    }
                }
            }
        }
        public void CreateClientOrderDocument(int Reg)
        {
            Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
            object missing = System.Reflection.Missing.Value;
            object path = @"E:\Архив\BD\TestDoc.dot";
            Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref path, ref missing, ref missing, ref missing);

            foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
            {
                Microsoft.Office.Interop.Word.Range headerRange =
                section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;

                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);

                headerRange.ParagraphFormat.Alignment =
                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                headerRange.Font.Size = 16;
                headerRange.Text = "Жетон клиента";
            }

            //Добавление нижнего колонтитула
            foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
            {
                //
                Microsoft.Office.Interop.Word.Range footerRange =
        wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //Установка цвета текста
                footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdAuto;
                //Размер
                footerRange.Font.Size = 12;
                //Установка расположения по центру
                footerRange.ParagraphFormat.Alignment =
                    Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //Установка текста для вывода в нижнем колонтитуле
                footerRange.Text = "Подпись сотрудника:_____________                                               Подпись клиента:_____________";
            }

            Microsoft.Office.Interop.Word.Paragraph txt = document.Content.Paragraphs.Add(ref missing);

            Table table = document.Tables.Add(txt.Range, 1, 2, ref missing, ref missing);

            table.Borders.Enable = 1;

            winword.Visible = true;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var cell = table.Cell(i + 1, j + 1);

                    if (cell.RowIndex == 1)
                    {
                        switch (j)
                        {
                            case 0:
                                cell.Range.Text = "Номер клиента";
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 12;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                            case 1:
                                cell.Range.Text = Reg.ToString();
                                cell.Range.Font.Name = "verdana";
                                cell.Range.Font.Size = 12;
                                cell.Shading.BackgroundPatternColor = WdColor.wdColorWhite;
                                cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                                cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter; break;
                        }
                    }
                }
            }
        }
    }
}
    