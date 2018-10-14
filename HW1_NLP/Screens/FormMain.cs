using HW1_NLP.StaticHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HW1_NLP.Screens
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LblDateTime.Text = DateTime.Now.ToString();
            LblFlag.Text = string.Empty;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                LblFlag.Text = "Belirtilen dosyalar okunmaktadır.";
                            
                string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string path = Path.Combine(dir, "ReadingFiles");
                string file = "HarryPotter-FelsefeTaşı.pdf";
                string FilePath = Path.Combine(path, file);
                string selectedFileContent = PdfHelper.ExtractTextFromPdf(FilePath);
                LblFlag.Text = "Okunan dosya : "+file;
              
                LblFlag.Text = file+"dosyası üzerinde kelime analizi başlatılmıştır";

                ZipfProcess zipfProcess1 = new ZipfProcess();
                PreparAndApplyZipfLaw(zipfProcess1,selectedFileContent);
                PrepareandapplyZipfLawOnChart(zipfProcess1,ChartTr);
                

            }
            catch(Exception ex)
            {

            }
        }
        private void PreparAndApplyZipfLaw(ZipfProcess _zp, string selectedFileContent)
        {
            #region sıklık araştırmasına hazırlık
            selectedFileContent = Regex.Replace(selectedFileContent, @"\t|\n|\r", "");
            selectedFileContent = new string((from c in selectedFileContent where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c) select c).ToArray());
            string[] outputContent = selectedFileContent.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            #endregion

            #region Zipf kanunun kontrol edilmesi
           
            _zp.InitWordsOfFile(outputContent);
            _zp.CalculateWfrequency();
            _zp.ReOrderWordListByFrequency();
            #endregion
        }
        private void PrepareandapplyZipfLawOnChart(ZipfProcess _zp,Chart _ch) {
            
            var series = new Series("BİTEN PAKETLER");
            
            for (int z = 0; z < _zp.WordsOfFile.Count(); z++)
            {
               double wf=_zp.WordsOfFile[z].Wfrequency;
               string wn = _zp.WordsOfFile[z].Wname;
                series.Points.AddXY(wn, wf);
            }
            _ch.Series.Add(series);
            _ch.Series[0].ChartType = SeriesChartType.Pie;
            _ch.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        private void ChartTr_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            // Check selected chart element and set tooltip text for it
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = string.Format("X:\t{0}\nY:\t{1}", dataPoint.XValue, dataPoint.YValues[0]);
                    break;
            }
        }
    }
}
