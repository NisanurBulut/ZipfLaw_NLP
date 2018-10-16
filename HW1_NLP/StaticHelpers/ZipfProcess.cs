using HW1_NLP.DescriptiveClassess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                bool existWordFlag = WordsOfFile.Exists(a => a.Wname.Equals(_word,StringComparison.OrdinalIgnoreCase));
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
                double roundwf = System.Math.Round(wf, 5);
                WordsOfFile[w].Wfrequency = roundwf;
            }
        }
        public void ReOrderWordListByFrequency()
        {
            WordsOfFile = WordsOfFile.Select(b=>new Word{
                Wname = b.Wname,
                WType = b.WType,
                Wcount =b.Wcount,
                Worder = b.Worder,
                Wfrequency =b.Wfrequency               
            }).OrderByDescending(a=>a.Wfrequency).ToList();
        }
    }
}
