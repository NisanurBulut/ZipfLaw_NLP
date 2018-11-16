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
        Func<ChartPoint, string> labelPoint;
        public FormMain()
        {
            InitializeComponent();
            LblDateTime.Text = DateTime.Now.ToString();
            LblFlag.Text = string.Empty;
           labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new LiveCharts.SeriesCollection();
        }

        string zpContextTr=string.Empty;
        string zpContextEn = string.Empty;
        ZipfProcess zipfProcessTr = new ZipfProcess();
        ZipfProcess zipfProcessEn = new ZipfProcess();
        int count = -1;
       
        public void NewChartLoadByFrequency(ZipfProcess zp)
        {
            
            int w = 0;            
            do 
            {
                PieSeries ps = new PieSeries();
                    ps.Title = zp.StemOfFile[w].WStemp + " => " + zp.StemOfFile[w].Wcount + "/" + zp.StemOfFile[w].WRank + "=" + zp.StemOfFile[w].Wfrequency;
                    ps.Values = new ChartValues<double> { zp.StemOfFile[w].Wfrequency };
                    ps.DataLabels = true;
                    ps.LabelPoint = labelPoint;
                    pieChart1.Series.Add(ps);                                
                w++;
            } while (w <30 && w<zp.StemOfFile.Count) ;
            pieChart1.LegendLocation = LegendLocation.Right;
           
        }
        public void NewChartLoadByContant(ZipfProcess zp)
        {
            int w = 0;
            
            do
            {
                PieSeries ps = new PieSeries();
                ps.Title = zp.StemOfFile[w].WStemp + " => "+zp.StemOfFile[w].Wcount + "*" + zp.StemOfFile[w].WRank + "="+ zp.StemOfFile[w].Constant;
                    ps.Values = new ChartValues<double> { zp.StemOfFile[w].Constant };
                    ps.DataLabels = true;
                    ps.LabelPoint = labelPoint;
                    pieChart1.Series.Add(ps);             
                    w++;
              
            } while (w < 30 && w < zp.StemOfFile.Count);
            pieChart1.LegendLocation = LegendLocation.Right;

        }
        public void NewChartLoadByA(ZipfProcess zp)
        {

            int w = 0;
            do
            {
                PieSeries ps = new PieSeries();
                ps.Title = zp.StemOfFile[w].WStemp + " => " + zp.StemOfFile[w].Probr + "*" + zp.StemOfFile[w].WRank + "=" + zp.StemOfFile[w].A;
                ps.Values = new ChartValues<double> { zp.StemOfFile[w].A };
                ps.DataLabels = true;
                ps.LabelPoint = labelPoint;
                pieChart1.Series.Add(ps);

                w++;

            } while (w <30 && w < zp.StemOfFile.Count);
            pieChart1.LegendLocation = LegendLocation.Right;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                comboBooks.SelectedIndex = 0;
                LblFlag.Text = "Belirtilen dosyalar okunmaktadır.";
                string filename= "HarryPotterKitap1Tr.txt";
                zpContextTr =  ReadAndLoadFile(filename);          
                zipfProcessTr = new ZipfProcess();
                zipfProcessTr.FilePath = filename;
                PrepareAndApplyZipfLaw(zipfProcessTr, zpContextTr);
                // PdfHelper.WriteWordsToPdf(zipfProcessTr.WordsOfFile, "KelimeAnaliziTr.pdf");

                NewChartLoadByA(zipfProcessTr);
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
        private void PrepareAndApplyZipfLaw(ZipfProcess _zp, string selectedFileContent)
        {
            #region sıklık araştırmasına hazırlık
            selectedFileContent = Regex.Replace(selectedFileContent, @"\t|\n|\r", " ");
            selectedFileContent = new string((from c in selectedFileContent where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c) select c).ToArray());
            string[] outputContent = selectedFileContent.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            #endregion

            #region Zipf kanunun kontrol edilmesi  
            _zp.FindWordsForFile(outputContent);
            if (_zp.FilePath.Contains("Book") == false)
            {
                _zp.FindStempForWords();
                _zp.InitWordsOfFile();
                _zp.CalculateWfrequency();
            }
            else
            {
                //burayı kodlayacağım
                _zp.StemOfFile.AddRange(_zp.WordsOfFile);
                _zp.CalculateWfrequencyEn();
            }
           
           // _zp.ReOrderWordListByConstant();
            #endregion
        }
   
       
   

    

        private void comboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (count != -1)
            {
                this.Cursor = Cursors.WaitCursor;
                string file = comboBooks.SelectedItem.ToString();

                if (file.Contains("Book") == true)
                {
                    if (count == 0)
                    {
                        zipfProcessEn = new ZipfProcess();
                        zpContextEn = ReadAndLoadFile(file);
                      
                        zipfProcessEn.FilePath = file;
                        PrepareAndApplyZipfLaw(zipfProcessEn, zpContextEn);
                        NewChartLoadByFrequency(zipfProcessEn);
                        count = 1;
                    }
                    else
                    {
                      
                        count = 1;
                        NewChartLoadByFrequency(zipfProcessEn);
                    }
                }
                else
                {

                    NewChartLoadByFrequency(zipfProcessTr);
                }
                this.Cursor = Cursors.Default;
            }
            else
            {
                count = 0;
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pieChart1.Series = new LiveCharts.SeriesCollection();
            ComboBox cb = (ComboBox)sender;
            switch (cb.SelectedIndex)
            {
                case 0:
                    NewChartLoadByContant(zipfProcessTr);
                    break;
                case 1:
                    NewChartLoadByA(zipfProcessTr);
                   
                    break;
                case 2:
                    NewChartLoadByFrequency(zipfProcessTr);
                    break;
                case 3:
                    NewChartLoadByFrequency(zipfProcessTr);
                    break;
            }
        }
    }
}
