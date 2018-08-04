using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace קולנוע
{
    class SitSelect
    {
        public void GetSit(string Line, string Sit)
        {
            string strDb;
            strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;" + "Persist Security Info=False";
            OleDbConnection conn = new OleDbConnection(strDb);
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "update Theater set " +Sit+ "=1 where seats='" + Line + "'";
            int n = cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
