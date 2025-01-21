using System;
using System.Collections.Generic;

namespace Kino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control[] groupBoxes = { groupBox2, groupBox3, groupBox5, groupBox6, groupBox7, groupBox8 };
            for (int i = 0; i < groupBoxes.Length; i++)
            {
                groupBoxes[i].Visible = false;
            }
        }
        private List<Button> seznamtlacitek = new List<Button>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBoxes.Length; i++)
            {
                groupBoxes[i].Visible = false;
            }
            groupBox2.Visible = true;
            Button clickedButton = sender as Button;
            seznamtlacitek.Add(clickedButton);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBoxes.Length; i++)
            {
                groupBoxes[i].Visible = false;
            }
            groupBox3.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBoxes.Length; i++)
            {
                groupBoxes[i].Visible = false;
            }
            groupBox5.Visible = true;
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

