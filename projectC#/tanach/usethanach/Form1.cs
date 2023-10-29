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


namespace usethanach
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = BLL.indexText.FILE();
           BLL.indexText.BuildIndexList();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            List<string> l3 = BLL.indexText.getlastsearch().ToList();
            if (l3.Count > 0)
            {
                listBox5.Visible = true;
                listBox5.DataSource = l3;
            }
        }
        /*
         listbox2=חיפושים אחרונים
         listbox1=תוצאות חיפוש
         button1-חיפוש 
          button2- 

         */

        private void button5_Click(object sender, EventArgs e)
        {
            listBox5.Visible = false;
            listBox4.DataSource = new List<string>();
            try
            {

                var l = BLL.indexText.Search(textBox4.Text);
                if (l != null)

                    listBox4.DataSource = l;
                else
                    textBox4.Text = "לא נמצאו תוצאות";
            }
            catch (exeptionclass.Exceptionfilednull ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.Select(2, 5);
            //richTextBox1.SelectionBackColor = Color.Yellow;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox4.Clear();
            //listBox1.();
            List<int> l2 = new List<int>();
            listBox4.DataSource = l2;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            search.Enabled = true;

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            List<string> l3 = BLL.indexText.getlastsearch().ToList();
            if (l3.Count > 0)
            {
                listBox5.Visible = true;
                listBox5.DataSource = l3;
            }
        }

        private void listBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = listBox5.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.DataSource = BLL.indexText.sentence(textBox2.Text[0], textBox3.Text[0]);
        }







        private void Form1_Load_1(object sender, EventArgs e)
        {
            richTextBox2.Text = BLL.indexText.FILE();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_Click(object sender, EventArgs e)
        {

        }

        
        private void button6_Click(object sender, EventArgs e)
        {

            if (BLL.indexText.JsonIsDefinde())
                MessageBox.Show("קים כבר");
            else
                BLL.indexText.BuildIndexList();


        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
         
                textBox4.Text = "";
        }

      

      

      

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//************************
//        private void Form1_Load(object sender, EventArgs e)
//        {
//            richTextBox1.Text = BLL.indexText.FILE();

//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }


//        private void button1_Click(object sender, EventArgs e)
//        {
//            listBox2.Visible = false;
//            listBox1.DataSource = new List<string>();
//            try
//            {

//                var l = BLL.indexText.Search(textBox1.Text);
//                if (l != null)

//                    listBox1.DataSource = l;
//                else
//                    label1.Text = "not found";
//            }
//            catch (exeptionclass.Exceptionfilednull ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void richTextBox1_TextChanged(object sender, EventArgs e)
//        {
//            //richTextBox1.Select(2, 5);
//            //richTextBox1.SelectionBackColor = Color.Yellow;
//        }

//        private void button1_Click_1(object sender, EventArgs e)
//        {
//            textBox1.Clear();
//            //listBox1.();
//            List<int> l2 = new List<int>();
//            listBox1.DataSource = l2;
//        }

//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

//        private void textBox1_MouseEnter(object sender, EventArgs e)
//        {
//            search.Enabled = true;

//        }

//        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
//        {

//            List<string> l3 = BLL.indexText.getlastsearch().ToList();
//            if (l3.Count > 0)
//            {
//                listBox2.Visible = true;
//                listBox2.DataSource = l3;
//            }
//        }

//        private void listBox2_MouseClick(object sender, MouseEventArgs e)
//        {
//            textBox1.Text = listBox2.SelectedValue.ToString();
//        }



//        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void label3_Click(object sender, EventArgs e)
//        {

//        }

//        private void button3_Click(object sender, EventArgs e)
//        {

//        }

//    }
//}







