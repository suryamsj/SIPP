using SIPP.controller;
using SIPP.model;
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
    public partial class Barang_User : UserControl
    {
        private static Barang_User barang;
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper ScrollV;
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper ScrollH;
        Connection connection = new Connection();
        PengeluaranDAO pengeluaran = new PengeluaranDAO();
        string id;
        public static Barang_User Instance
        {
            get
            {
                if(barang == null)
                {
                    barang = new Barang_User();
                }
                return barang;
            }
        }

        Barang_User getMain()
        {
            foreach (UserControl form in Application.OpenForms)
                if (form is Barang_User)
                    return (Barang_User)form;
            return null;
        }
        public static Barang_User Self;
        public Barang_User()
        {
            InitializeComponent();
            Self = this;
        }

        public void TampilData()
        {
            DataTable.DataSource = connection.ShowDataInGridView("SELECT * FROM barang");
        }

        public void TampilDashboard()
        {
            Dashboard_User.Self.TampilData();
        }

        private void Barang_User_Load(object sender, EventArgs e)
        {
            //SCROLLBAR
            ScrollV = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DataTable, Vertical, true);
            ScrollH = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DataTable, Horizontal, true);

            //Tampil Data
            TampilData();

            //ATUR DATAGRIDVIEW
            DataTable.ColumnHeadersHeight = 25;
            DataTable.Columns[0].HeaderText = "#";
            DataTable.Columns[1].HeaderText = "Nama Barang";
            DataTable.Columns[2].HeaderText = "Jumlah Barang";
            DataTable.Columns[3].HeaderText = "Harga Barang";
            DataTable.Columns[3].DefaultCellStyle.Format = "Rp " + " #,###0.00;($#,###0.00);0";
            DataTable.Columns[4].HeaderText = "Tanggal Pembelian";
            DataTable.Columns[4].DefaultCellStyle.Format = "dddd, d MMMM yyyy";

            //Utility
            TanggalBeli.Value = DateTime.Today;
            Tombol_Ubah.Enabled = false;
            Tombol_Hapus.Enabled = false;
        }

        private void Tombol_Simpan_Click(object sender, EventArgs e)
        {
            if(NamaBarang.Text == "" || JumlahBarang.Value == 0 || HargaBarang.Text == "")
            {
                MessageBox.Show("Form tidak boleh kosong!", "Informasi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Pengeluaran keluar = new Pengeluaran();
                keluar.Namabarang = NamaBarang.Text;
                keluar.Hargabarang = Convert.ToInt32(HargaBarang.Text);
                keluar.Jumlahbarang = Convert.ToInt32(JumlahBarang.Value.ToString());
                keluar.Tanggalpembelian = TanggalBeli.Value.ToString("yyyy/MM/dd");

                pengeluaran.TambahData(keluar);
                NamaBarang.Text = "";
                JumlahBarang.Value = 0;
                HargaBarang.Text = "";

                TampilData();
                TampilDashboard();
            }
        }

        private void Tombol_Ubah_Click(object sender, EventArgs e)
        {
            if (NamaBarang.Text == "" || JumlahBarang.Value == 0 || HargaBarang.Text == "")
            {
                MessageBox.Show("Form tidak boleh kosong!", "Infoormasi", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Pengeluaran keluar = new Pengeluaran();

                keluar.Namabarang = NamaBarang.Text;
                keluar.Hargabarang = Convert.ToInt32(HargaBarang.Text);
                keluar.Jumlahbarang = Convert.ToInt32(JumlahBarang.Value.ToString());
                keluar.Tanggalpembelian = TanggalBeli.Value.ToString("yyyy/MM/dd");

                pengeluaran.UbahData(keluar,id);
                NamaBarang.Text = "";
                JumlahBarang.Value = 0;
                HargaBarang.Text = "";

                TampilData();
                TampilDashboard();
            }
        }

        private void Tombol_Hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin mau hapus data ini?", "Info", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(pesan == DialogResult.Yes)
            {
                pengeluaran.HapusData(id);
                TampilData();
                TampilDashboard();
            }
        }

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Tombol_Ubah.Enabled = true;
            Tombol_Hapus.Enabled = true;

            if (e.RowIndex >= 0)
            {
                id = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                NamaBarang.Text = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                JumlahBarang.Text = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                HargaBarang.Text = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                TanggalBeli.Text = DataTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
