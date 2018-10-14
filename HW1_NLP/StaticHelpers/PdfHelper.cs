using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
namespace HW1_NLP.StaticHelpers
{
    public static class PdfHelper
    {

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
                    //if (i == 5000)
                    //{
                    //    break;
                    //}
                }
                text.Replace("BDRDNCD", "BİRİNCİ");
              
                return text.ToString();
            }
        }
    }
}
