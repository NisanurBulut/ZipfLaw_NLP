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
        public List<Stem> StemTypeBrief = new List<Stem>();
        public List<Add> AddsOfWords = new List<Add>();
        public List<Add> FinalAddsOfWords = new List<Add>();
        public int WordCount = 0;
        public int UniqueAddCount = 0;
        public int UniqueWordCount = 0;
        public int UniqueStemCount = 0;

        public ZipfProcess()
        {

        }
        public void FindAddsOfWords()
        {
            int o = 0;
            
            for (o = 0; o < WordsOfFile.Count; o++)
            {
                for(int a=1; a<WordsOfFile[o].Wadds.Count; a++)
                {
                    string add = WordsOfFile[o].Wadds[a];
                    Add ek = new Add();
                    ek.AddName = add;                  
                    AddsOfWords.Add(ek);
                }
            }
        }
        public void InitAddlist()
        {
            for (int a = 1; a < AddsOfWords.Count; a++)
            {
                Add add = AddsOfWords[a];
                int ac = AddsOfWords.Where(b => b.AddName.Equals(add.AddName, StringComparison.OrdinalIgnoreCase)).Count();//Kelimenin tekrarı        
                bool existWordFlag = FinalAddsOfWords.Exists(b => b.AddName.Equals(add.AddName, StringComparison.OrdinalIgnoreCase));
                add.Acount = ac;
                
                if (existWordFlag == false)
                {
                    UniqueAddCount = UniqueAddCount + 1;
                    FinalAddsOfWords.Add(add);
                }


            }

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
            UniqueWordCount = WordsOfFile.Count;

        }
        public void FindWordsForFileEn(string[] _contentOfFile)
        {
            int o = 0;
           
            for (o = 0; o < _contentOfFile.Length; o++)
            {
                Word _word = new Word();
                string _wordfull = _contentOfFile[o];
                //sırayla kelimeleri ek kök ayrımına sokmak gerekli
                
                /*kelimeDenetle methodu, bir kelimenin doğru yazılıp yazılmadığını kontrol eder. Türkçe’de olmayan bir kelime ise “false” değeri döndürür.*/
               
                    int wc = _contentOfFile.Where(a => a.Equals(_wordfull, StringComparison.OrdinalIgnoreCase)).Count();//Kelimenin tekrarı                                       
                    int wo = o + 1;//Kelimenin metinde bulunma sırası
                
                    _word.Wcount = wc;
                    _word.WFull = _wordfull;
                    WordsOfFile.Add(_word);
                   
            }
            UniqueWordCount = WordsOfFile.Count;

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
            StemTypeBrief = WordsOfFile.GroupBy(x => x.WType)
            .Select(n => new Stem
            {
                Type = n.Key,
                Count = n.Count()
            }
            ).ToList();
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
                    UniqueStemCount = UniqueStemCount + 1;
                }
            }
        }

        public void InitWordsOfFileen()
        {
            int o = 0;

            for (o = 0; o < WordsOfFile.Count; o++)
            {
                Word word = WordsOfFile[o];
                string _wstemp = WordsOfFile[o].WFull;

                int wc = WordsOfFile.Where(a => a.WFull.Equals(_wstemp, StringComparison.OrdinalIgnoreCase)).Count();//Kelimenin tekrarı                         
                WordsOfFile[o].WScount = wc;
                bool exist = StemOfFile.Exists(a => a.WFull == word.WFull);
                if (exist == false)
                {
                    
                    word = WordsOfFile[o];
                    word.WStemp = _wstemp;
                    StemOfFile.Add(word);
                    UniqueStemCount = UniqueStemCount + 1;
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
                double wf = wc / wo;
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
        public void CalculateAfrequency()
        {
            FinalAddsOfWords = FinalAddsOfWords.OrderByDescending(a => a.Acount).ToList();
            double N = FinalAddsOfWords.Count;
            for (int w = 0; w < FinalAddsOfWords.Count; w++)
            {
                double wc = FinalAddsOfWords[w].Acount;
                double wo = w + 1;
                double constant = wc * wo;//rankxsıklık
                double wf = wc / wo;
                double roundwf = System.Math.Round(wf, 3);
                double probr = wc / N;
                double a = probr * wo;
                FinalAddsOfWords[w].Rank = w + 1;
                FinalAddsOfWords[w].Afrequency = roundwf;
                FinalAddsOfWords[w].Constant = constant;
                FinalAddsOfWords[w].Probr = System.Math.Round(probr, 4);
                double rounda = System.Math.Round(a, 4);
                FinalAddsOfWords[w].A = rounda;
            
            }
        }



    }
}

