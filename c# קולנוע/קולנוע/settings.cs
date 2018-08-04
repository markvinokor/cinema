using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.OleDb;

namespace קולנוע
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            viewtable Table = new viewtable();
            InitializeComponent();
            DataGridView.DataSource = Table.GetTabledata();
            dataGridView1.DataSource = Table.GetTablevip();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string str;
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    str = textBox2.Text;
                    if (str == "123")
                    {
                        cmd.CommandText = "delete * from vip;";
                    }
                    else
                        MessageBox.Show("הסיסמא שהזנת שגויה נסה שנית");
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("נמחקו " + n.ToString() + " משתמשים");
                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string str;
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    str = textBox1.Text;
                    if (str == "123")
                    {
                        cmd.CommandText = "delete * from data;";
                    }
                    else
                        MessageBox.Show("הסיסמא שהזנת שגויה נסה שנית");
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("נמחקו " + n.ToString() + " נתונים");
                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    viewtable R = new viewtable();
                    string id;
                    string fname;
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    id = textBox4.Text;
                    fname = textBox3.Text;
                    cmd.CommandText = "update vip set fname='" + fname + "' where מזהה=" + id + "";
                    int n = cmd.ExecuteNonQuery();
                    MessageBox.Show("update " + n.ToString() + " row");
                    dataGridView1.DataSource = R.GetTablevip();
                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string id;
                    string lname;
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    id = textBox7.Text;
                    lname = textBox8.Text;
                    cmd.CommandText = "update vip set lname='" + lname + "' where מזהה=" + id + "";
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("update " + n.ToString() + " row");
                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string id;
                    string phone;
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    id = textBox5.Text;
                    phone = textBox6.Text;
                    cmd.CommandText = "update vip set phone='" + phone + "' where מזהה=" + id + "";
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("update " + n.ToString() + " row");
                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string id;
                    string email;
                    string strDb;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    id = textBox9.Text;
                    email = textBox10.Text;
                    cmd.CommandText = "update vip set email='" + email + "' where מזהה=" + id + "";
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("update " + n.ToString() + " row");
                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
