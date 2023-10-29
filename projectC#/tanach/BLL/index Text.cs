using System.Collections.Generic;
using System.Linq;
using dall;
using exeption;
using System.Text.Json;
using static exeption.exeptionclass;

namespace BLL
{
  
    public class indexText
    {
        // האוסף ששם מאוחסן הקובץ json
        public static Dictionary<string, List<int>> d1 = new Dictionary<string, List<int>>();
        // האוסף של לכל מילה אוסף מיקומים של STRING  
        public static Dictionary<string, List<string>> d2 = new Dictionary<string, List<string>>();
        // עבור חיפושים אחרונים
        private static Queue<string> lastsearch = new Queue<string>();
        // עבור יצירת  D2
        public static  List<string> lstring = new List<string>();
        
     
        //  תור של  חיפושים אחרונים 
        public static Queue<string> getlastsearch( )
        {
            return lastsearch;
        }
        // // חיפוש מילה בלי האינדקסר 

       static List<int> l5 = new List<int>();
       
        // מחפש מילה בלי האינקסר
        public static List<int> SearchWord(string str, string str1)
        {
           // string str1 = dall.data.OpentextFile();
            int index = str1.IndexOf(str);
            List<int> mylist = new List<int>();
            lstring = new List<string>();
            int index2 = 0;
            while (index != -1)
            {
                mylist.Add(index);
                index2 = index;
                // מחפש את הפסוק והפרשה בו זה נמצא -----------------
                while (index2 != -1 && str1[index2].Equals(']') != true)
                {
                    index2--;
                }
                int index3 = index2;
                int count = 0;
                while (index3 != -1 && str1[index3].Equals('[') != true)
                {
                    index3--;
                    count++;
                }
                string ss = "";
                while (index3 != -1 && count >= 0)
                {
                    ss += str1[index3];
                    index3++;
                    count--;
                }
                if (lstring.Contains(str1) == false)
                    lstring.Add(ss);
             // -------------------------------------------
                index = str1.IndexOf(str, index+str.Length);
                         
             }
            return mylist;       
   
        }


        public static List<int> Search(string str,string str1)
        {    
            // יצירת חיפושים אחרונים 
            bool flag = false;
            if (str != "")
            {
                if (lastsearch.Count > 0)
                {
                    lastsearch.Enqueue("last");
                    string temp = lastsearch.First();
                    while (!temp.Equals("last"))
                    {
                        if (temp.Equals(str))
                        {
                            flag = true;
                        }
                        lastsearch.Enqueue(lastsearch.Dequeue());
                        temp = lastsearch.First();
                    }
                    lastsearch.Dequeue();
                }


                if (lastsearch.Count() <= 10 && !flag && str != "" && str!="לא נמצאו תוצאות")
                {
                    lastsearch.Enqueue(str);
                }
                else
                {
                    lastsearch.Dequeue();
                    lastsearch.Enqueue(str);
                }
            }
            /* חיפוש באינדקס*/
            d1 = data.Opentextjason();
            d2 = data.Opentextjason1();
            if (d1!=null && d1.ContainsKey(str) == true)
            {
                return d1[str];
            }
            else
            {
                return SearchWord(str,str1);
            }
        }
        // עובד פעם אחת
        // בניית האינדקסר
        public static void BuildIndexList(string str1)
        {
            List<int> l =new List<int>();
           

           // string str1 = data.OpentextFile();
            var arr = str1.Split(' ');
            for (int i = 9; i < arr.Length; i++)
            {
                if (!d1.ContainsKey(arr[i]))
                {
                   l= SearchWord(arr[i],str1);
                   d1.Add(arr[i], l);
                   d2.Add(arr[i], lstring);

                } 
            }
            data.toJson(d1);
            data.toJson1(d2);
        }

        // DATAפתיחת קובץ (קריאה לפונקתיה קימת ב 
        public static string FILE()
        {
            string str1 = data.OpentextFile();
            return str1;

           }
        // JSON פונקציית בדיקה האם נוצר כבר קובץ ה 
        public static Dictionary<string, List<int>> JsonIsDefinde()
        {
           Dictionary<string, List<int> > d1 = new Dictionary<string, List<int>>();
           
            try
            { return dall.data.Opentextjason(); }
            catch(Exceptionfilednull ex)
            {
                return ex.toString();
            }
          
        }
        // דילוגים עדיין לא עובד 
        public static List<string> sentence(char s,char e)
        {
            string str1 = data.OpentextFile();
            List<string> l = new List<string>();
            string str2 = "";
            bool flag = false;
            var arr = str1.Split(' ');
            //abc abc hjl daf fjdf
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i][0] == s )
                {
                    for (int j = i; j < arr.Length && flag != true ; i++)
                    {
                        str2 = arr[j] + " ";
                        if (arr[j][arr.Length] == e)
                        {
                            flag=true;  
                        }
                    }
                    if (str2 != " ") { 
                        l.Add(str2);
                        str2 = " ";
                        
                      }
                }

            }

            return null;
        }
        public static Dictionary<string,List<int>> Opentextjason()
        {
            return data.Opentextjason();
        }
        public static Dictionary<string, List<string>> Opentextjason1()
        {
            return data.Opentextjason1();
        }
    }
}

