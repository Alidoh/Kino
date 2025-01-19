using System;
using System.Collections.Generic;

namespace Kino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
        }
        private List<Button> seznamtlacitek = new List<Button>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            Button clickedButton = sender as Button;
            seznamtlacitek.Add(clickedButton);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox7.Visible = true;
            groupBox6.Visible = false;
            groupBox8.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox8.Visible = true;
            groupBox7.Visible = false;
            groupBox6.Visible = false;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            groupBox2 = new GroupBox();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

