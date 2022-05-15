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
    public partial class BM_Krediİşlemleri : Form
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
        private DataTable dt;
        public BM_Krediİşlemleri()
        {
            InitializeComponent();
        }


        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from update_kredi_tur(:_id,:_vade,:_faiz )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", txtBox_ID.Text);
                cmd.Parameters.AddWithValue("_vade", TxtBox_Vade.Text);
                cmd.Parameters.AddWithValue("_faiz", txtBox_Faiz.Text);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Güncelleme başarılı.");
                    Select_KrediTur();

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


        private void BM_Krediİşlemleri_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            Select_KrediTur();
        }

        private void Select_KrediTur()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * From kredi_tur";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable(); ;
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_YatırımFonu.DataSource = null; //reset datagrid view
                Dgv_YatırımFonu.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
