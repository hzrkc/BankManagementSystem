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

namespace BankaManagementSystem.Menu_Login
{
    public partial class Login_Mus : Form
    {
        // PostgreSql veritabanına bağlantı oluşturmak için değişkenler
        private string connstring = String.Format("Server={0};Port={1};" +
                                                  "User Id={2};Password={3};Database={4};",
                                                  "localhost", 5432, "postgres", "7163", "bankManagement");
        private NpgsqlConnection conn;
        // sql sorguları ve komutları oluşturmak için değişkenler
        private string sql;
        private NpgsqlCommand cmd;
        public Login_Mus()
        {
            InitializeComponent();
        }

        private void Login_Mus_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * From login_müşteri(:_tc,:_sifre)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_tc", int.Parse(MskdTxBox_Tc.Text));
                cmd.Parameters.AddWithValue("_sifre", TxtBox_sifre.Text);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {

                    Hesap_MüşteriHesabı hesap_Müşteri = new Hesap_MüşteriHesabı();
                    hesap_Müşteri.tc = int.Parse(MskdTxBox_Tc.Text);
                    hesap_Müşteri.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Giriş başarısız.");
                    return;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }

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


        private void picBox_CloseChildForm_Click(object sender, EventArgs e)
        {
            Login anaSayfa = new Login();
            this.Hide();
            anaSayfa.Show();
            
        }
    }
}
