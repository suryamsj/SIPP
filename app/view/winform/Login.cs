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

namespace SIPP.view.winform
{
    public partial class Login : Form
    {
        CekLogin login = new CekLogin();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void Tombol_Masuk_Click(object sender, EventArgs e)
        {
            if(Username.Text =="" || Password.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string username = Username.Text;
                string password = login.HashMD5(Password.Text);

                bool status = login.cek_login(username, password);
                if (status)
                {
                    SIPP sip = new SIPP();
                    MessageBox.Show("Selamat Datang!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sip.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Periksa kembali username dan password anda!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(LihatPassword.Checked == true)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '\u25CF';
            }
        }

        private void Tombol_Daftar_Click(object sender, EventArgs e)
        {
            Daftar daftar = new Daftar();
            daftar.Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
