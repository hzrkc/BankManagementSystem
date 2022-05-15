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

namespace BankaManagementSystem
{
    public partial class Hesap_MüşteriHesabı : Form
    {
        public int tc;//kullanıcı bilgilerini formlar arası aktarmak için
        private Button currentButton;//aktif butonu tutmak için
        private Form activeForm;//form içerisine çağırılan formu tutmak için


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
        public Hesap_MüşteriHesabı()
        {
            InitializeComponent();
            btn_CloseChildForm.Visible = false;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color backColor = ColorTranslator.FromHtml("#e8d7ff");
                    Color foreColor = ColorTranslator.FromHtml("#BD9DE5");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = backColor;
                    currentButton.ForeColor = foreColor;
                    pnl_anaPanel.BackColor = backColor;
                    btn_CloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnl_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(246, 239, 255);
                    previousBtn.ForeColor = Color.FromArgb(63, 52, 76);
                    pnl_anaPanel.BackColor = Color.FromArgb(246, 239, 255);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_childFrom.Controls.Add(childForm);
            this.pnl_childFrom.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_WindowClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MinWindow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            this.WindowState |= FormWindowState.Minimized;
        }

        private void btn_TransferVeÖdeme_Click(object sender, EventArgs e)
        {
            Menu_Müşteri.TransferVeÖdemeler transfer=new Menu_Müşteri.TransferVeÖdemeler();
            transfer.tc = tc;
            OpenChildForm(transfer, sender);

        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            Menu_Müşteri.Ayarlar ayarlar = new Menu_Müşteri.Ayarlar();
            ayarlar.tc = tc;
            OpenChildForm(ayarlar, sender);
        }
         
        private void btn_YeniHesap_Click(object sender, EventArgs e)
        {
            Menu_Müşteri.hesapOluşturma hesapOluşturma = new Menu_Müşteri.hesapOluşturma();
            hesapOluşturma.tc = tc;
            this.Hide();
            hesapOluşturma.Show();
        }

        private void btn_HesapSil_Click(object sender, EventArgs e)
        {
            Menu_Müşteri.HesapSil hesapsil = new Menu_Müşteri.HesapSil();
            hesapsil.tc = tc;
            this.Hide();
            hesapsil.Show();
        }

        private void btn_Krediİşlemleri_Click(object sender, EventArgs e)
        {
            Menu_Müşteri.Mus_Krediİşlemleri kredi = new Menu_Müşteri.Mus_Krediİşlemleri();
            kredi.tc = tc;
            kredi.Show();
            this.Hide();
        }
        private void btn_CloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            currentButton = null;
            btn_CloseChildForm.Visible = false;
        }

        private void MüşteriHesabı_Load(object sender, EventArgs e)
        {
            conn= new NpgsqlConnection(connstring);
            lbl_Tc.Text = Convert.ToString(tc);
            HesapBilgileri_Select();
            AylıkHesap_Select();
        }

        private void HesapBilgileri_Select()
        {
            try
            {
                conn.Open();
                sql= @"SELECT T.tur, H.bakiye From hesaplar H 
                      JOIN musteriler M ON H.uye_id = M.tc" +
                      "JOIN hesap_tur T ON H.hesap_tur_id=T.id " +
                      "WHERE H.onay=1 and M.tc=" + tc;
                cmd= new NpgsqlCommand(sql, conn);
                dt= new DataTable(); ;
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_HesapBilgileri.DataSource = null; //reset datagrid view
                Dgv_HesapBilgileri.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: "+ex.Message);

            }
        }

        private void AylıkHesap_Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * From islem" +
                      "WHERE kaynak_tc.tc=" + tc +
                      "or hedef_tc=" + tc;
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable(); ;
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_AylikOzet.DataSource = null; //reset datagrid view
                Dgv_AylikOzet.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
