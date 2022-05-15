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
    public partial class YatırımFonuDüzenleme : Form
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
        public YatırımFonuDüzenleme()
        {
            InitializeComponent();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from update_yatirimfonu(:_id,:_kur)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", txtBox_ID.Text);
                cmd.Parameters.AddWithValue("_kur", double.Parse(txtBox_Kur.Text));
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

        private void btn_Kayıt_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from insert_yatirim_fonu(:_para_turu,:_kur )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_para_turu", TxtBox_ParaBirimi.Text);
                cmd.Parameters.AddWithValue("_kur", double.Parse(txtBox_Kur.Text));
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

        private void YatırımFonuDüzenleme_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
