# PostgreSQL_Database

  # Kullanılan Komutlar
   1 - __İlgilenilen Müşteriler Tablosu__
   ```sql


   ```
   2 - 

 # BACKUP oluşturma

  ## Export yapmak için:
   1 - Database üzerine gelinip backup seçilir.(Hata alıyorsanız NOT'lara bakınız)
   
   2 - İstenilen klasöre "istenilenisim.sql" şeklinde kaydedilir.

  ## Import yapmak için
   1 - import edilmek istenilen database'in üzerine gelinip Restore seçilir.

   2 - istenilen backup dosyası seçilir.

  ### NOT
   ! File-> Preferences -> Path -> Binary Path kısmına gelinir

   !! Database server türünün dosya seçmesine gelinir.

   Örnek (PostgreSQL 10 için) C:\Program Files\PostgreSQL\10\bin seçilir.

  # PosgreSql fonksiyonlar oluşturma
   __PostgreSql de oluşturulan fonksiyonlar nerede kaydoluyor?__

   <p align="left"><img src="https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/notlar/PostgreSql_Fonksiyonlar.png" width="300"></p>


   __*NOT:*__ Kullanılan fonksiyonlara, fonksiyonların parametre değişken tiplerine göre değer yollanmalıdır. C# form uygulamasında textbox'dan alınan bilgi string türünde olduğundan eğer fonksiyon integer gibi farklı değer tipi istiyorsa o değer tipine değiştirilmelidir.

   __*ÖRNEK:*__

   *Login_Müşteri(_tc integer, _sifre character varying)*  için 
   ```C#
      sql = @"SELECT * From Login_Müşteri(:_tc,:_sifre)";
      cmd = new NpgsqlCommand(sql, conn);
      cmd.Parameters.AddWithValue("_tc", int.Parse(TxtBox_Tc.Text);
      cmd.Parameters.AddWithValue("_sifre", TxtBox_sifre.Text);
      int result=(int)cmd.ExecuteScalar();
   ```

   ## Login fonksiyonları
   1 - Musteriler için
   ```sql
     Create function Login_Müşteri(_tc integer, _sifre character varying)
     returns int as
     $$
      begin
      if(select count(*) from musteriler where tc=_tc and sifre=_sifre) > 0 then 
        return 1; -- sistemde var oldupunu gösterir
      else 
        return 0;
      end if;
     end
      $$
      language plpgsql
   ```
   2 - Calısanlar için
   ```sql
      Create function Login_BankaCalışanları(_tc integer, _sifre character varying, _kullanıcıKodu integer)
      returns int as
      $$
      begin
      if(select count(*) from calisanlar where tc=_tc and sifre=_sifre and kullanıcı_kodu=_kullanıcıKodu) > 0 then 
        return 1; -- sistemde var oldupunu gösterir
      else 
        return 0;
      end if;
      end
      $$
     language plpgsql
   ```



   ## Insert fonksiyonu
   1 - Musteriler tablosu için   
   ```sql

   create or replace function insert_musteriler(_isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _temsilci_id integer, _sifre character varying)

   returns int as
 
  $$
  begin
 	    insert into musteriler(isim, soyisim, adres, email, telefon, tc, temsilci_id, sifre)
	    values(_isim, _soyisim, _adres, _email, _telefon, _tc, _temsilci_id, _sifre);
	    if found then
	    	return 1;
	   else 
	    	return 0;
    	end if;
  end
  $$
  language plpgsql;

   ```
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

 # Kaynakça
   1 - https://www.youtube.com/watch?v=JFxY2qajjwA
   
   2 - https://www.youtube.com/watch?v=URskGHtvFlE&t=22128s

   3 - https://www.youtube.com/playlist?list=PLh9ECzBB8tJOS7WQKdeUaAa5fmPLYAouD

   4 - https://www.youtube.com/watch?v=U_v1dSglNjE
