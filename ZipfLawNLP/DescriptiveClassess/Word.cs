using System.Collections.Generic;

namespace ZipfLaw_NLP.DescriptiveClassess
{
    public class Word
    {
        public string WFull = string.Empty;
        public string WType = string.Empty;
        public int Wcount = 0;
        public int WScount = 0;
        public int WRank = 0;
        public double Wfrequency = 0.0;
        public double Probr = 0.0;
        public string WStemp = string.Empty;
        public List<string> Wadds=new List<string>();
        public double Constant = 0;
        public double A = 0.0;
      

        public Word()
        {

        }
        public Word(string _wn,string _wt, int _wc)
        {
            WScount = _wc;
            WFull = _wn;
            WType = _wt;            

        }
        public Word(string _wn, string _wt, int _wc, int _wo,double _wf)
        {
            WFull = _wn;
            WType = _wt;         
            Wfrequency = _wf;
            WScount = _wc;
        }
    }
}
