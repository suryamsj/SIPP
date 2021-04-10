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
    public partial class Dashboard_User : UserControl
    {
        private static Dashboard_User dashboard;

        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper ScrollV;
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper ScrollH;

        Connection connection = new Connection();

        public int year = DateTime.Now.Year;
        public int month = DateTime.Now.Month;
        public int day = DateTime.Now.Day;

        public static Dashboard_User Instance
        {
            get
            {
                if (dashboard == null)
                {
                    dashboard = new Dashboard_User();
                }
                return dashboard;
            }
        }

        Barang_User getMain()
        {
            foreach (UserControl form in Application.OpenForms)
                if (form is Barang_User)
                    return (Barang_User)form;
            return null;
        }
        public static Dashboard_User Self;
        public Dashboard_User()
        {
            InitializeComponent();
            Self = this;
        }

        public void TampilData()
        {
            try
            {
                DashboardTable.DataSource = connection.ShowDataInGridView("SELECT nm_barang,jml_barang,hg_barang,tgl_beli FROM barang WHERE YEAR(tgl_beli) ='" + year + "' AND MONTH(tgl_beli) = '" + month + "'");

                //PENGELUARAN HARI INI
                LabelHariIni.Text = "Pengeluaran Hari " + DateTime.Today.ToString("dddd");
                connection.OpenConection();
                MySqlDataReader hariIni = connection.DataReader("SELECT SUM(hg_barang) AS Harga FROM barang WHERE DAY(tgl_beli) = '" + day + "'");
                hariIni.Read();
                int harga = Convert.ToInt32(hariIni["Harga"]);
                label2.Text = "Rp. " + harga.ToString("#,##0");
                connection.CloseConnection();

                //PENGELUARAN BULAN INI
                LabelBulanIni.Text = "Pengeluaran Bulan " + DateTime.Today.ToString("MMMM");
                connection.OpenConection();
                MySqlDataReader bulanIni = connection.DataReader("SELECT SUM(hg_barang) AS HargaBulan FROM barang WHERE MONTH(tgl_beli) = '" + month + "'");
                bulanIni.Read();
                int bulan = Convert.ToInt32(bulanIni["HargaBulan"]);
                label3.Text = "Rp. " + bulan.ToString("#,##0");
                connection.CloseConnection();

                //PENGELUARAN TAHUN INI
                LabelTahunIni.Text = "Pengeluaran Tahun " + DateTime.Today.ToString("yyyy");
                connection.OpenConection();
                MySqlDataReader tahunIni = connection.DataReader("SELECT SUM(hg_barang) AS HargaTahun FROM barang WHERE YEAR(tgl_beli) = '" + year + "'");
                tahunIni.Read();
                int tahun = Convert.ToInt32(tahunIni["HargaTahun"]);
                label4.Text = "Rp. " + tahun.ToString("#,##0");
                connection.CloseConnection();

                //PENGELUARAN TERENDAH
                PengeluaranRendah.Text = "Pengeluaran Termurah Bulan " + DateTime.Today.ToString("MMMM");
                connection.OpenConection();
                MySqlDataReader murah = connection.DataReader("SELECT MIN(hg_barang) AS Murah FROM barang WHERE MONTH(tgl_beli) = '" + month + "'");
                murah.Read();
                int kecil = Convert.ToInt32(murah["Murah"]);
                label5.Text = "Rp. " + kecil.ToString("#,##0");
                connection.CloseConnection();

                //PENGELUARAN TERTINGGI
                PengeluaranTinggi.Text = "Pengeluaran Termahal Bulan " + DateTime.Today.ToString("MMMM");
                connection.OpenConection();
                MySqlDataReader mahal = connection.DataReader("SELECT MAX(hg_barang) AS Mahal FROM barang WHERE MONTH(tgl_beli) = '" + month + "'");
                mahal.Read();
                int besar = Convert.ToInt32(mahal["Mahal"]);
                label6.Text = "Rp. " + besar.ToString("#,##0");
                connection.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Data untuk hari ini kosong. Silahkan input data hari ini","Informasi");
                label2.Text = "Rp. -";
                label3.Text = "Rp. -";
                label4.Text = "Rp. -";
                label5.Text = "Rp. -";
                label6.Text = "Rp. -";
            }
        }

        private void Dashboard_User_Load(object sender, EventArgs e)
        {
            //Header table
            label7.Text = "Data Pengeluaran Hari " + DateTime.Today.ToString("dddd, d MMMM yyyy");

            //SCROLLBAR
            ScrollV = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DashboardTable, Vertical, true);
            ScrollH = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DashboardTable, Horizontal, true);

            //Tampil Data
            TampilData();

            //ATUR DATAGRIDVIEW
            DashboardTable.ColumnHeadersHeight = 25;
            DashboardTable.Columns[0].HeaderText = "Nama Barang";
            DashboardTable.Columns[1].HeaderText = "Jumlah Barang";
            DashboardTable.Columns[2].HeaderText = "Harga Barang";
            DashboardTable.Columns[2].DefaultCellStyle.Format = "Rp " + " #,###0.00;($#,###0.00);0";
            DashboardTable.Columns[3].HeaderText = "Tanggal Pembelian";
            DashboardTable.Columns[3].DefaultCellStyle.Format = "dddd, d MMMM yyyy";
        }
    }
}
