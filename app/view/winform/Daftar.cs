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

namespace SIPP.view.winform
{
    public partial class Daftar : Form
    {
        Admin admin = new Admin();
        CekLogin cek = new CekLogin();
        AdminDAO AdminDAO = new AdminDAO();

        public Daftar()
        {
            InitializeComponent();
        }

        private void Daftar_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tombol_Masuk_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Tombol_Daftar_Click(object sender, EventArgs e)
        {
            if(Username.Text == "" || Password.Text == "" || NamaLengkap.Text == "")
            {
                MessageBox.Show("Form tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                admin.Nama = NamaLengkap.Text;
                admin.Username = Username.Text;
                admin.Password = cek.HashMD5(Password.Text);

                AdminDAO.TambahData(admin);
                NamaLengkap.Text = "";
                Username.Text = "";
                Password.Text = "";
            }
        }

        private void LihatPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (LihatPassword.Checked == true)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '\u25CF';
            }
        }
    }
}
