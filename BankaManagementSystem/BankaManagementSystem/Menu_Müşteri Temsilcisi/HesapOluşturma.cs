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

namespace BankaManagementSystem.Menu_Müşteri_Temsilcisi
{
    public partial class HesapOluşturma : Form
    {
        public int MusTemsilcisi_tc;
        public int Mus_Tc;

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
        public HesapOluşturma()
        {
            InitializeComponent();
        }

        private void HesapOluşturma_Load(object sender, EventArgs e)
        {    
            conn = new NpgsqlConnection(connstring);
            Select_HesapTalep();
            Select_HesapSil();

        }

        
        private void Select_HesapTalep()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM hesaplar
                        WHERE hesaplar.onay=0 and hesaplar.uye_id=" + Mus_Tc;

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_HesapTalep.DataSource = null;//reset
                Dgv_HesapTalep.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR : " + ex.Message);
            }

        }


        private void btn_Onay_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"Select * from update_onayhesap(:_tc,:_onay)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_onay", 1);
                cmd.Parameters.AddWithValue("_tc", Mus_Tc);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    Select_HesapTalep();
                    MessageBox.Show("Talep Onayı başarılı");
                    krediHesabıOluştur();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Talep Onayı başarısız");
                }


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR : " + ex.Message);
            }
        }

        private void btn_SilmeOnay_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"Select * from delete_hesaplar(:_id)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id",int.Parse(txt_hesapId.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    Select_HesapSil();
                    MessageBox.Show("Talep Onayı başarılı");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Talep Onayı başarısız");
                }


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR : " + ex.Message);
            }
        }
        private void krediHesabıOluştur()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * from insert_hesaplar(:_uye_id,:_hesap_tur_id,:_yatirim_fon_id,:_bakiye,:_hesap_isim)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_uye_id", Mus_Tc);
                cmd.Parameters.AddWithValue("_hesap_tur_id", 1 );
                cmd.Parameters.AddWithValue("_hesap_isim", "kredi hesabı");
                cmd.Parameters.AddWithValue("_uye_id", Mus_Tc);
                cmd.Parameters.AddWithValue("_bakiye", 0);
                cmd.Parameters.AddWithValue("_onay", 1);
                int result = (int)cmd.ExecuteScalar();

                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Kredi Hesabı Oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Kredi Hesabı Oluşturulamadı.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Kredi Hesabı Oluşturma Başarısız. Error: " + ex.Message);
            }
        }

        private void Select_HesapSil()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM hesaplar
                        WHERE hesaplar.durum=0 and hesaplar.uye_id=" + Mus_Tc;

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_HesapTalep.DataSource = null;//reset
                Dgv_HesapTalep.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR : " + ex.Message);
            }
        }
    }
}
