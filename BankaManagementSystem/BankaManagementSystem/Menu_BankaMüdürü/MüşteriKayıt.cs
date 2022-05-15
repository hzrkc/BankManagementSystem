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

namespace BankaManagementSystem.Menu_BankaMüdürü
{
    public partial class MüşteriKayıt : Form
    {
        public int tc;
        //----PostgreSql ile ilgili kısımlar

        // PostgreSql veritabanına bağlantı oluşturmak için değişkenler
        private string connstring = String.Format("Server={0};Port={1};" +
                                                  "User Id={2};Password={3};Database={4};",
                                                  "localhost", 5432, "postgres", "7163", "bankManagement");
        private NpgsqlConnection conn;

        // sql sorguları ve komutları oluşturmak için değişkenler
        private string sql;
        private NpgsqlCommand cmd;
        public MüşteriKayıt()
        {
            InitializeComponent();
        }

        private void MüşteriKayıt_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new NpgsqlCommand("SELECT temsilci_id FROM musteriler GROUP BY temsilci_id ORDER BY count(temsilci_id) ASC LIMIT 1; ");
            int temsilci_id = (int)cmd.ExecuteScalar();
            conn= new NpgsqlConnection(connstring);
            conn.Close();

            try
            {
                conn.Open();
                sql = @"SELECT * from insert_musteriler(:_isim,:_soyisim ,:_adres,:_email,:_telefon ,:_tc ,:_temsilci_id,:_sifre )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_isim", txtBox_Ad.Text);
                cmd.Parameters.AddWithValue("_soyisim", txtBox_Soyad.Text);
                cmd.Parameters.AddWithValue("_adres", txtBox_Adres.Text);
                cmd.Parameters.AddWithValue("_email", txtBox_Email.Text);
                cmd.Parameters.AddWithValue("_telefon", int.Parse(txtBox_Telefon.Text));
                cmd.Parameters.AddWithValue("_tc", int.Parse(MskdTxBox_Tc.Text));
                cmd.Parameters.AddWithValue("_sifre", txtBox_Sifre.Text);
                cmd.Parameters.AddWithValue("_temsilci_id", temsilci_id);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Kayıt başarılı.");
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Kayıt Başarısız. Error: " + ex.Message);
            }
        }
    }
}
