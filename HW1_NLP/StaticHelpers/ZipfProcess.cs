using HW1_NLP.DescriptiveClassess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net.zemberek.erisim;
using net.zemberek.tr.yapi;
using net.zemberek.yapi;
using net.zemberek.yapi.ek;

namespace HW1_NLP.StaticHelpers
{
    public class ZipfProcess
    {
        public string FilePath = string.Empty;
        public List<Word> StemOfFile = new List<Word>();
        public List<Word> WordsOfFile = new List<Word>();
        public ZipfProcess()
        {

        }

        public void FindWordsForFile(string[] _contentOfFile)
        {
            int o = 0;
            Zemberek zemberek = new Zemberek(new TurkiyeTurkcesi());
            for (o = 0; o < _contentOfFile.Length; o++)
            {
                Word _word = new Word();
                string _wordfull = _contentOfFile[o];
                //sırayla kelimeleri ek kök ayrımına sokmak gerekli
                bool existWordFlag = WordsOfFile.Exists(a => a.WFull.Equals(_wordfull, StringComparison.OrdinalIgnoreCase));

                /*kelimeDenetle methodu, bir kelimenin doğru yazılıp yazılmadığını kontrol eder. Türkçe’de olmayan bir kelime ise “false” değeri döndürür.*/
                if (zemberek.kelimeDenetle(_wordfull) && existWordFlag != true)
                {        
                    int wc = _contentOfFile.Where(a => a.Equals(_wordfull, StringComparison.OrdinalIgnoreCase)).Count();//Kelimenin tekrarı                                       
                    int wo = o + 1;//Kelimenin metinde bulunma sırası
                    var list = _contentOfFile.Where(a => a.Equals(_wordfull, StringComparison.OrdinalIgnoreCase)).ToList();
                    _word.Wcount = wc;
                    _word.WFull = _wordfull;
                    WordsOfFile.Add(_word);
                }


            }
        }
        public void FindStempForWords()
        {
            int o = 0;
            Zemberek zemberek = new Zemberek(new TurkiyeTurkcesi());
            for (o = 0; o < WordsOfFile.Count; o++)
            {
                Word _word = new Word();
                string _wordfull = WordsOfFile[o].WFull;
                //sırayla kelimeleri ek kök ayrımına sokmak gerekli
               

                /*kelimeDenetle methodu, bir kelimenin doğru yazılıp yazılmadığını kontrol eder. Türkçe’de olmayan bir kelime ise “false” değeri döndürür.*/
               if (zemberek.kelimeDenetle(_wordfull) )
                {
                    int c = 0;
                  
                    Kelime[] CozumluKelime = zemberek.kelimeCozumle(_wordfull);
                    EkYonetici sozluk = zemberek.dilBilgisi().ekler();
                    string kok = string.Empty;
                    string tip = string.Empty;
                    List<string> ektipler = new List<string>();
                    if (CozumluKelime.Length > 0)
                    {
                        c = CozumluKelime.Count() - 1;
                        Kok _wstemp = CozumluKelime[c].kok();
                        List<Ek> leks = CozumluKelime[c].ekler();
                        
                        for (int e = 0; e < leks.Count; e++)
                        {
                            string ektip = leks[e].ad();
                            ektipler.Add(ektip);
                        }
                         kok = _wstemp.icerik();
                         tip = leks[0].ad();
                    }
                    else
                    {
                        kok = _wordfull;
                        tip = "ISIM_KOK";
                    }
              

                        WordsOfFile[o].WType = tip;//Kök tipi
                        WordsOfFile[o].WStemp = kok;//kökün ne olduğu
                        WordsOfFile[o].Wadds.AddRange(ektipler);//eklenen eklerin listesi tiple birlikte                   
             
                }


            }
        }
        public void InitWordsOfFile()
        {
            int o = 0;
          
            for (o = 0; o < WordsOfFile.Count; o++)
            {
                Word word = WordsOfFile[o];
                string _wstemp = WordsOfFile[o].WStemp;
               
               int wc = WordsOfFile.Where(a => a.WStemp.Equals(_wstemp, StringComparison.OrdinalIgnoreCase)).Count();//Kelimenin tekrarı                         
                WordsOfFile[o].WScount = wc;
                bool exist = StemOfFile.Exists(a => a.WStemp == word.WStemp);
                if (exist == false)
                {
                  
                    word = WordsOfFile[o];
                    StemOfFile.Add(word);
                 
                }
            }
        }
       
        
      
        public void CalculateWfrequency()
        {
            StemOfFile = StemOfFile.OrderByDescending(a => a.Wcount).ToList();
            double N = StemOfFile.Count;
            for (int w = 0; w < StemOfFile.Count; w++)
            {
                double wc = StemOfFile[w].Wcount;
                double wo = w + 1;
                double constant = wc * wo;//rankxsıklık
                double wf = wc/wo;
                double roundwf = System.Math.Round(wf, 3);
                double probr = wc / N;
                double a = probr * wo;
                StemOfFile[w].WRank = w + 1;
                StemOfFile[w].Wfrequency = roundwf;
                StemOfFile[w].Constant = constant;
                StemOfFile[w].Probr = System.Math.Round(probr, 4);
                double rounda = System.Math.Round(a, 4);
                StemOfFile[w].A = rounda;
            }            
        }
    


        public void CalculateWfrequencyEn()
        {
           
            for (int w = 0; w < StemOfFile.Count; w++)
            {
                double wc = StemOfFile[w].Wcount;
                double wo = w + 1;

                double constant = wc * wo;
                double wf = wc / wo;
                double roundwf = System.Math.Round(wf, 3);
                StemOfFile[w].Wfrequency = wo;
                StemOfFile[w].Wfrequency = roundwf;
                StemOfFile[w].Constant = constant;
            }
        }
    

    }
}

/*    public void ReOrderWordListByFrequency()
        {
            
            StemOfFile = StemOfFile.Select(b => new Word
            {
                WFull = b.WFull,
                WType = b.WType,
                Wcount = b.Wcount,
                WScount=b.WScount,
                WStemp=b.WStemp,
                WRank = b.WRank,
                Wfrequency = b.Wfrequency,
                Constant=b.Constant
            }).OrderByDescending(a => a.Wfrequency).ToList();
        }
        public void ReOrderWordListByConstant()
        {
            StemOfFile = StemOfFile.Select(b => new Word
            {
                WFull = b.WFull,
                WType = b.WType,
                Wcount = b.Wcount,
                WScount = b.WScount,
                WStemp = b.WStemp,
                WRank = b.WRank,
                Wfrequency = b.Wfrequency,
                Constant = b.Constant
            }).OrderByDescending(a => a.Constant).ToList();
        }*/
