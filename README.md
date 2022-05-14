# Bank Management System
 C# Form application with PostgreSQL
 
Banka içerisinde müşteri, temsilci ve banka müdürü olmak üzere 3 adet rol bulunmaktadır. Müşteriler ve
çalışanlar için gerekli tanımlayıcı bilgiler (Ad Soyad, Telefon, TC No, Adres, E-posta) veri tabanında
saklanmalıdır. Bir müşterinin birden fazla hesabı bulunabilir. Hesaplar sistem içerisinde kayıtlı bulunan
herhangi bir para birimi cinsinden açılabilir (TL varsayılan olarak gelmelidir). Hesaplar arası para
transferinde gerekli durumlarda kur dönüşümü otomatik olarak yapılmaktadir.Tüm bu eylemlerin tasarlanan bir arayüz üzerinden görsel bir şekilde
gösterilmiştir.
 
 *(Proje içerisindeki bazı hataların çözümleri ve kodların açıklamaları ilgili klasörün içerisindeki README.md'ye eklenmiştir.)*

 ## Form Dizaynları
  1 - __Login__
  <p align="left"><img src="https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/img_FormDesign/Login.png" width="300"></p>
  
   *Müşteri için Giriş*
  
  <p align="left"><img src="https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/img_FormDesign/Login_Mus.png" width="300"></p>
  
  2 - __Banka Müdürü__
<p align="left"><img src="https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/img_FormDesign/Hesap_BankaM%C3%BCd%C3%BCr%C3%BC.png" width="300"></p>


  3 - __Müşteri Temsilcisi__
<p align="left"><img src="https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/img_FormDesign/Hesap_M%C3%BC%C5%9FteriTemsilcisi.png" width="300"></p>


  4 - __Müşteri__
<p align="left"><img src="https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/img_FormDesign/Hesap_M%C3%BC%C5%9Fteri.png" width="300"></p>



 ## Renk Paleti
  ![#d2afff Color Hex](https://github.com/zeynepaslierhan/BankManagementSystem/blob/main/images/img_Color/%23d2afff%20Color%20Hex.png)

  __Koyu__

  63, 52, 76

  210, 175, 255

  246, 239, 255

  246, 239, 255

  __Açık__

Geliştirenler

Zeynep Asli Erhan, Hazar Koç(https://github.com/hzrkc)

# SQL Komutları

 - İslem tablosundaki son 5 işlemi getirme:
 ```sql
  SELECT * FROM islem 
    WHERE islem_no > (SELECT MAX(islem_no) - 5 FROM islem)

     (Buradaki 5 yerine kullanıcıdan alınan x bir değer yazılarak istenilen sayıda işlem gelmesi sağlanabilir.)
```

- İlgilenilen Müşteri Listesi
```sql
  DROP TABLE geciciMusteriler;
  CREATE TEMPORARY TABLE geciciMusteriler AS SELECT * FROM musteriler;
  ALTER TABLE geciciMusteriler DROP COLUMN sifre;

  SELECT geciciMusteriler
  FROM geciciMusteriler
  JOIN calisanlar
  ON calisanlar.id = 1 AND geciciMusteriler.temsilci_id = calisanlar.id
  ```

  - Musteri Hesap Bilgileri
  ```sql
    SELECT hesaplar.id, hesaplar.hesap_isim,hesaplar.bakiye,hesaplar.hesap_tur_id,hesaplar.hesap_tur_isim,hesaplar.yatirim_fon_id
    FROM hesaplar
    JOIN musteriler
    ON musteriler.id = 17 AND musteriler.id = hesaplar.uye_id

    (17 nolu müşterinin hesap bilgilerini getirir. Yerine kullanıcı girişi alarak 'x' nolu kullanıcının hesap bilgileri getirilebilir.)
  ```
