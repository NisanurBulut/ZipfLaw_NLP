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
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Windows.Forms;
using Brushes = System.Windows.Media.Brushes;
using HW1_NLP.DescriptiveClassess;

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

        string zpContextTr=string.Empty;
        string zpContextEn = string.Empty;
        ZipfProcess zipfProcessTr = new ZipfProcess();
        ZipfProcess zipfProcessEn = new ZipfProcess();
        int count = 0;
        public void NewChartLoad(ZipfProcess zp)
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new LiveCharts.SeriesCollection();
            int w = 0;
            
            do 
            {

                PieSeries ps = new PieSeries();
                ps.Title = zp.WordsOfFile[w].WFull;
                ps.Values = new ChartValues<double> { zp.WordsOfFile[w].Wfrequency };
                ps.DataLabels = true;
                ps.LabelPoint = labelPoint;
                pieChart1.Series.Add(ps);
                
                w++;
               
            } while (w <50) ;



            pieChart1.LegendLocation = LegendLocation.Right;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                comboBooks.SelectedIndex = 0;
                LblFlag.Text = "Belirtilen dosyalar okunmaktadır.";

                zpContextTr =  ReadAndLoadFile("HarryPotterKitap1Tr.txt");          
                zipfProcessTr = new ZipfProcess();
                PreparAndApplyZipfLaw(zipfProcessTr, zpContextTr);
                // PdfHelper.WriteWordsToPdf(zipfProcessTr.WordsOfFile, "KelimeAnaliziTr.pdf");

                NewChartLoad(zipfProcessTr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("İstenmeyen bir hata ile karşılaşıldı "+ex.Message);
            }
        }
        private string ReadAndLoadFile(string fname)
        {
            
            string FilePath = TxtHelper.PrepareFilePath(fname,"ReadingFiles");
            string selectedFileContent =TxtHelper.ExtractTextFromTxt(FilePath);


            LblFlag.Text = "Okunan dosya : " + fname;
            LblFlag.Text = fname + "dosyası üzerinde kelime analizi başlatılmıştır";
            
            return selectedFileContent;
        }
        private void PreparAndApplyZipfLaw(ZipfProcess _zp, string selectedFileContent)
        {
            #region sıklık araştırmasına hazırlık
            selectedFileContent = Regex.Replace(selectedFileContent, @"\t|\n|\r", " ");
            selectedFileContent = new string((from c in selectedFileContent where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c) select c).ToArray());
            string[] outputContent = selectedFileContent.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            #endregion

            #region Zipf kanunun kontrol edilmesi
           
            _zp.InitWordsOfFile(outputContent);
            _zp.CalculateWfrequency();
            _zp.ReOrderWordListByFrequency();
            #endregion
        }
   
       
   

        private void BtnZemberekAnalyz_Click(object sender, EventArgs e)
        {
            zipfProcessTr.MorphologyAnalysis();                    
        }

        private void BtnComboSelect_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string file = comboBooks.SelectedItem.ToString();

            if (file.Contains("Book") == true)
            {
                if (count == 0)
                {
                    zpContextEn = ReadAndLoadFile(file);
                    zipfProcessEn = new ZipfProcess();
                    PreparAndApplyZipfLaw(zipfProcessEn, zpContextEn);
                    NewChartLoad(zipfProcessEn);
                    count = 1;
                }
                else
                {
                    NewChartLoad(zipfProcessEn);
                }
            }
            else
            {
               
                NewChartLoad(zipfProcessTr);
            }
            this.Cursor = Cursors.Default;
         
        }
    }
}
