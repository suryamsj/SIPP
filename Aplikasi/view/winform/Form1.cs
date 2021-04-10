using SIPP.controller;
using SIPP.view.usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPP
{
    public partial class SIPP : Form
    {
        Connection connection = new Connection();
        public SIPP()
        {
            InitializeComponent();
        }

        private void SIPP_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        public void Backup_Database()
        {
            connection.Backup_Database();
        }

        public void Truncate_Table()
        {
            connection.TruncateTable("barang");
        }

        public void RefreshDashboard()
        {
            Dashboard_User.Self.TampilData();
        }

        public void RefreshBarang()
        {
            Barang_User.Self.TampilData();
        }

        private void Tombol_Dashboard_Click(object sender, EventArgs e)
        {
            if (!Badan_panel.Controls.Contains(Dashboard_User.Instance))
            {
                Badan_panel.Controls.Add(Dashboard_User.Instance);
                Dashboard_User.Instance.Dock = DockStyle.Fill;
                Dashboard_User.Instance.BringToFront();
            }
            else
            {
                Dashboard_User.Instance.BringToFront();
            }
        }

        private void Tombol_DataP_Click(object sender, EventArgs e)
        {
            if (!Badan_panel.Controls.Contains(Barang_User.Instance))
            {
                Badan_panel.Controls.Add(Barang_User.Instance);
                Barang_User.Instance.Dock = DockStyle.Fill;
                Barang_User.Instance.BringToFront();
            }
            else
            {
                Barang_User.Instance.BringToFront();
            }
        }

        private void Tombol_CariP_Click(object sender, EventArgs e)
        {
            if (!Badan_panel.Controls.Contains(Cari_User.Instance))
            {
                Badan_panel.Controls.Add(Cari_User.Instance);
                Cari_User.Instance.Dock = DockStyle.Fill;
                Cari_User.Instance.BringToFront();
            }
            else
            {
                Cari_User.Instance.BringToFront();
            }
        }

        private void Tombol_Laporan_Click(object sender, EventArgs e)
        {
            if (!Badan_panel.Controls.Contains(Laporan_User.Instance))
            {
                Badan_panel.Controls.Add(Laporan_User.Instance);
                Laporan_User.Instance.Dock = DockStyle.Fill;
                Laporan_User.Instance.BringToFront();
            }
            else
            {
                Laporan_User.Instance.BringToFront();
            }
        }

        private void Tombol_Truncate_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin mau mengkosongkan table di database?", "Perhatian", MessageBoxButtons.YesNo);
            if (pesan == DialogResult.Yes)
            {
                Truncate_Table();
                MessageBox.Show("Berhasil mengkosongkan database", "Informasi");
                RefreshDashboard();
                RefreshBarang();
            }
        }

        private void Tombol_Backup_Click(object sender, EventArgs e)
        {
            Backup_Database();
        }
    }
}
