using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exeption;
using Newtonsoft.Json;
using static exeption.exeptionclass;

namespace dall
{
    public class data
    {
       
        //פתיחת קובץ
        public static string OpentextFile()
        {
            string str1 = "";
            try { 
            StreamReader sr = File.OpenText("D://searchProject//projectC#//aaa.txt");
   
            str1 = sr.ReadToEnd();//קריאה זו היא היעילה ביותר כי שאר הקריאו

            return str1;}
            catch(exeptionfileNoFound f1)
            {
                throw f1;
            }
        }

        // פונקציה הממירה בחזרה את הקובץ JSON 
        public static Dictionary<String, List<int>> Opentextjason()
        {
            try { 
                 Dictionary<String, List<int>> tanach = JsonConvert.DeserializeObject<Dictionary<String, List<int>>>(File.ReadAllText("D://searchProject//projectC#//Json.Json"));
                return tanach;

                    
            }
            catch( Exceptionfilednull ex)
            {
                throw ex;
            }
}
        public static Dictionary<String, List<string>> Opentextjason1()
        {
            try
            {
                Dictionary<String, List<string>> tanach = JsonConvert.DeserializeObject<Dictionary<String, List<string>>>(File.ReadAllText("D://searchProject//projectC#//Json1.Json"));
                return tanach;


            }
            catch (Exceptionfilednull ex)
            {
                throw ex;
            }
        }
        // פונקציה המקבלת dictionery וממירה אותו ל JSON 
        public static void toJson(Dictionary<string, List<int>> df)
            {
           
            string str= JsonConvert.SerializeObject(df);
            StreamWriter sw = File.CreateText("D://searchProject//projectC#//Json.json");
            sw.Write(str);
            sw.Close();

        }
        public static void toJson1(Dictionary<string, List<string>> df)
        {

            string str = JsonConvert.SerializeObject(df);
            StreamWriter sw = File.CreateText("D://searchProject//projectC#//Json1.json");
            sw.Write(str);
            sw.Close();

        }



    }




}