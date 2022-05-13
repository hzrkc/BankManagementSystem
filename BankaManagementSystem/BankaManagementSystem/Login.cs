using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BankaManagementSystem
{
    public partial class Login : Form
    {
     
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Müşteri_Click(object sender, EventArgs e)
        {
            Menu_Login.Login_Mus Hesap = new Menu_Login.Login_Mus();
            Hesap.Show();
            this.Hide();
        }

        private void btn_BankaMüdürü_Click(object sender, EventArgs e)
        {
            Menu_Login.Login_BMüdürü Hesap = new Menu_Login.Login_BMüdürü();
            Hesap.Show();
            this.Hide();
        }

        private void btn_MüşteriTemsilcisi_Click(object sender, EventArgs e)
        {
            Menu_Login.Login_MusTemsilcisi Hesap = new Menu_Login.Login_MusTemsilcisi();
            Hesap.Show();
            this.Hide();
        }

        private void btn_WindowClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MinWindow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            this.WindowState |= FormWindowState.Minimized;
        }

    }
}
