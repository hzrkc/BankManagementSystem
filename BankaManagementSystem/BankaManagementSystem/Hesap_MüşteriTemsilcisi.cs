﻿using System;
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
    public partial class Hesap_MüşteriTemsilcisi : Form
    {
        public int MusTemsilcisi_tc;//kullanıcı bilgilerini formlar arası aktarmak için
        public int Mus_tc;
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
        public Hesap_MüşteriTemsilcisi()
        {
            InitializeComponent();
            btn_CloseChildForm.Visible = false;
            btn_MüşteriKayıt.Enabled = false;
            btn_MüşteriSil.Enabled = false;
            btn_Guncelle.Enabled = false;
            txtBox_Ad.Enabled = false;
            txtBox_Soyad.Enabled = false;
            txtBox_Adres.Enabled = false;
            txtBox_Email.Enabled = false;
            txtBox_Sifre.Enabled = false;
            txtBox_Telefon.Enabled = false;

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
                    pnl_Back.BackColor = backColor;
                    pnl_Back2.BackColor = backColor;
                    pnl_Top.BackColor = backColor;
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
                    pnl_Back.BackColor = Color.FromArgb(246, 239, 255);
                    pnl_Back2.BackColor = Color.FromArgb(246, 239, 255);
                    pnl_Top.BackColor = Color.FromArgb(246, 239, 255);
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
            this.pnl_ChildForm.Controls.Add(childForm);
            this.pnl_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_MüşteriKayıt_Click(object sender, EventArgs e)
        {
            İlgiliMüşteriler_Select();
        }

        private void btn_YeniHesap_Click(object sender, EventArgs e)
        {

        }

        private void btn_HesapSil_Click(object sender, EventArgs e)
        {

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
        private void btn_Hesapİslemleri_Click(object sender, EventArgs e)
        {
            Menu_Müşteri_Temsilcisi.HesapOluşturma hesapOluşturma = new Menu_Müşteri_Temsilcisi.HesapOluşturma();
            hesapOluşturma.MusTemsilcisi_tc = MusTemsilcisi_tc;
            hesapOluşturma.Mus_Tc = Mus_tc;
            OpenChildForm(hesapOluşturma, sender);
        }

        private void btn_Krediİslemleri_Click(object sender, EventArgs e)
        {
            Menu_Müşteri_Temsilcisi.MT_Krediİşlemleri krediİşlemleri = new Menu_Müşteri_Temsilcisi.MT_Krediİşlemleri();
            krediİşlemleri.MusTemsilcisi_tc = MusTemsilcisi_tc;
            krediİşlemleri.Mus_Tc = Mus_tc;
            OpenChildForm(krediİşlemleri, sender);
        }

        private void btn_MinWindow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            this.WindowState |= FormWindowState.Minimized;
        }

        private void btn_WindowClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hesap_MüşteriTemsilcisi_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            lbl_Tc.Text = Convert.ToString(MusTemsilcisi_tc);
            İlgiliMüşteriler_Select();
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * From Sorgula_Müşteri(:_tc)";
                cmd = new NpgsqlCommand(sql, conn);
                Mus_tc = int.Parse(MskdTxBox_Tc.Text);
                cmd.Parameters.AddWithValue("_tc", Mus_tc);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();

                if (result == 1)//Müşteri Kayıtlı ise
                {
                    try
                    {   
                        conn.Open();
                        sql = @"SELECT * From musteriler M
                                WHERE M.tc=" + Mus_tc + " and M.temsilci_id =" + MusTemsilcisi_tc;
                        cmd = new NpgsqlCommand(sql, conn);
                        NpgsqlDataReader npgsqlData = cmd.ExecuteReader();

                        if(npgsqlData.Read() != null) //İlgili müşteri temsilcisi doğru ise
                        {
                            btn_MüşteriSil.Enabled = true;
                            btn_Guncelle.Enabled = true;
                            txtBox_Ad.Enabled = true;
                            txtBox_Soyad.Enabled = true;
                            txtBox_Adres.Enabled = true;
                            txtBox_Email.Enabled = true;
                            txtBox_Sifre.Enabled = true;
                            txtBox_Telefon.Enabled = true;
                        }
                        else //başka müşteri temsilcisi ilgileniyorsa
                        {
                            MessageBox.Show("müşterinin ilgili müşteri temsilcisi farklı");
                        }
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                        conn.Close();
                    }
                        
                }
                else //Müşteri Kayıtlı Değil ise
                {   
                    MessageBox.Show("Müşteri Kayıtlı Değil.");
                    
                    txtBox_Ad.Enabled = true;
                    txtBox_Soyad.Enabled = true;
                    txtBox_Adres.Enabled = true;
                    txtBox_Email.Enabled = true;
                    txtBox_Sifre.Enabled = true;
                    txtBox_Telefon.Enabled = true;
                    btn_MüşteriKayıt.Enabled = true;
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                conn.Close();
            }
        }

        private void İlgiliMüşteriler_Select() 
        {
            try
            {
                conn.Open();
                sql = @"SELECT M.id,M.isim, M.soyisim, M.email,M.adres,M.telefon FROM musteriler M
                        JOIN calisanlar C on C.id=M.temsilci_id
                        WHERE C.tc=" + MusTemsilcisi_tc ;
                        
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                Dgv_İlgilenilenMüşteriListesi.DataSource = null;//reset
                Dgv_İlgilenilenMüşteriListesi.DataSource = dt;

            }
            catch (Exception ex)
            {   
                conn.Close();   
                MessageBox.Show("ERROR : "+ex.Message);    
            }
            

        }
    }
}
