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
    public partial class SistemGüncelleme : Form
    {
        public long tc;
        //----PostgreSql ile ilgili kısımlar

        // PostgreSql veritabanına bağlantı oluşturmak için değişkenler
        private string connstring = String.Format("Server={0};Port={1};" +
                                                  "User Id={2};Password={3};Database={4};",
                                                  "localhost", 5432, "postgres", "7163", "bankManagement");
        private NpgsqlConnection conn;

        // sql sorguları ve komutları oluşturmak için değişkenler
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        public SistemGüncelleme()
        {
            InitializeComponent();
        }

        private void SistemGüncelleme_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Sistem_Select();
            Banka_Select();
        }

        private void Sistem_Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM sistem ";

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_Sistem.DataSource = null;//reset
                Dgv_Sistem.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR : " + ex.Message);
            }
        }
        private void Banka_Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM banka_uyeleri ";

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgv_bankaUyeleri.DataSource = null;//reset
                dgv_bankaUyeleri.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR : " + ex.Message);
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from update_banka_uyeleri(:_id,:_maas)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", txtBox_ID.Text);
                cmd.Parameters.AddWithValue("_maas", TxtBox_Maas.Text);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Güncelleme başarılı.");

                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Güncelleme Başarısız. Error: " + ex.Message);
            }
        }
        private void insert_sis()
        {

        }
    }
}
