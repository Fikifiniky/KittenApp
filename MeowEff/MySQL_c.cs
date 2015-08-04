
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MeowEff
{
    class MySQL_c
    {
        MySqlConnection connect = new MySqlConnection("server=localhost;uid=root;pwd=;database=email");
        public void QUERY(string sql)
        {
            //connect.Open();
            try
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connect.Close();
            }

        }


    }
}
