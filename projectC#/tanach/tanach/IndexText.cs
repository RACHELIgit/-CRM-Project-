using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
namespace tanach
{
    public class IndexText
    {
        static Dictionary<string, List<int>> d1 = new Dictionary<string, List<int>>();
      
      
        // func1  // חיפוש מילה 
        public static List<int> SearchNotinIndexList(string str)
        {
            string str1 = Data. OpentextFile();
            List<int> l1 = new List<int>();
        
            int index = str1.IndexOf(str);
            while(index!=-1)
            {
                l1.Add(index);
                index=str1.IndexOf(str,index+str.Length);
            }
            if (l1.Count==0)
                return null ;
            return l1;

        }

        // 
        public static List<int> Search(string str)
        {
            if (d1.ContainsKey(str) == true)
                return d1[str];
            else
                return SearchNotinIndexList(str);
        }

        public static void BuildIndexList()
        {

            string str1 = Data.OpentextFile();
            var arr = str1.Split(' ');
            for (int i = 0; i < arr.Length; i++)
                Search(arr[i]);
            
        }

    }
}
