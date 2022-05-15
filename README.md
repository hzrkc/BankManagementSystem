# Bank Management System
 C# Form application with PostgreSQL
 
Banka içerisinde müşteri, temsilci ve banka müdürü olmak üzere 3 adet rol bulunmaktadır. Müşteriler ve
çalışanlar için gerekli tanımlayıcı bilgiler (Ad Soyad, Telefon, TC No, Adres, E-posta) veri tabanında
saklanmalıdır. Bir müşterinin birden fazla hesabı bulunabilir. Hesaplar sistem içerisinde kayıtlı bulunan
herhangi bir para birimi cinsinden açılabilir (TL varsayılan olarak gelmelidir). Hesaplar arası para
transferinde gerekli durumlarda kur dönüşümü otomatik olarak yapılmaktadir.Tüm bu eylemlerin tasarlanan bir arayüz üzerinden görsel bir şekilde
gösterilmiştir.

Müşteri Temsilcisi
* TC sorguluyor
* Kayıt, Güncelleme, Silme yapıyor
* İlgilendiği Müşterileri görüyor
* Hesap talebini onaylıyor.
* İlgilendiği Müşterinin için Hesap oluşturma talebini onaylıyor.
* İlgilendiği Müşterinin için Hesap silme talebini onaylıyor.
* İlgilendiği müşterinin kredi talebini onaylıyor.

Müşteri 
* Hesap bilgilerini görüntüleyebiliyor.
* Hesap oluşturma talebi oluşturabiliyor.
* Kredi talep oluşturma yapabiliyor.
* Kişisel bilgilerini güncelleyebiliyor.
* Hesap silme talebi oluşturabiliyor.
* Aylık özet görebiliyor.

Banka Müdürü
* Müşteri Kaydı yapıyor.
* Yatırım Fonu düzenleyip Ekleyebiliyor
* Son işlem tablosunu görebiliyor
* Kredi vade / faiz ayarlıyabiliyor // fonksiyon eklenecek

 
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

