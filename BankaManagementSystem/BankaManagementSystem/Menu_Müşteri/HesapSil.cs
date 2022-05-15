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
    public partial class HesapSil : Form
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
        public HesapSil()
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

        private void btn_TalepOluştur_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"Select * from update_durumhesap(:_id,:_tc,:_durum)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_durum", 0);
                cmd.Parameters.AddWithValue("_tc", tc);
                cmd.Parameters.AddWithValue("_id", int.Parse(TxtBox_HesapId.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
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

        private void HesapSil_Load(object sender, EventArgs e)
        {
            lbl_Tc.Text = Convert.ToString(tc);
            HesapBilgileri_Select();

        }
        private void HesapBilgileri_Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT T.tur, H.bakiye From hesaplar H 
                      JOIN musteriler M ON H.uye_id = M.tc" +
                      "JOIN hesap_tur T ON H.hesap_tur_id=T.id " +
                      "WHERE H.onay=1 and M.tc=" + tc;
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable(); ;
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_HesapBilgileri.DataSource = null; //reset datagrid view
                Dgv_HesapBilgileri.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
