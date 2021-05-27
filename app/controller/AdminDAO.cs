using SIPP.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPP.controller
{
    class AdminDAO
    {
        Connection connection = new Connection();

        public bool TambahData(Admin admin)
        {
            Boolean status = false;
            try
            {
                connection.OpenConection();
                connection.ExecuteQueries("INSERT INTO admin (nama, username, password) VALUES ('" + admin.Nama + "', '" + admin.Username + "','" + admin.Password + "')");
                status = true;
                MessageBox.Show("Tambah Data berhasil dilakukan. Silahkan login", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
