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
        
        public List<Word> WordsOfFile = new List<Word>();
          public  ZipfProcess()
        {

        }
        public void InitWordsOfFile(string[]  _contentOfFile)
        {
            int o = 0;
            for(o=0; o< _contentOfFile.Length; o++)
            {
                string _word = _contentOfFile[o];
                bool existWordFlag = WordsOfFile.Exists(a => a.WFull.Equals(_word,StringComparison.OrdinalIgnoreCase));
                if (existWordFlag != true)
                {
                    int wc = _contentOfFile.Where(a => a.Equals(_word, StringComparison.OrdinalIgnoreCase)).Count();//Kelimenin tekrarı
                    string wt = "İncelenmemiş Kelime";
                    int wo = o + 1;
                    Word word = new Word(_word, wt, wc,wo);
                    WordsOfFile.Add(word);                 
                }

            }
        }
        public void CalculateWfrequency()
        {
            for (int w = 0; w <WordsOfFile.Count; w++)
            {
                double wc = WordsOfFile[w].Wcount;
                double wo = WordsOfFile[w].Worder;
                double wf = wc / wo;
                double roundwf = System.Math.Round(wf, 3);
                WordsOfFile[w].Wfrequency = roundwf;
            }
        }
        public void ReOrderWordListByFrequency()
        {
            WordsOfFile = WordsOfFile.Select(b=>new Word{
                WFull = b.WFull,
                WType = b.WType,
                Wcount =b.Wcount,
                Worder = b.Worder,
                Wfrequency =b.Wfrequency               
            }).OrderByDescending(a=>a.Wfrequency).ToList();
        }
        public void MorphologyAnalysis()
        {
            Zemberek zemberek = new Zemberek(new TurkiyeTurkcesi());
            //sırayla kelimeleri ek kök ayrımına sokmak gerekli
            for (int w=0; w<=WordsOfFile.Count; w++)
            {
                string _wfull = WordsOfFile[w].WFull;
                /*kelimeDenetle methodu, bir kelimenin doğru yazılıp yazılmadığını kontrol eder. Türkçe’de olmayan bir kelime ise “false” değeri döndürür.*/
                if (zemberek.kelimeDenetle(_wfull))
                {
                    
                   AdditionalGrammar ag = new AdditionalGrammar();
                   Kelime [] CozumluKelime= zemberek.kelimeCozumle(_wfull);
                    int c = CozumluKelime.Count() - 1;
                    EkYonetici sozluk = zemberek.dilBilgisi().ekler();
                   
                   
                       
                        Kok _wstemp = CozumluKelime[c].kok();
                        List<Ek> leks = CozumluKelime[c].ekler();
                      
                        ag.EkList.AddRange(leks);
                        string kok = _wstemp.icerik();
                        string tip = leks[0].ad();

                        WordsOfFile[w].WType = tip;
                        WordsOfFile[w].WStemp = kok;
                        WordsOfFile[w].Wadds = ag;
                   
                
                }
                
            }
        }
    }
}
