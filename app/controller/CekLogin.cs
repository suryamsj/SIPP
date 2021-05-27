using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPP.controller
{
    class CekLogin
    {
        Connection connection = new Connection();

        public bool cek_login(string username, string password)
        {
            try
            {
                connection.OpenConection();
                MySqlDataReader reader = connection.DataReader("SELECT * FROM admin WHERE username='" + username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    connection.CloseConnection();
                    return true;
                }
                else
                {
                    connection.CloseConnection();
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
            
        }

        public string HashMD5(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encoding = new UTF8Encoding();
            encrypt = md5.ComputeHash(encoding.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i<encrypt.Length; i++)
            {
                builder.Append(encrypt[i].ToString());
            }
            return builder.ToString();
        }
    }
}
