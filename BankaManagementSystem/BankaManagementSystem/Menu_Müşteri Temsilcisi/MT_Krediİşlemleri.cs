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
    public partial class MT_Krediİşlemleri : Form
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
        private DataTable dt;
        public MT_Krediİşlemleri()
        {
            InitializeComponent();
        }

        private void MT_Krediİşlemleri_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            İlgiliMüşterilerKredi_Select();
        }

        private void İlgiliMüşterilerKredi_Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM kredi_talep K
                        WHERE K.uye_id=" + Mus_Tc;

                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_KrediTalep.DataSource = null;//reset
                Dgv_KrediTalep.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR : " + ex.Message);
            }


        }

        private void btn_Onay_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                sql = @"Select * from update_krediTalep(:_onay,:_tc)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_onay", 1);
                cmd.Parameters.AddWithValue("_tc", Mus_Tc);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Talep Onayı başarılı");
                    conn.Close();
                    İlgiliMüşterilerKredi_Select();
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
    }
}
