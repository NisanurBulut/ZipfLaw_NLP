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
        int tcSayac = 0;
        string zpContextTr=string.Empty;
        string zpContextEn = string.Empty;
        ZipfProcess zipfProcess1 = new ZipfProcess();
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                
                LblFlag.Text = "Belirtilen dosyalar okunmaktadır.";

                zpContextTr =  ReadAndLoadFile("HarryPotter-FelsefeTaşı.pdf");
                zpContextEn = ReadAndLoadFile("HarryPotterandtheSorcerer'sStone.pdf");

                zipfProcess1 = new ZipfProcess();
                PreparAndApplyZipfLaw(zipfProcess1, zpContextTr);
                PdfHelper.WriteToPdf(zipfProcess1.WordsOfFile, "KelimeAnaliziTr.pdf");
                

            }
            catch(Exception ex)
            {

            }
        }
        private string ReadAndLoadFile(string fname)
        {
            
            string FilePath = PdfHelper.PrepareFilePath(fname,"ReadingFiles");
            string selectedFileContentTr = PdfHelper.ExtractTextFromPdf(FilePath);


            LblFlag.Text = "Okunan dosya : " + fname;
            LblFlag.Text = fname + "dosyası üzerinde kelime analizi başlatılmıştır";
            
            return selectedFileContentTr;
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
        private void PrepareAndApplyZipfLawOnChart(ZipfProcess _zp,Chart _ch) {
            
            var series = new Series("Kelimeler");
            
            for (int z = 0; z < _zp.WordsOfFile.Count(); z++)
            {
               double wf=_zp.WordsOfFile[z].Wfrequency;
               string wn = _zp.WordsOfFile[z].Wname;
                series.Points.AddXY(wn, wf);
            }
            _ch.Series.Add(series);
            _ch.Series[0].ChartType = SeriesChartType.Pie;
            _ch.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // set view range to [0,max]
            _ch.ChartAreas[0].AxisX.Minimum = 0;
            _ch.ChartAreas[0].AxisX.Maximum = _zp.WordsOfFile.Count();

            // enable autoscroll
            _ch.ChartAreas[0].CursorX.AutoScroll = true;
            TabControls.Refresh();
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

        private void TabControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControls.SelectedIndex == 1 && tcSayac==0)
            {
                zipfProcess1 = new ZipfProcess();
                PreparAndApplyZipfLaw(zipfProcess1, zpContextEn);
                PrepareAndApplyZipfLawOnChart(zipfProcess1, ChartEn);
                PdfHelper.WriteToPdf(zipfProcess1.WordsOfFile, "KelimeAnaliziEn.pdf");
                tcSayac = tcSayac + 1;
            }
        }
    }
}
