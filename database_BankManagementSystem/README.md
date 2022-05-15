# PostgreSQL_Database

# SQL Komutları

 - İslem tablosundaki son 5 işlemi getirme:
 ```sql
  SELECT * FROM islem 
    WHERE islem_no > (SELECT MAX(islem_no) - 5 FROM islem)

     (Buradaki 5 yerine kullanıcıdan alınan x bir değer yazılarak istenilen sayıda işlem gelmesi sağlanabilir.)
```
- Geçiçi Tablo oluşturma
```sql
  DROP TABLE geciciMusteriler;
  CREATE TEMPORARY TABLE geciciMusteriler AS SELECT * FROM musteriler;
  ALTER TABLE geciciMusteriler DROP COLUMN sifre;
 ```

- İlgilenilen Müşteri Listesi
  ```sql
    SELECT * FROM musteriler M
    JOIN calisanlar C on C.id=M.temsilci_id
    WHERE C.tc= XXXXX
  ```

  - Musteri Hesap Bilgileri
  ```sql
    SELECT hesaplar.id, hesaplar.hesap_isim,hesaplar.bakiye,hesaplar.hesap_tur_id,hesaplar.hesap_tur_isim,hesaplar.yatirim_fon_id
    FROM hesaplar
    JOIN musteriler
    ON musteriler.id = 17 AND musteriler.id = hesaplar.uye_id

    (17 nolu müşterinin hesap bilgilerini getirir. Yerine kullanıcı girişi alarak 'x' nolu kullanıcının hesap bilgileri getirilebilir.)
  ```

  - En az Müşterisi olan Temsilci
    ```sql
    SELECT temsilci_id
    FROM musteriler 
    GROUP BY temsilci_id
    ORDER BY count(temsilci_id) ASC
    LIMIT 1;
    ```

  - Gider Hesaplama
  ```sql
  SELECT Sum(tutar) AS Gider
  FROM islem
  WHERE kaynak_tc = 24779888987 /* musteri tc */
  ```

  - Gider Hesaplama
  ```sql
  SELECT Sum(tutar) AS Gelir
  FROM islem
  WHERE hedef_tc = 24779888987 /* musteri tc */
  ```


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

   create or replace function insert_musteriler(_isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon bigint, _tc bigint, _temsilci_id bigint, _sifre character varying)

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

   2 - Calisanlar tablosu için
   ```sql

    create or replace function insert_calisanlar(_kullanıcı_kodu integer, _isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon bigint, _tc bigint, _sifre character varying )
    returns int as
    $$
    begin
      insert into calisanlar(kullanıcı_kodu, isim, soyisim, adres, email, telefon, tc, sifre)
      values(_kullanıcı_kodu, _isim, _soyisim, _adres, _email, _telefon, _tc, _sifre);
      if found then -- inserted successfully
        return 1;
      else 
        return 0;
      end if;
    end
    $$
    language plpgsql;

   ```

   3 - Hesaplar tablosu için
   ```sql

    create or replace function insert_hesaplar(_uye_id integer, _hesap_tur_id integer, _yatirim_fon_id integer, _bakiye double precision, _hesap_isim character varying, _hesap_tur_isim character varying)
    returns int as
    $$
    begin
      insert into hesaplar(uye_id, hesap_tur_id, yatirim_fon_id, bakiye, hesap_isim, hesap_tur_isim)
      values(_uye_id, _hesap_tur_id, _yatirim_fon_id, _bakiye, _hesap_isim, _hesap_tur_isim);
      if found then -- inserted successfully
        return 1;
      else 
        return 0;
      end if;
    end
    $$
    language plpgsql;

   ```


   4 - Yatirim_Fonu tablosu için
   ```sql

    create or replace function insert_yatirim_fonu(_para_turu character varying, _kur double precision)
    returns int as
    $$
    begin
      insert into yatirim_fonu(para_turu, kur)
      values(_para_turu, _kur);
      if found then -- inserted successfully
        return 1;
      else 
        return 0;
      end if;
    end
    $$
    language plpgsql;

   ```
   ## Delete 
   1 - Musteriler tablosundan silmek için
   ```sql
   CREATE OR REPLACE FUNCTION public.delete_musteriler(_tc integer)
    RETURNS integer
    LANGUAGE 'plpgsql'

    COST 100
    VOLATILE 
   AS 
   $BODY$
     begin
	 delete from musteriler
	 where tc = _tc;
	 if found then --deleted successfully
	  return 1;
	 else
	  return 0;
	 end if;
	end
    $BODY$;
   ```

      2 - Calisanlar tablosundan silmek için
   ```sql
    CREATE OR REPLACE FUNCTION delete_calisanlar(_tc bigint)
    returns int as
    $$
    begin
      delete from calisanlar
      where tc = _tc;
      if found then -- deleted successfully
        return 1;
      else
        return 0;
      end if;
    end
    $$
    language plpgsql
   ```
      3 - Hesaplar tablosundan silmek için
   ```sql
    CREATE OR REPLACE FUNCTION delete_hesaplar(_id int)
    returns int as
    $$
    begin
      delete from hesaplar
      where id = _id;
      if found then -- deleted successfully
        return 1;
      else
        return 0;
      end if;
    end
    $$
    language plpgsql
   ```
   
   ## Müşteri kaydı sorgulamak için
   ```sql
   Create function Sorgula_Müşteri(_tc integer)
   returns int as
   $$
   begin
    if(select count(*) from musteriler where tc=_tc) > 0 then 
      return 1; -- sistemde var oldupunu gösterir
    else 
      return 0;
    end if;
   end
   $$
   language plpgsql
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

   ## Update Fonksiyonları
   1 - Musteriler tablosu için
   ```sql
      CREATE OR REPLACE FUNCTION public.update_musteriler(
      _isim character varying,
      _soyisim character varying,
      _adres character varying,
      _email character varying,
      _telefon bigint,
      _tc bigint,
      _temsilci_id bigint,
      _sifre character varying)
        RETURNS integer
        LANGUAGE 'plpgsql'
        COST 100
        VOLATILE PARALLEL UNSAFE
    AS $BODY$

    begin
      update musteriler
    set 
      isim = _isim,
      soyisim = _soyisim,
      adres = _adres,
      email = _email,
      telefon = _telefon,
      sifre = _sifre
    where tc = _tc;
    if found then --updated successfully
      return 1;
    else --updated fail
      return 0;
    end if;
    end
    
    $BODY$;

   ```

 # Kaynakça
   1 - https://www.youtube.com/watch?v=JFxY2qajjwA
   
   2 - https://www.youtube.com/watch?v=URskGHtvFlE&t=22128s

   3 - https://www.youtube.com/playlist?list=PLh9ECzBB8tJOS7WQKdeUaAa5fmPLYAouD

   4 - https://www.youtube.com/watch?v=U_v1dSglNjE
