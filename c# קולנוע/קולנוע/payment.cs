using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace קולנוע
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label7.Text = Form4.countseats;
            label8.Text = Form2.sum.ToString();
            label9.Text = Form2.price.ToString();
            label12.Text = Form1.type1;
            label13.Text = Form1.movie1;
            label15.Text = Form1.tarih1;
            label16.Text = Form1.tim1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
         
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4.countseats = "";
            MessageBox.Show("צפייה נעימה:)");
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
