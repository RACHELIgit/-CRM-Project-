using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class Data
    {


        //פתיחת קובץ
        public static string OpentextFile()
        {
            string str1 = "";
            StreamReader sr = File.OpenText("d://tanachtwexta.txt");
            str1 = sr.ReadToEnd();//קריאה זו היא היעילה ביותר כי שאר הקריאו

            return str1;
        }
    }
}
