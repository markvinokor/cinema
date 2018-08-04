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
using System.Diagnostics;

namespace קולנוע
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public static string type1="";
        public static string movie1 = "";
        public static string tarih1 = "";
        public static string tim1 = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            label9.Visible = false;
            textBox5.Visible = false;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (comboBox1.GetItemText(comboBox1.SelectedItem) != ""&& comboBox2.GetItemText(comboBox2.SelectedItem)!=""&& comboBox3.GetItemText(comboBox3.SelectedItem)!="" && comboBox4.GetItemText(comboBox4.SelectedItem)!="")
                {
                    try
                    {
                        string strDb;
                        string movie = comboBox1.GetItemText(comboBox1.SelectedItem);
                        string type = comboBox2.GetItemText(comboBox2.SelectedItem);
                        string lang = comboBox3.GetItemText(comboBox3.SelectedItem);
                        string tarih = this.dateTimePicker1.Text;
                        string tim = comboBox4.GetItemText(comboBox4.SelectedItem);
                        type1 = type;
                        movie1 = movie;
                        tarih1 = tarih;
                        tim1 = tim;
                        strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
                        OleDbConnection conn = new OleDbConnection(strDb);
                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "insert into data (movie,type,lang,tarih,tim) values ('" + movie + "','" + type + "','" + lang + "','" + tarih + "','" + tim + "')";
                        int n = cmd.ExecuteNonQuery();
                    

                        conn.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                    {
                        // this.Hide();
                        //  this.WindowState = FormWindowState.Minimized;
                        Form2 a = new Form2();
                        a.Show();

                    }
                }
                else
                    MessageBox.Show("מלא את כל השדות");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://google.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                {
                    try
                    {
                        if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || radioButton1.Checked == false)
                        {

                            MessageBox.Show("יש למלא את כל השדות ולאשר את התקנון");
                        }
                        else
                        {
                            string strDb;
                            string lname = textBox1.Text;
                            string fname = textBox3.Text;
                            string phone = textBox2.Text;
                            string email = textBox4.Text;
                            strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.accdb;" + "Persist Security Info=False";
                            OleDbConnection conn = new OleDbConnection(strDb);
                            conn.Open();
                            OleDbCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "insert into vip (fname,lname,phone,email) values ('" + lname + "','" + fname + "', '" + phone + "', '" + email + "');";
                            int n = cmd.ExecuteNonQuery();
                            MessageBox.Show("insert " + n.ToString() + " row");
                            conn.Close();
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            label7.Text = comboBox1.SelectedItem.ToString();
            pictureBox1.Image = Image.FromFile(label7.Text + ".jpg");
            if (label7.Text == "חמישים גוונים של שחרור")
            {
                label8.Text = "החלק השלישי והאחרון בסיפור אהבתם חסר המעצורים של כריסטיאן גריי ואנסטסיה סטיל לאחר שלקחו את מערכת היחסים שלהם צעד אחד קדימה והתארסו, נדמה שיש להם הכול: אהבה, תשוקה, אינטימיות, עושר ואינספור אפשרויות.";


            }
            if (label7.Text == "הפנתר השחור")
            {
                label8.Text = "לאחר אירועי קפטן אמריקה: מלחמת האזרחים, המלך טצ'אלה חוזר לביתו בווקנדה אבל מגלה כי מלכותו התערערה ומוטלת בספק על ידי מפלגות שהוקמו בתוך ארצו. כאשר אויביו מאיימים לקרוע את הממלכה לגזרים, טצ'אלה חייב להיהפך לפנתר השחור ולחבור לסוכן CIA ולחברי הכוחות המיוחדים של ממלכתו, על מנת למנוע מלחמת אזרחים בארצו.";


            }
            if (label7.Text == "חי בסרט")
            {
                label8.Text = "סיפור חייו האמיתי של הבמאי המושמץ טומי ויזו, האיש שיצר את הסרט שנחשב לסרט הגרוע בכל הזמנים - החדר שהפך עם השנים לקאלט.";



            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string str;
                label9.Visible = true;
                textBox5.Visible = true;
                str = textBox5.Text;
                if (str == "123")
                {
                    //  this.WindowState = FormWindowState.Minimized;
                    Form3 a = new Form3();
                    a.Show();
                    this.Hide();
                }
                    if(str=="")
                    MessageBox.Show("הכנס סיסמא");
                    if(str!=""&&str!="123")
                    MessageBox.Show("הסיסמא שהזנת שגויה נסה שנית");

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Left <380)
            {
               pictureBox3.Left += 5;
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Left > 200)
            {
                pictureBox3.Left -= 5;
            }
            else
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }

