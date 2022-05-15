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

namespace BankaManagementSystem.Menu_Müşteri
{
    public partial class hesapOluşturma : Form
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
        DataTable dt;
        public hesapOluşturma()
        {
            InitializeComponent();
        }

        private void btn_WindowClose_Click(object sender, EventArgs e)
        {
            Hesap_MüşteriHesabı hesap = new Hesap_MüşteriHesabı();
            hesap.tc = tc;
            hesap.Show();
            this.Hide();
        }

        private void btn_MinWindow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            this.WindowState |= FormWindowState.Minimized;

        }

        private void hesapOluşturma_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            lbl_Tc.Text =Convert.ToString(tc);
            
            conn.Open();
            sql = @"select * from yatirim_fonu";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            CmBox_YatırımFonuTürü.DisplayMember = "para_turu";
            CmBox_YatırımFonuTürü.ValueMember = "id";
            CmBox_YatırımFonuTürü.DataSource = dt;

            sql = @"select * from hesap_tur";
            adapter = new NpgsqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            CmBox_HesapTür.DisplayMember = "tur";
            CmBox_HesapTür.ValueMember = "id";
            CmBox_HesapTür.DataSource = dt;
            conn.Close();
        }

        private void btn_TalepOluştur_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from insert_hesaplar(:_uye_id,:_hesap_tur_id,:_yatirim_fon_id,:_bakiye,:_hesap_isim)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_yatirim_fon_id", CmBox_YatırımFonuTürü.ValueMember);
                cmd.Parameters.AddWithValue("_hesap_tur_id", CmBox_HesapTür.ValueMember);
                cmd.Parameters.AddWithValue("_hesap_isim", TxtBox_Hesapİsmi.Text);
                cmd.Parameters.AddWithValue("_uye_id", tc);
                cmd.Parameters.AddWithValue("_bakiye", 0);
                cmd.Parameters.AddWithValue("_onay", 0);
                int result = (int)cmd.ExecuteScalar();

                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Hesap Talebi  Oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Hesap Talebi Oluşturulamadı.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Hesap Talebi Başarısız. Error: " + ex.Message);
            }
        }
    }
}
