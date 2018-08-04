using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace קולנוע
{
    class viewtable
    {
        public DataTable GetTabledata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("מספר הזמנה");
            dt.Columns.Add("שם הסרט");
            dt.Columns.Add("סוג הסרט");
            dt.Columns.Add("שפה");
            dt.Columns.Add("תאריך");
            dt.Columns.Add("שעה");
            dt.Columns.Add("מספר כרטיסים");
            dt.Columns.Add("מחיר");
            string strDb;
            strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            conn.Open();
            OleDbDataReader dr;
            OleDbCommand cmd = new OleDbCommand("Select * from data", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString() });
            }
            dr.Close();
            conn.Close();


            return dt;
        }
        public DataTable GetTablevip()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("מספר לקוח");
            dt.Columns.Add("שם פרטי");
            dt.Columns.Add("שם משפחה");
            dt.Columns.Add("טלפון");
            dt.Columns.Add("מייל");
            dt.Columns.Add("מספר הזמנה");
            string strDb;
            strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            conn.Open();
            OleDbDataReader dr;
            OleDbCommand cmd = new OleDbCommand("Select * from vip", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() });
            }
            dr.Close();
            conn.Close();


            return dt;
        }
        public DataTable GetTableTheater()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("כסא");
            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("3");
            dt.Columns.Add("4");
            dt.Columns.Add("5");
            string strDb;
            strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            conn.Open();
            OleDbDataReader dr;
            OleDbCommand cmd = new OleDbCommand("Select * from Theater", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString() });
            }
            dr.Close();
            conn.Close();


            return dt;
        }
    }
}
