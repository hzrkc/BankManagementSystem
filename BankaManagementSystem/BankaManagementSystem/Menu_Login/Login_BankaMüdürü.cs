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
    public partial class Login_BankaMüdürü : Form
    {
        // PostgreSql veritabanına bağlantı oluşturmak için değişkenler
        private string connstring = String.Format("Server={0};Port={1};" +
                                                  "User Id={2};Password={3};Database={4};",
                                                  "localhost", 5432, "postgres", "7163", "bankManagement");
        private NpgsqlConnection conn;
        int result = 0; //giriş için kontrol

        // sql sorguları ve komutları oluşturmak için değişkenler
        private string sql;
        private NpgsqlCommand cmd;
        public Login_BankaMüdürü()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * From u_loginmus(:_tc,:_sifre)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_tc", int.Parse(TxtBox_Tc.Text));
                cmd.Parameters.AddWithValue("_sifre", TxtBox_sifre.Text);
                int result=(int)cmd.ExecuteScalar();
               

                if (result == 1)
                {   conn.Close();
                    Hesap_MüşteriHesabı hesap_Müşteri = new Hesap_MüşteriHesabı();
                    hesap_Müşteri.Show();
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

        private void Login_BankaMüdürü_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
