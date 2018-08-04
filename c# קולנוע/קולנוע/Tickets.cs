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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string str1 = "";
        public static int countragil = 0,counthayel=0,countstudent=0,countvip=0,sum=0,price=0;
        private void label14_Click(object sender, EventArgs e)
        {
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 0)
            {
                label17.Visible = false;
            }
            else
                label17.Visible = true;
            counthayel =40*(int) numericUpDown2.Value;
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            countragil = 50*(int) numericUpDown1.Value;
            
          

        }

        private void label17_Click(object sender, EventArgs e)
        {
      

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {if(numericUpDown1.Value == 0&& numericUpDown2.Value == 0&& numericUpDown3.Value == 0&& numericUpDown4.Value == 0)
                {
                    MessageBox.Show("בחר כרטיסים");
                }
            else
                if (numericUpDown4.Value == 0 || numericUpDown4.Value > 0 && str1 == "תקין")
                {

                    sum = (int)numericUpDown1.Value + (int)numericUpDown2.Value + (int)numericUpDown3.Value + (int)numericUpDown4.Value;
                    price = counthayel + countragil + countstudent + countvip;
                    countvip = 0;
                    counthayel = 0;
                    countragil = 0;
                    countstudent = 0;
                    string strDb2;
                    strDb2 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn4 = new OleDbConnection(strDb2);
                    conn4.Open();
                    OleDbDataReader dr4;
                    OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM data", conn4);
                    dr4 = cmd2.ExecuteReader();
                    string save1 = "";
                    while (dr4.Read())
                    {
                        save1 = (dr4[0].ToString());
                    }
                    dr4.Close();
                    conn4.Close();


                    string strDb3;
                    strDb3 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn5 = new OleDbConnection(strDb3);
                    conn5.Open();
                    OleDbDataReader dr5;
                    OleDbCommand cmd3 = new OleDbCommand("update data SET tickets='" + sum + "' WHERE numorder=" + save1, conn5);
                    dr5 = cmd3.ExecuteReader();

                    dr5.Close();
                    conn5.Close();

                    string strDb8;
                    strDb8 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn8 = new OleDbConnection(strDb8);
                    conn8.Open();
                    OleDbDataReader dr8;
                    OleDbCommand cmd8 = new OleDbCommand("update data SET price='" + price + "' WHERE numorder=" + save1, conn8);
                    dr8 = cmd8.ExecuteReader();

                    dr8.Close();
                    conn8.Close();

                    MessageBox.Show("הזמנת " + sum.ToString() + "כרטיסים במחיר " + price.ToString() + "שקלים ");
                    //  this.WindowState = FormWindowState.Minimized;
                    Form4 a = new Form4();
                    a.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("פרטי VIP שהזנת אינם נכונים");
        }
            }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 0)
            {
                label17.Visible = false;
            }
            else
                label17.Visible = true;

            countstudent =40*(int) numericUpDown3.Value;

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
           
            if (numericUpDown4.Value > 0)
            {
                label18.Visible = false;
            }
            else
                label18.Visible = true;
            if (str1 != "תקין")
            {
               
                numericUpDown4.Value = 99;
            }
            if (str1 == "תקין")
            {
                if (numericUpDown4.Value == 99|| numericUpDown4.Value == 100)
                {
                    numericUpDown4.Value = 1;
                }
            }


                countvip =30*(int) numericUpDown4.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
               
          
                    string strDb;
                    string phone;
                    strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                    OleDbConnection conn = new OleDbConnection(strDb);
                    conn.Open();
                    OleDbDataReader dr;
                    phone = textBox2.Text;
                    OleDbCommand cmd = new OleDbCommand("Select * from vip where phone =" + phone, conn);
                    dr = cmd.ExecuteReader();
                    str1 = "לא תקין";
                    while (dr.Read())
                    {
                        str1 = "תקין";
                         numericUpDown4.Value = 1;
                }

                    dr.Close();
                    conn.Close();
                    label19.Text = str1;
                    if (str1 == "תקין")
                    {
                        string strDb2;
                        strDb2 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                        OleDbConnection conn2 = new OleDbConnection(strDb2);
                        conn2.Open();
                        OleDbDataReader dr2;
                        OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM data", conn2);
                        dr2 = cmd2.ExecuteReader();
                    string save="";
                        while (dr2.Read())
                        {
                            save = (dr2[0].ToString());
                        }
                        dr2.Close();
                        conn2.Close();
                  

                     string strDb3;
                        strDb3 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                        OleDbConnection conn3 = new OleDbConnection(strDb3);
                        conn3.Open();
                        OleDbDataReader dr3;
                        OleDbCommand cmd3 = new OleDbCommand("update vip SET numorder='" + save + "' WHERE phone="+ phone, conn3);
                        dr3 = cmd3.ExecuteReader();

                    dr3.Close();
                   conn3.Close(); 
                }
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }
    }
 }
        


