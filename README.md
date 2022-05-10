# BankManagementSystem
 C# Form application with PostgreSQL

# Renk Paleti
 

 

# PostgreSql veritabanını C# formda kullanma

 ## Baglantı oluşturup açma

 ```C#
    private string connstring =String.Format("Server={0};Port={1};"+ "User Id={2};Password={3};Database={4};","localhost",5432,"postgres","7163","db_bankManagementSystem");

    private NpgsqlConnection conn;

    conn = new NpgsqlConnection(connstring);

    conn.Open();
 ```
 
 # Not!

 1-form load fonksiyonu açıldığında bağlantı kur.


 ## Komut oluşturma

  ```C#
    private string sql;
    private NpgsqlCommand cmd;

    //örnek
    sql=@"select * from müşteriler()";
    cmd= new NpgsqlCommand(sql,conn);
  ```
 # Not! 
 
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
 # Not!
  
  1- bu fonksiyonları try catch e adapte et

 ## DataGrivView den veri seçme 
 
 ```C#
    //örnek textbox ismi txtFirstname
    txtFirstname.Text = dgvData.Rows[e.RowIndex].Cells["firstname"].Value.toString();
    txtSurname.Text=dgvData.Rows[e.RowIndex].Cells["surname"].Value.ToString();
 ```
 # Not
 
 1 - dgvData_CellClick fonksiyonu içerisinde 

 ## Insert Fonksiyonu
 
 ```C#

 ```


### Kaynakça

1- https://www.youtube.com/watch?v=U_v1dSglNjE


