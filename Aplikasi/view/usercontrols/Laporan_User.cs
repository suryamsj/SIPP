using DGVPrinterHelper;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SIPP.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPP.view.usercontrols
{
    public partial class Laporan_User : UserControl
    {
        private static Laporan_User laporan;
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper ScrollV;
        private Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper ScrollH;
        Connection connection = new Connection();

        public static Laporan_User Instance
        {
            get
            {
                if (laporan == null)
                {
                    laporan = new Laporan_User();
                }
                return laporan;
            }
        }

        Laporan_User getMain()
        {
            foreach (UserControl form in Application.OpenForms)
                if (form is Laporan_User)
                    return (Laporan_User)form;
            return null;
        }
        public static Laporan_User Self;


        public Laporan_User()
        {
            InitializeComponent();
            Self = this;
        }

        private void ToCsV(Guna2DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void Laporan_User_Load(object sender, EventArgs e)
        {
            //Tanggal
            TanggalBeli.Value = DateTime.Today;
        }

        private void Tombol_Cari_Click(object sender, EventArgs e)
        {
            try
            {
                int tahun = TanggalBeli.Value.Year;
                int bulan = TanggalBeli.Value.Month;

                //SCROLLBAR
                ScrollV = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DataTable, Vertical, true);
                ScrollH = new Guna.UI2.WinForms.Helpers.DataGridViewScrollHelper(DataTable, Horizontal, true);

                //TABLE
                DataTable.DataSource = connection.ShowDataInGridView("SELECT nm_barang, jml_barang,hg_barang,tgl_beli FROM barang WHERE YEAR(tgl_beli) LIKE '%' '" + tahun + "' '%' AND MONTH(tgl_beli) LIKE '%' '" + bulan + "' '%'");

                //ATUR DATAGRIDVIEW
                DataTable.ColumnHeadersHeight = 25;
                DataTable.Columns[0].HeaderText = "Nama Barang";
                DataTable.Columns[1].HeaderText = "Jumlah";
                DataTable.Columns[2].HeaderText = "Harga Barang";
                DataTable.Columns[2].DefaultCellStyle.Format = "Rp " + " #,###0.00;($#,###0.00);0";
                DataTable.Columns[3].HeaderText = "Tanggal Pembelian";
                DataTable.Columns[3].DefaultCellStyle.Format = "dddd, d MMMM yyyy";

                //TOTAL PENGELUARAN BULAN INI
                connection.OpenConection();
                MySqlDataReader dr = connection.DataReader("SELECT SUM(hg_barang) AS HargaBarang FROM barang WHERE YEAR(tgl_beli) LIKE '%' '" + tahun + "' '%' AND MONTH(tgl_beli) LIKE '%' '" + bulan + "' '%'");
                dr.Read();
                int harga = Convert.ToInt32(dr["HargaBarang"]);
                LabelTotal.Text = "Rp. " + harga.ToString("#,##0");
                connection.CloseConnection();
            }
            catch(Exception ex)
            {
                LabelTotal.Text = "-";
                MessageBox.Show(ex.Message, "Informasi");
            }

        }

        private void Tombol_Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xls)|*.xls";
            save.FileName = "Pengeluaran.xls";
            if (save.ShowDialog() == DialogResult.OK)
            {
                ToCsV(DataTable, save.FileName);
            }
        }

        private void Tombol_Print_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Sistem Informasi Pencatatan Pengeluaran";
                printer.SubTitle = DateTime.Now.Date.ToString("dddd, MMMM d yyyy");
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.SubTitleSpacing = 15;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Total Pengeluaran : " + LabelTotal.Text + "\r\n" + "SIIP By Muhammad Surya J" + "\r\n" + "Nomor WA : 085155001401" + "\r\n" + "Terima Kasih";
                printer.FooterSpacing = 15;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(DataTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Informasi");
            }
        }
    }
}
