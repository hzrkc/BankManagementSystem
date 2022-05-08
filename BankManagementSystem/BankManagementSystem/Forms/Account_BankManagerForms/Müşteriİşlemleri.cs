using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankManagementSystem.Forms.Account_BankManagerForms
{
    public partial class Müşteriİşlemleri : Form
    {
        //Fields
        SqlBaglantısı blg = new SqlBaglantısı();
        public Müşteriİşlemleri()
        {
            InitializeComponent();
        }

        private void btn_MüşteriKayıt_Click(object sender, EventArgs e)
        {
            /*
            string sorgu = "insert into Cus_List (isim,soy_isim,adres,email,telefon,tc,temsilci_id) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
            NpgsqlDataAdapter kayıtKomut = new NpgsqlDataAdapter(sorgu, blg);

            kayıtKomut.Parameters.AddWithValue("@p1", TxtAd.Text);
            kayıtKomut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kayıtKomut.Parameters.AddWithValue("@p3", TxtAdres.Text);
            kayıtKomut.Parameters.AddWithValue("@p4", TxtEmail.Text);
            kayıtKomut.Parameters.AddWithValue("@p5", TxtTelefon.Text);
            kayıtKomut.Parameters.AddWithValue("@p6", TxtTc.Text);
            kayıtKomut.Parameters.AddWithValue("@p7", "22222222");
            kayıtKomut.ExecuteNonQuery();

            blg.Veritabani().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir");*/
        }
    }
}
