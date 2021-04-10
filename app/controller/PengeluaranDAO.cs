using MySql.Data.MySqlClient;
using SIPP.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPP.controller
{
    class PengeluaranDAO
    {
        Connection connection = new Connection();

        public bool TambahData(Pengeluaran pengeluaran)
        {
            Boolean status = false;
            try
            {
                connection.OpenConection();
                connection.ExecuteQueries("INSERT INTO barang (nm_barang, jml_barang, hg_barang, tgl_beli) VALUES ('" + pengeluaran.Namabarang + "', '" + pengeluaran.Jumlahbarang + "','" + pengeluaran.Hargabarang + "','" + pengeluaran.Tanggalpembelian + "')");
                status = true;
                MessageBox.Show("Tambah Data berhasil dilakukan", "Info");
                connection.CloseConnection();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Data gagal ditambahkan", "Info");
            }
            return status;
        }

        public bool UbahData(Pengeluaran pengeluaran, string id)
        {
            Boolean status = false;
            try
            {
                connection.OpenConection();
                connection.ExecuteQueries("UPDATE barang SET nm_barang='" + pengeluaran.Namabarang + "'," + "jml_barang='" + pengeluaran.Jumlahbarang + "'," +
                    "hg_barang='" + pengeluaran.Hargabarang + "'," + "tgl_beli='" + pengeluaran.Tanggalpembelian + "' WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Ubah Data berhasil dilakukan", "Info");
                connection.CloseConnection();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Data gagal diubah", "Info");
            }
            return status;
        }

        public bool HapusData(string id)
        {
            Boolean status = false;
            try
            {
                connection.OpenConection();
                connection.ExecuteQueries("DELETE FROM barang WHERE id='" + id + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Info");
                connection.CloseConnection();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Data gagal dihapus", "Info");
            }
            return status;
        }
    }
}
