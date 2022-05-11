# BankManagementSystem
 C# Form application with PostgreSQL

# Kullanıcı bilgilerini diğer formlara taşıma
Her formun private tc kısmı oluşturulur.
Form nesnesi sayesinde değişkenler arası aktarım sağlanır.

# PostgreSql veritabanını C# formda kullanma
Kütüphane ekle
 ```C#
   using Npgsql;
 ```
 Karşılaştığımız versiyon hatası

 
![VersionHatası_HataEkranı](https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/notlar/VersionHatas%C4%B1_HataEkran%C4%B1.png)


çözüm: https://stackoverflow.com/questions/63019110/could-not-load-file-or-assembly-system-buffers-version-4-0-2-0


![VersionHatası](https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/notlar/VersionHatas%C4%B1.png)


son durum 


![VersionHatası_Duzeltme](https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/notlar/VersionHatas%C4%B1_D%C3%BCzeltme.png)


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

 ## DataGrivView den veri seçme 
 
 ```C#
   private int rowIndex =-1; 
    //örnek textbox ismi txtFirstname
    if(e.RowIndex>=0)
    {
       row=e.RowIndex;
      txtFirstname.Text = dgvData.Rows[e.RowIndex].Cells["firstname"].Value.toString();
      txtSurname.Text=dgvData.Rows[e.RowIndex].Cells["surname"].Value.ToString();
    }
    
 ```
 ### Not
 
 1 - dgvData_CellClick fonksiyonu içerisinde 

 ## Insert and Update Fonksiyonu
 
 ```C#
   int result=0;
   if(rowIndex<0) //insert
   {
      try
      {
         conn.Open();
         sql = @"selecet * from st_insert(: _firstname, :_surname)";
         cmd= new NpsqlCommand(sql,conn);
         cmd.Parameters.AddWithValue("_firstname",txtFirstname.Text);
         cmd.Parameters.AddWithValue("_surname",txtFirstname.Text);
         result = (int)cmd.ExecuteScaler();
         conn.Close();
         if(result == 1)
         {
            MessageBox.Show("Kayıt başarılı.");
         }
         else
         {
            MessageBox.Show("Kayıt başarısız.");
         }
      }
      catch(Exception ex)
      {
         conn.Close();
         MessageBox.Show("Kayıt Başarısız. Error: "+ ex.Message);
      }
   }
   else //update
   {
      try
      {
         conn.Open();
         sql = @"select * from st_update(:_id, :_firstname)";
         cmd= new NpsqlCommand(sql, conn);
         cmd.Parameters.AddwithValue("_id", int.Parse(dgvData.Rows[rowIndex].Cells["id"].Value.ToString));
         cmd.Parameters.AddWithValue("_firstname",txtFirstname.Text);
         result = (int)cmd.ExecuteScaler();
         conn.Close();
         if(result == 1)
         {
            MessageBox.Show("Güncelleme başarılı.");
         }
         else
         {
            MessageBox.Show("Güncelleme başarısız.");
         }
      }
      catch(Exception ex)
      {
         conn.Close();
         MessageBox.Show("Güncelleme Başarısız. Error: "+ ex.Message);
      }
   }
   result =0;
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
      if((int)cmd.ExecuteScaler() == 1)
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
 ## Window kapama
 ```C#
   Application.Exit();
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


# Renk Paleti
![#d2afff Color Hex](https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/img_Color/%23d2afff%20Color%20Hex.png)

 Koyu
 63, 52, 76


 210, 175, 255
 246, 239, 255 (mouseOver, active)
 246, 239, 255 (menu-buton)
 Açık

 # PosgreSql fonksiyonlar oluşturma

Kullanılmak zorunda değil.

## Select fonksiyonları

1 - Musteriler tablosu için
```sql
DROP FUNCTION select_musteriler();
Create or replace function select_musteriler()

returns table
(
  _id int,
  _isim character varying,
  _soyisim character varying,
  _adres character varying,
  _email character varying,
  _telefon integer,
  _tc integer,
  _temsilci_id integer
)as
$$
begin
	return query
	select _id,_isim,_soyisim,_adres,_email,_telefon,_tc,_temsilci_id from musteriler order by _id;
end
$$
language plpgsql;

--test
SELECT * from select_musteriler();
```

### Kaynakça

1- https://www.youtube.com/watch?v=U_v1dSglNjE


