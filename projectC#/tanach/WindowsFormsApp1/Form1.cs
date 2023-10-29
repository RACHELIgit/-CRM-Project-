using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using exeption;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
      

        
    
        
        string str = BLL.indexText.FILE();
        public static List<string> listResultString = new List<string>();
        // יבוא של קובצי ה JSON 
        public static  Dictionary<string, List<int>> d1 = BLL.indexText.Opentextjason();
         public static  Dictionary<string, List<string>> d2 = BLL.indexText.Opentextjason1();
        // LIST  של תוצאות
          public static List<int> lResult = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
          
            lResult = null;
            richTextBoxTanac.Text = BLL.indexText.FILE();
           
            //BLL.indexText.BuildIndexList();
            if (BLL.indexText.JsonIsDefinde()==null)
                buttonBuild.Enabled = true;
            else
                buttonBuild.Enabled = false;
           
        }

      

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            BLL.indexText.BuildIndexList(richTextBoxTanac.Text);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
               //  BLL.indexText.Search(textBoxSearch.Text);
                if (textBoxSearch.Text != null)
            {
             lResult=BLL.indexText.Search(textBoxSearch.Text,richTextBoxTanac.Text);
           if (lResult.Count == 0)
                {
                    labelFound.Visible = true;
              labelFound.Text = "אין תוצאות";
                }
                    
                   
           else
                listBoxResult.DataSource = lResult;
              
           
            }
                
        }

      
        // כפתור מחיקה 
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            //richTextBoxTanac.SelectionColor;
            listBoxResult.DataSource = null;
            labelFound.Text = "" ;
            richTextBoxTanac.Clear();
            richTextBoxTanac.Text = BLL.indexText.FILE();
        }

        private void textBoxSearch_MouseEnter(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // קריאה לפונקצית חיפושים אחרונים
            List<string> l3 = BLL.indexText.getlastsearch().ToList();
            if (l3.Count > 0)
            {
                listBoxLastSearch.Visible = true;
                listBoxLastSearch.DataSource = l3;
            }
        }
        // הדגשה 
        private void buttonTocolor_Click(object sender, EventArgs e)
        {

            int num = textBoxSearch.Text.Length;
            
            foreach (var x in lResult)
            {

                int index = x;
                String ss = richTextBoxTanac.Text;
                bool flag = false;
                int count = 0;
                while( flag!=true && count<10 && index!=-1)
                {
                    if (ss[index].Equals('[') == true)
                        flag = true;
                    count++;
                    index--;
                }
                if (flag == false) {
               richTextBoxTanac.SelectionStart = x;
               richTextBoxTanac.SelectionLength = num ;
               richTextBoxTanac.SelectionBackColor = Color.Pink;
            }
             }

        }

        private void buttonResult2_Click(object sender, EventArgs e)
        {
            // כפתור חיפוש 

            if (labelFound.Text != "אין תוצאות") { 
            if (textBoxSearch.Text.IndexOf(' ') != -1)
                listBoxResult.DataSource = BLL.indexText.lstring;
            else
            {
                listResultString = d2[textBoxSearch.Text];
                listBoxResult.DataSource = listResultString;
            }
                }
           
               
        }

        private void listBoxLastSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = listBoxLastSearch.SelectedItem.ToString();
        }

        
    }
}
