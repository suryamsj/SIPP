using MySql.Data.MySqlClient;
using SIPP.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPP.view.usercontrols
{
    public partial class Cari_User : UserControl
    {
        private static Cari_User cari;
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper ScrollV;
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper ScrollH;
        Connection connection = new Connection();

        public static Cari_User Instance
        {
            get
            {
                if (cari == null)
                {
                    cari = new Cari_User();
                }
                return cari;
            }
        }

        Cari_User getMain()
        {
            foreach (UserControl form in Application.OpenForms)
                if (form is Cari_User)
                    return (Cari_User)form;
            return null;
        }
        public static Cari_User Self;

        public Cari_User()
        {
            InitializeComponent();
            Self = this;
        }

        private void Cari_User_Load(object sender, EventArgs e)
        {
            //Datepicker
            TanggalBeli.Value = DateTime.Today;
            Tombol_Reset.Enabled = false;
        }

        private void Tombol_Cari_Click(object sender, EventArgs e)
        {
            string pengeluaran = NamaBarang.Text;
            int tahun = TanggalBeli.Value.Year;
            int bulan = TanggalBeli.Value.Month;

            if (NamaBarang.Text == "")
            {
                MessageBox.Show("Nama Barang tidak boleh kosong!", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //BUTTON
                    Tombol_Reset.Enabled = true;

                    //SCROLLBAR
                    ScrollV = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DataTable, Vertical, true);
                    ScrollH = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DataTable, Horizontal, true);

                    //TABLE
                    DataTable.DataSource = connection.ShowDataInGridView("SELECT nm_barang, jml_barang,hg_barang,tgl_beli FROM barang WHERE YEAR(tgl_beli) LIKE '%' '" + tahun + "' '%' AND MONTH(tgl_beli) LIKE '%' '" + bulan + "' '%' AND nm_barang LIKE '%' '" + pengeluaran + "' '%'");

                    //ATUR DATAGRIDVIEW
                    DataTable.ColumnHeadersHeight = 25;
                    DataTable.Columns[0].HeaderText = "Nama Barang";
                    DataTable.Columns[1].HeaderText = "Jumlah Barang";
                    DataTable.Columns[2].HeaderText = "Harga Barang";
                    DataTable.Columns[2].DefaultCellStyle.Format = "Rp " + " #,###0.00;($#,###0.00);0";
                    DataTable.Columns[3].HeaderText = "Tanggal Pembelian";
                    DataTable.Columns[3].DefaultCellStyle.Format = "dddd, d MMMM yyyy";

                    //PENGELUARAN YANG DICARI
                    LabelBarang.Text = pengeluaran;

                    //JUMLAH BARANG
                    connection.OpenConection();
                    MySqlDataReader dr = connection.DataReader("SELECT SUM(jml_barang) AS JumlahBarang FROM barang WHERE YEAR(tgl_beli) LIKE '%' '" + tahun + "' '%' AND MONTH(tgl_beli) LIKE '%' '" + bulan + "' '%' AND nm_barang LIKE '%' '" + pengeluaran + "' '%'");
                    dr.Read();
                    LabelJumlah.Text = dr["JumlahBarang"].ToString();
                    connection.CloseConnection();

                    //HARGA BARANG
                    connection.OpenConection();
                    MySqlDataReader dt = connection.DataReader("SELECT SUM(hg_barang) AS HargaBarang FROM barang WHERE YEAR(tgl_beli) LIKE '%' '" + tahun + "' '%' AND MONTH(tgl_beli) LIKE '%' '" + bulan + "' '%' AND nm_barang LIKE '%' '" + pengeluaran + "' '%'");
                    dt.Read();
                    int harga = Convert.ToInt32(dt["HargaBarang"]);
                    LabelHarga.Text = "Rp. " + harga.ToString("#,##0");
                    connection.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Tombol_Reset_Click(object sender, EventArgs e)
        {
            //TABLE
            DataTable.DataSource = null;

            //TEXTBOX
            LabelHarga.Text = "-";
            LabelBarang.Text = "-";
            LabelJumlah.Text = "-";
            NamaBarang.Text = "";

            //BUTTON
            Tombol_Reset.Enabled = false;
        }
    }
}
