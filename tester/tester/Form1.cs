using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbutton_Click(object sender, EventArgs e)
        {



            if (label7.Text == "1453")
            {
                yanlış++;
                yanlıslabel.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = true;
            }

            if (label7.Text == cbutton.Text)
            {
                dogru++;
                dogrulabel.Text = dogru.ToString();
                pictureBox1.Visible = true;
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = true;
                 
            }


        }

        int dogru = 0, yanlış = 0, soruno=0;
        private void digersoru_Click(object sender, EventArgs e)
        {

            abutton.Enabled = true;
            bbutton.Enabled = true;
            cbutton.Enabled = true;
            dbutton.Enabled = true;
            digersoru.Enabled = false;

            soruno++;
            sorulabel.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Fatih Sultan Mehmet kaç yılında İstanbulu Fetih etmiştir ?";
                abutton.Text = "1453";
                bbutton.Text = "1881";
                cbutton.Text = "1234";
                dbutton.Text = "1452";
                label7.Text = "1453";
            }
            else if (soruno == 2)
            {
                richTextBox1.Text = "Atatürk kaç yılında vefat etmiştir ?";
                abutton.Text = "1977";
                bbutton.Text = "1881";
                cbutton.Text = "1938";
                dbutton.Text = "1981";
                label7.Text = "1938";
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            else
            {
                richTextBox1.Text = "Loading :)";
                abutton.Text = "A";
                bbutton.Text = "B";
                cbutton.Text = "C";
                dbutton.Text = "D";
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                
            }

        }

        private void abutton_Click(object sender, EventArgs e)
        {


            if (label7.Text == abutton.Text)
            {
                dogru++;
                dogrulabel.Text = dogru.ToString();
                pictureBox1.Visible = true;
                digersoru.Enabled = true;
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = true;
                
                
            }
            else if (label7.Text == "1938")
            {
                yanlış++;
                yanlıslabel.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = true;
            }

        }

        private void bbutton_Click(object sender, EventArgs e)
        {

            if (label7.Text== "1453")
            {
                yanlış++;
                yanlıslabel.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = true;
            }
            else if (label7.Text == "1938")
            {
                yanlış++;
                yanlıslabel.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = true;
            }

        }

        private void dbutton_Click(object sender, EventArgs e)
        {

            if (label7.Text == "1453")
            {
                yanlış++;
                yanlıslabel.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = true;
            }
            else if (label7.Text == "1938")
            {
                yanlış++;
                yanlıslabel.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                abutton.Enabled = false;
                bbutton.Enabled = false;
                cbutton.Enabled = false;
                dbutton.Enabled = false;
                digersoru.Enabled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
