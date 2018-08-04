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
    public partial class Form4 : Form
    {
        public Form4()
        {
            
            viewtable Table = new viewtable();
            InitializeComponent();
            dataGridView1.DataSource = Table.GetTableTheater();
        }
        string Line;
        string Colmn;

        private void button2_Click(object sender, EventArgs e)
        {
            viewtable Table = new viewtable();
            SitSelect SS = new SitSelect();
            SS.GetSit(Line, Colmn);
            dataGridView1.DataSource = Table.GetTableTheater();
            countseats += "" + Line + "" + Colmn +"";
            stop--;
            if (stop == 0)
            {
                MessageBox.Show("הזמנת" + sum + "כסאות התקבלה לחץ על המשך");
            }
            
        }

        public static string countseats;
        int stop= Form2.sum;
        int sum = Form2.sum;

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
            this.Hide();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_a1.Checked == true)
            {
                Line = "A";
                Colmn = "1";
                button2_Click(null, EventArgs.Empty);
            }
        }
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_a2.Checked == true) { 
                Line = "A";
                Colmn = "2";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_a3.Checked == true)
            {
                Line = "A";
                Colmn = "3";
                button2_Click(null, EventArgs.Empty);
            }

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_a4.Checked == true)
            {
                Line = "A";
                Colmn = "4";
                button2_Click(null, EventArgs.Empty);
            }

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                viewtable Table = new viewtable();
                   for (int i = 1; i <= 5; i++)
                    {
                        try
                        {
                            string seats;
                            string strDb;
                            int j = 0;
                            seats = "D";
                            strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                            OleDbConnection conn = new OleDbConnection(strDb);
                            conn.Open();
                            OleDbCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "update Theater set " + i + "='" + j.ToString() + "' where seats='" + seats + "'";
                            int n = cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }
                    
                }
                for (int i = 1; i <= 5; i++)
                {
                    try
                    {
                        string seats;
                        string strDb;
                        int j = 0;
                        seats = "C";
                        strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                        OleDbConnection conn = new OleDbConnection(strDb);
                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "update Theater set " + i + "='" + j.ToString() + "' where seats='" + seats + "'";
                        int n = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
                for (int i = 1; i <= 5; i++)
                {
                    try
                    {
                        string seats;
                        string strDb;
                        int j = 0;
                        seats = "B";
                        strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                        OleDbConnection conn = new OleDbConnection(strDb);
                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "update Theater set " + i + "='" + j.ToString() + "' where seats='" + seats + "'";
                        int n = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
                for (int i = 1; i <= 5; i++)
                {
                    try
                    {
                        string seats;
                        string strDb;
                        int j = 0;
                        seats = "A";
                        strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                        OleDbConnection conn = new OleDbConnection(strDb);
                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "update Theater set " + i + "='" + j.ToString() + "' where seats='" + seats + "'";
                        int n = cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
                MessageBox.Show("הנתונים נמחקו בחר מקומות ישיבה");
                dataGridView1.DataSource = Table.GetTableTheater();
                countseats = null;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int sum=Form2.sum;
           
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_a5.Checked == true)
            {
                Line = "A";
                Colmn = "5";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_b1.Checked == true)
            {
                Line = "B";
                Colmn = "1";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_b2.Checked == true)
            {
                Line = "B";
                Colmn = "2";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_b3.Checked == true)
            {
                Line = "B";
                Colmn = "3";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_b4.Checked == true)
            {
                Line = "B";
                Colmn = "4";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_b5.Checked == true)
            {
                Line = "B";
                Colmn = "5";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_c1.Checked == true)
            {
                Line = "C";
                Colmn = "1";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_c2.Checked == true)
            {
                Line = "C";
                Colmn = "2";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_c3.Checked == true)
            {
                Line = "C";
                Colmn = "3";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_c4.Checked == true)
            {
                Line = "C";
                Colmn = "4";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_c5.Checked == true)
            {
                Line = "C";
                Colmn = "5";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_d2.Checked == true)
            {
                Line = "D";
                Colmn = "2";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_d3.Checked == true)
            {
                Line = "D";
                Colmn = "3";
                button2_Click(null, EventArgs.Empty);
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_d4.Checked == true)
            {
                Line = "D";
                Colmn = "4";
                button2_Click(null, EventArgs.Empty);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_d5.Checked == true)
            {
                Line = "D";
                Colmn = "5";
                button2_Click(null, EventArgs.Empty);
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_d1.Checked == true)
            {
                Line = "D";
                Colmn = "1";
                button2_Click(null, EventArgs.Empty);
            }
        }
    }
}
