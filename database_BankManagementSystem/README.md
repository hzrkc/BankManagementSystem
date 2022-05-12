# PostgreSQL_Database

# Kullanılan Komutlar

1 - İlgilenilen Müşteriler Tablosu

```sql


```

2 - 


# BACKUP oluşturma

### Export yapmak için:

1 - Database üzerine gelinip backup seçilir.(Hata alıyorsanız NOT'lara bakınız)

2 - İstenilen klasöre "istenilenisim.sql" şeklinde kaydedilir.

### Import yapmak için

1 - import edilmek istenilen database'in üzerine gelinip Restore seçilir.

2 - istenilen backup dosyası seçilir.

### NOT

! File-> Preferences -> Path -> Binary Path kısmına gelinir

!! Database server türünün dosya seçmesine gelinir.

Örnek (PostgreSQL 10 için) C:\Program Files\PostgreSQL\10\bin seçilir.

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

# Kaynakça

1 - https://www.youtube.com/watch?v=JFxY2qajjwA

2 - https://www.youtube.com/watch?v=URskGHtvFlE&t=22128s

3 - https://www.youtube.com/playlist?list=PLh9ECzBB8tJOS7WQKdeUaAa5fmPLYAouD

4 - https://www.youtube.com/watch?v=U_v1dSglNjE