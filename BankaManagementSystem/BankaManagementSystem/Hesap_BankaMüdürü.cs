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
    public partial class Hesap_BankaMüdürü : Form
    {
        public long tc;//kullanıcı bilgilerini formlar arası aktarmak için
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
        public Hesap_BankaMüdürü()
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

        private void btn_SistemGüncelleme_Click(object sender, EventArgs e)
        {
            Menu_BankaMüdürü.SistemGüncelleme sistemGüncelleme = new Menu_BankaMüdürü.SistemGüncelleme();
            sistemGüncelleme.tc = tc;
            OpenChildForm(sistemGüncelleme, sender);
        }

        private void btn_MüsteriKayıt_Click(object sender, EventArgs e)
        {
            Menu_BankaMüdürü.MüşteriKayıt müşteriKayıt = new Menu_BankaMüdürü.MüşteriKayıt();
            müşteriKayıt.tc = tc;
            OpenChildForm(müşteriKayıt, sender);
        }

        private void btn_KrediIslemleri_Click(object sender, EventArgs e)
        {
            Menu_BankaMüdürü.BM_Krediİşlemleri krediİşlemleri = new Menu_BankaMüdürü.BM_Krediİşlemleri();
            krediİşlemleri.tc = tc;
            OpenChildForm(krediİşlemleri, sender);
        }

        private void btn_YatırımFonuDüzenleme_Click(object sender, EventArgs e)
        {
            Menu_BankaMüdürü.YatırımFonuDüzenleme yatırımFonuDüzenleme = new Menu_BankaMüdürü.YatırımFonuDüzenleme();
            yatırımFonuDüzenleme.tc = tc;
            OpenChildForm(yatırımFonuDüzenleme, sender);
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

        private void BankaMüdürü_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            lbl_Tc.Text =Convert.ToString(tc);
            Select();
        }

        private void Select()
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM islem";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable(); ;
                dt.Load(cmd.ExecuteReader());
                Dgv_BankaIslemleri.DataSource = null; //reset datagrid view
                Dgv_BankaIslemleri.DataSource = dt;

                sql = @"SELECT * FROM banka_uyeleri";
                cmd = new NpgsqlCommand(sql, conn);
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_BankaGenelDurum.DataSource = null; //reset datagrid view
                Dgv_BankaGenelDurum.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void btn_İşlemleriGöster_Click(object sender, EventArgs e)
        {
            int son_işlemSayisi = int.Parse(TxtBox_SonİşlemSayisi.Text);
            try
            {
                conn.Open();
                sql = @"SELECT * FROM islem
                        Order by islem_no desc
                        LIMIT" + son_işlemSayisi;
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable(); ;
                dt.Load(cmd.ExecuteReader());
                Dgv_BankaIslemleri.DataSource = null; //reset datagrid view
                Dgv_BankaIslemleri.DataSource = dt;

                sql = @"SELECT * FROM banka_uyeleri";
                cmd = new NpgsqlCommand(sql, conn);
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_BankaGenelDurum.DataSource = null; //reset datagrid view
                Dgv_BankaGenelDurum.DataSource = dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
