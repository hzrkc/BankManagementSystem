# BankManagementSystem
 C# Form application with PostgreSQL

# Renk Paleti
![#d2afff Color Hex](https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/img_Color/%23d2afff%20Color%20Hex.png)

 Koyu -> #3f344c (label ve buton forecolor)

 #a88ccc (MouseOverBackColor)

 Orta -> #d2afff (Arka Plan rengi)

 #dbbfff

 #e8d7ff

 Açık -> #f6efff 

 ### Button ayarları

 Cursor -> Hand
 BorderSize -> 0  
 

 

# PostgreSql veritabanını C# formda kullanma

 ## Baglantı oluşturup açma

 ```C#
    private string connstring =String.Format("Server={0};Port={1};"+ "User Id={2};Password={3};Database={4};","localhost",5432,"postgres","7163","db_bankManagementSystem");

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

 ## Insert Fonksiyonu
 
 ```C#
   rowIndex=-1;
   txtFirstname.Text=txtSurname.Text= null;


 ```

 ## Upddate
 ```C#
   if(rowIndex < 0)
   {
      MessageBox.Show("Güncellenecek müşteriyi seçiniz");
   }
 ```

 ## Delete
 ```C#
   if(rowIndex < 0)
   {
      MessageBox.Show("Silme işlemi yapılacak müşteriyi seçiniz");
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
   }



 ```

  ### Not
 
 1 - try catch fonksiyonları oluştur


### Kaynakça

1- https://www.youtube.com/watch?v=U_v1dSglNjE


