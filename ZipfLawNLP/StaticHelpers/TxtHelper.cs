using System.IO;

namespace ZipfLaw_NLP.StaticHelpers
{
    public static class TxtHelper
    {
        public static string PrepareFilePath(string _filename, string _dicname)
        {
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = System.IO.Path.Combine(dir, _dicname);
            string file = _filename;
            string FilePath = System.IO.Path.Combine(path, file);
            return FilePath;
        }
        public static string ExtractTextFromTxt(string path)
        {
            StreamReader SR_nesnesi = File.OpenText(path);
            string satir;
            string metin = string.Empty;
            satir = SR_nesnesi.ReadLine();// ilk satırı okur
            int c = 0;
            while (satir != null /*&& c<15*/)
            {

                metin = metin + satir;
                satir = SR_nesnesi.ReadLine();// sonraki satırı okumak için
                metin = metin + " ";
                c++;
            }
            SR_nesnesi.Close();

            return metin;
        }
    
    }
}
