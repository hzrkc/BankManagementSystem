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
    public partial class Login_MüşteriTemsilcisi : Form
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
        public Login_MüşteriTemsilcisi()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * From Login_Müsteriler(:_tc,:_sifre)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_tc", MskdTxBox_Tc.Text);
                cmd.Parameters.AddWithValue("_sifre", TxtBox_sifre.Text);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                conn.Close();

                if (reader.Read())
                {
                    Hesap_MüşteriHesabı hesap_Müşteri = new Hesap_MüşteriHesabı();
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
                MessageBox.Show("ERROR: " + ex.Message);
                conn.Close();
            }
        }
    }
}
