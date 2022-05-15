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
    public partial class Mus_Krediİşlemleri : Form
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
        public Mus_Krediİşlemleri()
        {
            InitializeComponent();
        }

        private void Mus_Krediİşlemleri_Load(object sender, EventArgs e)
        {
            lbl_Tc.Text = Convert.ToString(tc);
            conn.Open();
            sql = @"select * from yatirim_fonu";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            CmBox_KrediTür.DisplayMember = "para_turu";
            CmBox_KrediTür.ValueMember = "id";
            CmBox_KrediTür.DataSource = dt;

            conn.Close();
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

        private void btn_Talep_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from insert_krediTalep(:kredi_tur_id)"; //Düzenle
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("kredi_tur_id", CmBox_KrediTür.ValueMember);
                cmd.Parameters.AddWithValue("talep_miktar", int.Parse(txtBox_Miktar.Text));

                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Talep başarılı.");
                }
                else
                {
                    MessageBox.Show("Talep başarısız.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Talep Başarısız. Error: " + ex.Message);
            }
        }
    }
}
