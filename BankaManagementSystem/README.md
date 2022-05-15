# C# Form Application with PostgreSql
 Kullanılan bazı fonksiyonlar ve işlevleri

   ## Kullanıcı bilgilerini diğer formlara taşıma
   Her formun private tc kısmı oluşturulur.
   Form nesnesindeki constructor methodları sayesinde değişkenler arası aktarım sağlanır.

   # PostgreSql veritabanını C# formda kullanma

   __*Manage NuGet packeges -> Npgsql -> install*__


   __Kütüphane ekle:__    `using Npgsql;` 

   ### Karşılaştığımız versiyon hatası çözümü
   https://stackoverflow.com/questions/63019110/could-not-load-file-or-assembly-system-buffers-version-4-0-2-0
   <p align="left"><img src="https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/notlar/VersionHatas%C4%B1.png" width="500" heigh="500"></p>
   <p align="left"><img src="https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/notlar/VersionHatas%C4%B1_D%C3%BCzeltme.png" width="600"></p>

   ## Baglantı oluşturup açma

   ```C#
      private string connstring =String.Format("Server={0};Port={1};"+ "User Id={2};Password={3};Database={4};","localhost",5432,"postgres","17052016","bankManagementSystem");

      private NpgsqlConnection conn;

      conn = new NpgsqlConnection(connstring);

      conn.Open();
   ```
   
   ### Not!

   1-form load fonksiyonu açıldığında bağlantı kur.


   ## Komut oluşturma

   ```C#
      private string sql;
      private NpgsqlCommand cmd;
      private DataTable dt;

      //örnek
      sql=@"select * from müşteriler()";
      cmd= new NpgsqlCommand(sql,conn);
   ```
   ### Not! 
   
   1- form load kısmına ekle. Boş tablo açılmasın.
   
   



   ## DataGridView Veri Aktarımı

   ```C#
      private DataTable dt;

      dt= new DataTable();
      dt.Load(cmd.ExecuteReader());
      conn.Close();
      //DataGridView ismi dgvData
      dgvData.DataSourse=null; //reset
      dgvData.DataSource=dt;

   ```
   ### Not!
   
   1- bu fonksiyonları try catch e adapte et
 

   ## Select() fonksiyonu

   1 - İlgilenilen Müşteriler tablosu

   ```C#
   private void İlgiliMüşteriler_Select() 
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM musteriler M
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
   ```
   
   ## Insert
   
   ```C#
      try
            {
                conn.Open();
                sql = @"SELECT * from insert_musteriler(:_uye_id,:_hesap_tur_id,:_yatirim_fon_id,:_bakiye,:_hesap_isim)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_yatirim_fon_id", CmBox_YatırımFonuTürü.ValueMember);
                cmd.Parameters.AddWithValue("_yatirim_fon_id", CmBox_HesapTür.ValueMember);
                cmd.Parameters.AddWithValue("_hesap_isim", TxtBox_Hesapİsmi.Text);
                cmd.Parameters.AddWithValue("_uye_id", Mus_Tc);
                cmd.Parameters.AddWithValue("_bakiye",0);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Hesap Oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Hesap Oluşturulamadı.");
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Hesap Oluşturma Başarısız. Error: " + ex.Message);
            }
   ```
   
   ## Update
   
   ```C#
   try
            {
                conn.Open();
                sql = @"SELECT * from update_musteriler(:_isim,:_soyisim ,:_adres,:_email,:_telefon ,:_tc ,:_sifre )";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_isim", txtBox_Ad.Text);
                cmd.Parameters.AddWithValue("_soyisim", txtBox_Soyad.Text);
                cmd.Parameters.AddWithValue("_adres", txtBox_Adres.Text);
                cmd.Parameters.AddWithValue("_email", txtBox_Email.Text);
                cmd.Parameters.AddWithValue("_telefon", int.Parse(txtBox_Telefon.Text));
                cmd.Parameters.AddWithValue("_tc", int.Parse(MskdTxBox_Tc.Text));
                cmd.Parameters.AddWithValue("_sifre", txtBox_Sifre.Text);
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
   ```

   ## Delete
   ```C#
      if(rowIndex < 0)
      {
         MessageBox.Show("Silme işlemi yapılacak müşteriyi seçiniz");
         return;
      }
      try
      {
         conn.Open();
         sql=@"select * from müşteriler";
         cmd= new NpsqlCommand(sql, conn);
         cmd.Parameters.AddwithValue("_id", int.Parse(dgvData.Rows[rowIndex].Cells["id"].Value.ToString));
         if((int)cmd.ExecuteScalar() == 1)
         {
            MessageBox.Show("Silme işlemi başarılı");
            rowIndex=-1;
         }
         conn.Close();
      }
      catch(Exception ex)
      {
         conn.Close();
         MessageBox.Show("Silme başarısız. ERROR: "+ ex.Message);
      }
   ```
   ## Login fonksiyonu kullanımı
   ```C#
   try
   {
      conn.Open();
      sql = @"SELECT * From Login_BankaCalışanları(:_tc,:_sifre,:_kullanıcıKodu)";
      cmd = new NpgsqlCommand(sql, conn);
      cmd.Parameters.AddWithValue("_tc", int.Parse(MskdTxBox_Tc.Text));
      cmd.Parameters.AddWithValue("_sifre", TxtBox_sifre.Text);
      cmd.Parameters.AddWithValue("_kullanıcıKodu", 2);
      int result = (int)cmd.ExecuteScalar();
      conn.Close();

      if (result == 1)
      {
         
         Hesap_BankaMüdürü hesap_BankaMüdürü = new Hesap_BankaMüdürü();
         hesap_BankaMüdürü.tc = int.Parse(MskdTxBox_Tc.Text);
         hesap_BankaMüdürü.Show();
         this.Hide();

      }
      else
      {
         MessageBox.Show("Giriş başarısız.");
         return;
      }
      
   }
   catch (Exception ex)
   {
      MessageBox.Show("ERROR: " + ex.Message);
      conn.Close();
   }
   ```

   # Buton Fonksiyonları 
   ## Butona basılında görüntü değiştime, buton aktif değilken normale döndürme
   ```C#
     private Button currentButton;
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
                        BackColorpanel.BackColor = backColor;
                        btn_AnaSayfa.Visible = true;
                     }
                  }
            }
         private void DisableButton()
            {
                  foreach (Control previousBtn in panelMenu.Controls)
                  {
                     if (previousBtn.GetType() == typeof(Button))
                     {
                        previousBtn.BackColor = Color.FromArgb(210, 175, 255);
                        previousBtn.ForeColor = Color.FromArgb(63, 52, 76);
                        BackColorpanel.BackColor = Color.FromArgb(210, 175, 255);
                     }
                  }
            }
  ```
   ## Minimize etme
   ```C#
    if (WindowState == FormWindowState.Maximized)   
      this.WindowState = FormWindowState.Normal;
     this.WindowState |= FormWindowState.Minimized;
   ```
      
      

   # Form fonksiyonları
   ## Formun içine form çağırma
   ```C#
      private Form activeForm;
      
      private void OpenChildForm(Form childForm, object btnSender)
         {
               if(activeForm != null)
               {
                  activeForm.Close();
               }
               ActivateButton(btnSender);
               activeForm = childForm;
               childForm.TopLevel = false;
               childForm.FormBorderStyle = FormBorderStyle.None;
               childForm.Dock = DockStyle.Fill;
               this.panel_childform.Controls.Add(childForm);
               this.panel_childform.Tag = childForm;
               childForm.BringToFront();
               childForm.Show();
         }
   ```
   ## Formun içindeki formu kapama
   ```C#
      private void btn_KAPAT(object sender, EventArgs e)
         {
               if(activeForm !=null)
                  activeForm.Close();
               Reset();
         }
         private void Reset()
         {
               DisableButton();
               currentButton = null;
               btn_AnaSayfa.Visible = false;
         }
   ```
