using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_NLP.DescriptiveClassess
{
  public  class Word
    {
        public string WFull=string.Empty;
        public string WType = string.Empty;
        public int Wcount = 0;
        public int Worder = 0;
        public double Wfrequency = 0.0;
        public Word()
        {

        }
        public Word(string _wn,string _wt, int _wc,int _wo)
        {
            WFull = _wn;
            WType = _wt;
            Wcount = _wc;
            Worder = _wo;
        }
        public Word(string _wn, string _wt, int _wc, int _wo,double _wf)
        {
            WFull = _wn;
            WType = _wt;
            Wcount = _wc;
            Worder = _wo;
            Wfrequency = _wf;
        }
    }
}
