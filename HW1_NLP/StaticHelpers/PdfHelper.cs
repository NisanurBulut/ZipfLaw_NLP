using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZipfLaw_NLP.DescriptiveClassess;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
namespace ZipfLaw_NLP.StaticHelpers
{
    public static class PdfHelper
    {
        public static string PrepareFilePath(string _filename, string _dicname)
        {
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = System.IO.Path.Combine(dir,_dicname);
            string file = _filename;
            string FilePath = System.IO.Path.Combine(path, file);
            return FilePath;
        }
        public static string ExtractTextFromPdf(string path)
        {
            
            using (PdfReader reader = new PdfReader(path))
            {
              
                StringBuilder text = new StringBuilder();
               
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    string currentText = PdfTextExtractor.GetTextFromPage(reader, i, new SimpleTextExtractionStrategy());
                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                    text.Append(currentText);
                    if (i == 4)
                    {
                        break;
                    }
                }
                text.Replace("BDRDNCD", "BİRİNCİ");
              
                return text.ToString();
            }
        }
        public static void WriteWordsToPdf(List<Word> _WordList,string _fname)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            string fpath = PrepareFilePath(_fname,"OutputReports");
            PdfWriter.GetInstance(document, new FileStream(fpath, FileMode.Create));
            string fpathfont= PrepareFilePath("times.ttf", "Fonts");
            BaseFont arial = BaseFont.CreateFont(fpathfont, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(arial, 12, Font.NORMAL);
            int countw = _WordList.Count+1;


            if (document.IsOpen() == false)
            {

                document.Open();
                PdfPTable table = new PdfPTable(5);

                PdfPCell cell = new PdfPCell(new Phrase(TurkceKarakter("Kelime Sıklık Tablosu"),font));
                cell.Colspan = 5;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);

            
                string sb = TurkceKarakter("Kullanım Sayısı");
                table.AddCell("Kelime");
                table.AddCell("Tip");
                table.AddCell(new Paragraph(sb, font));
                sb = TurkceKarakter("Kullanım Sırası");
                table.AddCell(new Paragraph(sb, font));
                sb = TurkceKarakter("Kullanım Sıklığı");
                table.AddCell(new Paragraph(sb, font));

                foreach (Word row in _WordList)
                {
                    sb=TurkceKarakter(row.WFull);

                    table.AddCell(new Paragraph(sb, font));
                    sb = TurkceKarakter(row.WType);
                    table.AddCell(new Paragraph(sb, font));
                    table.AddCell(row.Wcount.ToString());
                    table.AddCell(row.WRank.ToString());
                    table.AddCell(row.Wfrequency.ToString());
                }

               
                document.Add(table);
                document.Close();

            }
        }
        public static void WriteAddsToPdf(List<Word> _WordList, string _fname)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            string fpath = PrepareFilePath(_fname, "OutputReports");
            PdfWriter.GetInstance(document, new FileStream(fpath, FileMode.Create));
            string fpathfont = PrepareFilePath("times.ttf", "Fonts");
            BaseFont arial = BaseFont.CreateFont(fpathfont, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(arial, 12, Font.NORMAL);
            int countw = _WordList.Count + 1;


            if (document.IsOpen() == false)
            {

                document.Open();
                PdfPTable table = new PdfPTable(5);

                PdfPCell cell = new PdfPCell(new Phrase(TurkceKarakter("Ek Sıklık Tablosu"), font));
                cell.Colspan = 5;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);


                string sb = TurkceKarakter("Kullanım Sayısı");
                table.AddCell("Kelime");
                table.AddCell("Tip");
                table.AddCell(new Paragraph(sb, font));
                sb = TurkceKarakter("Kullanım Sırası");
                table.AddCell(new Paragraph(sb, font));
                sb = TurkceKarakter("Kullanım Sıklığı");
                table.AddCell(new Paragraph(sb, font));

                foreach (Word row in _WordList)
                {
                    sb = TurkceKarakter(row.WFull);

                    table.AddCell(new Paragraph(sb, font));
                    sb = TurkceKarakter(row.WType);
                    table.AddCell(new Paragraph(sb, font));
                    table.AddCell(row.Wcount.ToString());
                    table.AddCell(row.WRank.ToString());
                    table.AddCell(row.Wfrequency.ToString());
                }


                document.Add(table);
                document.Close();

            }
        }
        public static string TurkceKarakter(string text)
        {

            text = text.Replace("İ", "\u0130");

            text = text.Replace("ı", "\u0131");

            text = text.Replace("Ş", "\u015e");

            text = text.Replace("ş", "\u015f");

            text = text.Replace("Ğ", "\u011e");

            text = text.Replace("ğ", "\u011f");

            text = text.Replace("Ö", "\u00d6");

            text = text.Replace("ö", "\u00f6");

            text = text.Replace("ç", "\u00e7");

            text = text.Replace("Ç", "\u00c7");

            text = text.Replace("ü", "\u00fc");

            text = text.Replace("Ü", "\u00dc");

            return text;
        }
    }
}
