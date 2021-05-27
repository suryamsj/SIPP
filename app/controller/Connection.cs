using MySql.Data.MySqlClient;
using Syroot.Windows.IO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPP.controller
{
    class Connection
    {
        string ConnectionString = "server=localhost;database=pengeluaran;uid=root;pwd='';";
        MySqlConnection con;

        public void OpenConection()
        {
            con = new MySqlConnection(ConnectionString);
            con.Open();
        }
        public void CloseConnection()
        {
            con.Close();
        }
        public void ExecuteQueries(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }
        public MySqlDataReader DataReader(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public object ShowDataInGridView(string Query_)
        {
            MySqlDataAdapter dr = new MySqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public void Backup_Database()
        {
            string Sekarang = DateTime.Today.ToString("dd-MM-yyyy");
            string FolderDownload = new KnownFolder(KnownFolderType.Downloads).Path;
            string file = FolderDownload + @"\backup_database_" + Sekarang + ".sql";

            try
            {
                MySqlConnection kon = new MySqlConnection(ConnectionString);
                MySqlCommand komand = new MySqlCommand();
                MySqlBackup backup = new MySqlBackup(komand);

                komand.Connection = kon;
                kon.Open();
                backup.ExportToFile(file);
                kon.Close();

                MessageBox.Show("Database berhasil dibackup. File backup berada di " + FolderDownload, "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal backup database",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        public void TruncateTable(string table)
        {
            try
            {
                string query = "TRUNCATE TABLE " + table;
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                MessageBox.Show("Berhasil mengkosongkan table di database", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message,"Gagal Mengkosongkan table di database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
