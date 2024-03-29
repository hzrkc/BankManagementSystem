﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BankaManagementSystem.Menu_Login
{
    public partial class Login_MusTemsilcisi : Form
    {

        // PostgreSql veritabanına bağlantı oluşturmak için değişkenler
        private string connstring = String.Format("Server={0};Port={1};" +
                                                  "User Id={2};Password={3};Database={4};",
                                                  "localhost", 5432, "postgres", "7163", "bankManagement");
        private NpgsqlConnection conn;

        // sql sorguları ve komutları oluşturmak için değişkenler
        private string sql;
        private NpgsqlCommand cmd;
        public Login_MusTemsilcisi()
        {
            InitializeComponent();
        }

        private void picBox_CloseChildForm_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * From Login_BankaCalışanları(:_tc,:_sifre,:_kullanıcıKodu)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_tc", int.Parse(MskdTxBox_Tc.Text));
                cmd.Parameters.AddWithValue("_sifre", TxtBox_sifre.Text);
                cmd.Parameters.AddWithValue("_kullanıcıKodu", 1);
                int result = (int)cmd.ExecuteScalar();


                if (result == 1)
                {
                    conn.Close();
                    Hesap_MüşteriTemsilcisi hesap_MüşteriTemsilcisi = new Hesap_MüşteriTemsilcisi();
                    hesap_MüşteriTemsilcisi.MusTemsilcisi_tc = int.Parse(MskdTxBox_Tc.Text);
                    hesap_MüşteriTemsilcisi.Show();
                    this.Hide();

                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Giriş başarısız.");
                    return;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                conn.Close();
            }
        }

        private void Login_MusTemsilcisi_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
