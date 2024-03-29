PGDMP         /                z            project    14.2    14.2 E    O           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            P           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            Q           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            R           1262    17187    project    DATABASE     d   CREATE DATABASE project WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE project;
                postgres    false            �            1255    17293 >   Login_BankaCalışanları(integer, character varying, integer)    FUNCTION     �  CREATE FUNCTION public."Login_BankaCalışanları"(_tc integer, _sifre character varying, "_kullanıcıkodu" integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
   begin
   if(select count(*) from calisanlar where tc=_tc and sifre=_sifre and kullanıcı_kodu=_kullanıcıKodu) > 0 then 
     return 1; -- sistemde var oldupunu gösterir
   else 
     return 0;
   end if;
   end
   
$$;
 u   DROP FUNCTION public."Login_BankaCalışanları"(_tc integer, _sifre character varying, "_kullanıcıkodu" integer);
       public          postgres    false            �            1255    17294    delete_calisanlar(integer)    FUNCTION       CREATE FUNCTION public.delete_calisanlar(_tc integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    begin
      delete from calisanlar
      where tc = _tc;
      if found then -- deleted successfully
        return 1;
      else
        return 0;
      end if;
    end
    
$$;
 5   DROP FUNCTION public.delete_calisanlar(_tc integer);
       public          postgres    false            �            1255    17189    delete_hesaplar(integer)    FUNCTION     H  CREATE FUNCTION public.delete_hesaplar(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    begin
      delete from hesaplar
      where id = _id AND hesaplar.bakiye=0 OR hesaplar.bakiye IS NULL;
      if found then -- deleted successfully
        return 1;
      else
        return 0;
      end if;
    end
    $$;
 3   DROP FUNCTION public.delete_hesaplar(_id integer);
       public          postgres    false            �            1255    17190    delete_kreditalep(integer)    FUNCTION       CREATE FUNCTION public.delete_kreditalep(_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    begin
      delete from kredi_talep
      where id = _id;
      if found then -- deleted successfully
        return 1;
      else
        return 0;
      end if;
    end
    
$$;
 5   DROP FUNCTION public.delete_kreditalep(_id integer);
       public          postgres    false            �            1255    17295    delete_musteriler(integer)    FUNCTION     �   CREATE FUNCTION public.delete_musteriler(_tc integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
     begin
	 delete from musteriler
	 where tc = _tc;
	 if found then --deleted successfully
	  return 1;
	 else
	  return 0;
	 end if;
	end
    
$$;
 5   DROP FUNCTION public.delete_musteriler(_tc integer);
       public          postgres    false            �            1255    17296    delete_tumhesaplar(integer)    FUNCTION     X  CREATE FUNCTION public.delete_tumhesaplar(_uye_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    begin
      delete from hesaplar
      where uye_id = _uye_id AND hesaplar.bakiye=0 OR hesaplar.bakiye IS NULL;
      if found then -- deleted successfully
        return 1;
      else
        return 0;
      end if;
    end
    
$$;
 :   DROP FUNCTION public.delete_tumhesaplar(_uye_id integer);
       public          postgres    false            �            1255    17297 �   insert_calisanlar(integer, character varying, character varying, character varying, character varying, integer, integer, character varying)    FUNCTION     $  CREATE FUNCTION public.insert_calisanlar("_kullanıcı_kodu" integer, _isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _sifre character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into calisanlar(kullanıcı_kodu, isim, soyisim, adres, email, telefon, tc, sifre)
	values(_kullanıcı_kodu, _isim, _soyisim, _adres, _email, _telefon, _tc, _sifre);
	if found then -- inserted successfully
		return 1;
	else 
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.insert_calisanlar("_kullanıcı_kodu" integer, _isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _sifre character varying);
       public          postgres    false            �            1255    17298 a   insert_hesaplar(integer, integer, integer, double precision, character varying, integer, integer)    FUNCTION     3  CREATE FUNCTION public.insert_hesaplar(_uye_id integer, _hesap_tur_id integer, _yatirim_fon_id integer, _bakiye double precision, _hesap_isim character varying, _onay integer, _durum integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    begin
      insert into hesaplar(uye_id, hesap_tur_id, yatirim_fon_id, bakiye, hesap_isim, onay, durum)
      values(_uye_id, _hesap_tur_id, _yatirim_fon_id, _bakiye, _hesap_isim, _onay, _durum);
      if found then -- inserted successfully
        return 1;
      else 
        return 0;
      end if;
    end
    
$$;
 �   DROP FUNCTION public.insert_hesaplar(_uye_id integer, _hesap_tur_id integer, _yatirim_fon_id integer, _bakiye double precision, _hesap_isim character varying, _onay integer, _durum integer);
       public          postgres    false            �            1255    17299 m   insert_islem(character varying, integer, integer, double precision, double precision, double precision, date)    FUNCTION     =  CREATE FUNCTION public.insert_islem(_islem character varying, _kaynak_tc integer, _hedef_tc integer, _tutar double precision, _kaynak_bakiye double precision, _hedef_bakiye double precision, _tarih date) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    begin
      insert into islem(islem, kaynak_tc , hedef_tc, tutar, kaynak_bakiye, hedef_bakiye, tarih)
      values(_islem, _kaynak_tc, _hedef_tc, _tutar, _kaynak_bakiye, _hedef_bakiye, _tarih);
      if found then -- inserted successfully
        return 1;
      else 
        return 0;
      end if;
    end
    
$$;
 �   DROP FUNCTION public.insert_islem(_islem character varying, _kaynak_tc integer, _hedef_tc integer, _tutar double precision, _kaynak_bakiye double precision, _hedef_bakiye double precision, _tarih date);
       public          postgres    false            �            1255    17300 ?   insert_kredi_talep(integer, double precision, integer, integer)    FUNCTION     �  CREATE FUNCTION public.insert_kredi_talep(_tc integer, _talep_miktar double precision, _kredi_tur_id integer, _onay integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    begin
      insert into kredi_talep(tc, talep_miktar, kredi_tur_id, onay)
      values(_tc, _talep_miktar, _kredi_tur_id, _onay);
      if found then -- inserted successfully
        return 1;
      else 
        return 0;
      end if;
    end
    
$$;
 |   DROP FUNCTION public.insert_kredi_talep(_tc integer, _talep_miktar double precision, _kredi_tur_id integer, _onay integer);
       public          postgres    false            �            1255    17301 �   insert_musteriler(character varying, character varying, character varying, character varying, integer, integer, integer, character varying)    FUNCTION     �  CREATE FUNCTION public.insert_musteriler(_isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _temsilci_id integer, _sifre character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
 	insert into musteriler(isim, soyisim, adres, email, telefon, tc, temsilci_id, sifre)
	values(_isim, _soyisim, _adres, _email, _telefon, _tc, _temsilci_id, _sifre);
	if found then
		return 1;
	else 
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.insert_musteriler(_isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _temsilci_id integer, _sifre character varying);
       public          postgres    false            �            1255    17302    insert_sistem(date, integer)    FUNCTION     1  CREATE FUNCTION public.insert_sistem(_tarih date, _tc integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    begin
      insert into sistem(tarih,tc)
      values(_tarih,_tc);
      if found then -- inserted successfully
        return 1;
      else 
        return 0;
      end if;
    end
    
$$;
 >   DROP FUNCTION public.insert_sistem(_tarih date, _tc integer);
       public          postgres    false            �            1255    17198 8   insert_yatirim_fonu(character varying, double precision)    FUNCTION     2  CREATE FUNCTION public.insert_yatirim_fonu(_para_turu character varying, _kur double precision) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into yatirim_fonu(para_turu, kur)
	values(_para_turu, _kur);
	if found then -- inserted successfully
		return 1;
	else 
		return 0;
	end if;
end
$$;
 _   DROP FUNCTION public.insert_yatirim_fonu(_para_turu character varying, _kur double precision);
       public          postgres    false            �            1255    17303 +   login_müşteri(integer, character varying)    FUNCTION     :  CREATE FUNCTION public."login_müşteri"(_tc integer, _sifre character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
   begin
   if(select count(*) from musteriler where tc=_tc and sifre=_sifre) > 0 then 
     return 1; -- sistemde var oldupunu gösterir
   else 
     return 0;
   end if;
  end
   
$$;
 O   DROP FUNCTION public."login_müşteri"(_tc integer, _sifre character varying);
       public          postgres    false            �            1255    17201 &   update_banka_uyeleri(integer, integer)    FUNCTION     !  CREATE FUNCTION public.update_banka_uyeleri(_id integer, _maas integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update banka_uyeleri
 set 
  maas=_maas
 where id = _id;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end
 
$$;
 G   DROP FUNCTION public.update_banka_uyeleri(_id integer, _maas integer);
       public          postgres    false            �            1255    17304 ,   update_durumhesap(integer, integer, integer)    FUNCTION     :  CREATE FUNCTION public.update_durumhesap(_tc integer, _durum integer, _id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update hesaplar
 set 
  durum=_durum
 where id = _id AND uye_id = _tc;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end
 
$$;
 R   DROP FUNCTION public.update_durumhesap(_tc integer, _durum integer, _id integer);
       public          postgres    false            �            1255    17203 =   update_kredi_tur(integer, double precision, double precision)    FUNCTION     H  CREATE FUNCTION public.update_kredi_tur(_id integer, _vade double precision, _faiz double precision) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update kredi_tur
 set 
  vade=_vade,
  faiz=_faiz
 where id = _id;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end
 
$$;
 d   DROP FUNCTION public.update_kredi_tur(_id integer, _vade double precision, _faiz double precision);
       public          postgres    false            �            1255    17305 #   update_kreditalep(integer, integer)    FUNCTION       CREATE FUNCTION public.update_kreditalep(_tc integer, _onay integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update kredi_talep
 set 
  onay=_onay
 where tc = _tc;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end
 
$$;
 D   DROP FUNCTION public.update_kreditalep(_tc integer, _onay integer);
       public          postgres    false            �            1255    17306 �   update_musteriler(character varying, character varying, character varying, character varying, integer, integer, integer, character varying)    FUNCTION       CREATE FUNCTION public.update_musteriler(_isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _temsilci_id integer, _sifre character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$

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
 
$$;
 �   DROP FUNCTION public.update_musteriler(_isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _temsilci_id integer, _sifre character varying);
       public          postgres    false                        1255    17307 "   update_onayhesap(integer, integer)    FUNCTION       CREATE FUNCTION public.update_onayhesap(_tc integer, _onay integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update hesaplar
 set 
  onay=_onay
 where uye_id = _tc;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end
 
$$;
 C   DROP FUNCTION public.update_onayhesap(_tc integer, _onay integer);
       public          postgres    false            �            1255    17207 -   update_yatirimfonu(integer, double precision)    FUNCTION     $  CREATE FUNCTION public.update_yatirimfonu(_id integer, _kur double precision) RETURNS integer
    LANGUAGE plpgsql
    AS $$

 begin
  update yatirim_fonu
 set 
  kur=_kur
 where id = _id;
 if found then --updated successfully
  return 1;
 else --updated fail
  return 0;
 end if;
 end
 
$$;
 M   DROP FUNCTION public.update_yatirimfonu(_id integer, _kur double precision);
       public          postgres    false            �            1259    17208    banka_uyeleri    TABLE     �   CREATE TABLE public.banka_uyeleri (
    "kullanıcı_kodu" integer NOT NULL,
    uye_isim character varying NOT NULL,
    maas double precision NOT NULL
);
 !   DROP TABLE public.banka_uyeleri;
       public         heap    postgres    false            �            1259    17213 
   calisanlar    TABLE     [  CREATE TABLE public.calisanlar (
    id integer NOT NULL,
    "kullanıcı_kodu" integer NOT NULL,
    isim character varying NOT NULL,
    soyisim character varying NOT NULL,
    adres character varying NOT NULL,
    email character varying NOT NULL,
    telefon integer NOT NULL,
    tc integer NOT NULL,
    sifre character varying NOT NULL
);
    DROP TABLE public.calisanlar;
       public         heap    postgres    false            �            1259    17218    calisanlar_id_seq    SEQUENCE     �   ALTER TABLE public.calisanlar ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.calisanlar_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    210            �            1259    17219 	   hesap_tur    TABLE     _   CREATE TABLE public.hesap_tur (
    id integer NOT NULL,
    tur character varying NOT NULL
);
    DROP TABLE public.hesap_tur;
       public         heap    postgres    false            �            1259    17224    hesaplar    TABLE       CREATE TABLE public.hesaplar (
    id integer NOT NULL,
    uye_id integer NOT NULL,
    hesap_tur_id integer NOT NULL,
    yatirim_fon_id integer NOT NULL,
    bakiye double precision,
    hesap_isim character varying NOT NULL,
    onay integer NOT NULL,
    durum integer NOT NULL
);
    DROP TABLE public.hesaplar;
       public         heap    postgres    false            �            1259    17229    hesaplar_id_seq    SEQUENCE     �   ALTER TABLE public.hesaplar ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.hesaplar_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    213            �            1259    17230    islem    TABLE     '  CREATE TABLE public.islem (
    islem_no integer NOT NULL,
    islem character varying NOT NULL,
    kaynak_tc integer NOT NULL,
    hedef_tc integer NOT NULL,
    tutar double precision NOT NULL,
    kaynak_bakiye double precision,
    hedef_bakiye double precision,
    tarih date NOT NULL
);
    DROP TABLE public.islem;
       public         heap    postgres    false            �            1259    17235    islem_islem_no_seq    SEQUENCE     �   ALTER TABLE public.islem ALTER COLUMN islem_no ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.islem_islem_no_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    215            �            1259    17236    kredi_talep    TABLE     �   CREATE TABLE public.kredi_talep (
    kredi_id integer NOT NULL,
    tc integer NOT NULL,
    talep_miktar double precision NOT NULL,
    kredi_tur_id integer NOT NULL,
    onay integer NOT NULL
);
    DROP TABLE public.kredi_talep;
       public         heap    postgres    false            �            1259    17239    kredi_talep_kredi_id_seq    SEQUENCE     �   ALTER TABLE public.kredi_talep ALTER COLUMN kredi_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.kredi_talep_kredi_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    217            �            1259    17240 	   kredi_tur    TABLE     �   CREATE TABLE public.kredi_tur (
    id integer NOT NULL,
    tur character varying NOT NULL,
    vade double precision NOT NULL,
    faiz double precision NOT NULL
);
    DROP TABLE public.kredi_tur;
       public         heap    postgres    false            �            1259    17245    kredi_tur_id_seq    SEQUENCE     �   ALTER TABLE public.kredi_tur ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.kredi_tur_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    219            �            1259    17246 
   musteriler    TABLE     T  CREATE TABLE public.musteriler (
    id integer NOT NULL,
    isim character varying NOT NULL,
    soyisim character varying NOT NULL,
    adres character varying NOT NULL,
    email character varying NOT NULL,
    telefon integer NOT NULL,
    tc integer NOT NULL,
    temsilci_id integer NOT NULL,
    sifre character varying NOT NULL
);
    DROP TABLE public.musteriler;
       public         heap    postgres    false            �            1259    17251    musteriler_id_seq    SEQUENCE     �   ALTER TABLE public.musteriler ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.musteriler_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    221            �            1259    17284    sistem    TABLE     j   CREATE TABLE public.sistem (
    id integer NOT NULL,
    tarih date NOT NULL,
    tc integer NOT NULL
);
    DROP TABLE public.sistem;
       public         heap    postgres    false            �            1259    17255    yatirim_fonu    TABLE     �   CREATE TABLE public.yatirim_fonu (
    id integer NOT NULL,
    para_turu character varying NOT NULL,
    kur double precision NOT NULL
);
     DROP TABLE public.yatirim_fonu;
       public         heap    postgres    false            =          0    17208    banka_uyeleri 
   TABLE DATA           K   COPY public.banka_uyeleri ("kullanıcı_kodu", uye_isim, maas) FROM stdin;
    public          postgres    false    209   �l       >          0    17213 
   calisanlar 
   TABLE DATA           m   COPY public.calisanlar (id, "kullanıcı_kodu", isim, soyisim, adres, email, telefon, tc, sifre) FROM stdin;
    public          postgres    false    210   <m       @          0    17219 	   hesap_tur 
   TABLE DATA           ,   COPY public.hesap_tur (id, tur) FROM stdin;
    public          postgres    false    212   Ym       A          0    17224    hesaplar 
   TABLE DATA           m   COPY public.hesaplar (id, uye_id, hesap_tur_id, yatirim_fon_id, bakiye, hesap_isim, onay, durum) FROM stdin;
    public          postgres    false    213   �m       C          0    17230    islem 
   TABLE DATA           p   COPY public.islem (islem_no, islem, kaynak_tc, hedef_tc, tutar, kaynak_bakiye, hedef_bakiye, tarih) FROM stdin;
    public          postgres    false    215   �m       E          0    17236    kredi_talep 
   TABLE DATA           U   COPY public.kredi_talep (kredi_id, tc, talep_miktar, kredi_tur_id, onay) FROM stdin;
    public          postgres    false    217   �m       G          0    17240 	   kredi_tur 
   TABLE DATA           8   COPY public.kredi_tur (id, tur, vade, faiz) FROM stdin;
    public          postgres    false    219   �m       I          0    17246 
   musteriler 
   TABLE DATA           f   COPY public.musteriler (id, isim, soyisim, adres, email, telefon, tc, temsilci_id, sifre) FROM stdin;
    public          postgres    false    221   n       L          0    17284    sistem 
   TABLE DATA           /   COPY public.sistem (id, tarih, tc) FROM stdin;
    public          postgres    false    224   )n       K          0    17255    yatirim_fonu 
   TABLE DATA           :   COPY public.yatirim_fonu (id, para_turu, kur) FROM stdin;
    public          postgres    false    223   Fn       S           0    0    calisanlar_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.calisanlar_id_seq', 1, false);
          public          postgres    false    211            T           0    0    hesaplar_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.hesaplar_id_seq', 1, false);
          public          postgres    false    214            U           0    0    islem_islem_no_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.islem_islem_no_seq', 1, false);
          public          postgres    false    216            V           0    0    kredi_talep_kredi_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.kredi_talep_kredi_id_seq', 1, false);
          public          postgres    false    218            W           0    0    kredi_tur_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.kredi_tur_id_seq', 1, false);
          public          postgres    false    220            X           0    0    musteriler_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.musteriler_id_seq', 1, false);
          public          postgres    false    222            �           2606    17261    hesaplar accounts_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.hesaplar
    ADD CONSTRAINT accounts_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.hesaplar DROP CONSTRAINT accounts_pkey;
       public            postgres    false    213            �           2606    17263    banka_uyeleri bank_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.banka_uyeleri
    ADD CONSTRAINT bank_pkey PRIMARY KEY ("kullanıcı_kodu");
 A   ALTER TABLE ONLY public.banka_uyeleri DROP CONSTRAINT bank_pkey;
       public            postgres    false    209            �           2606    17265    musteriler customers_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.musteriler
    ADD CONSTRAINT customers_pkey PRIMARY KEY (id);
 C   ALTER TABLE ONLY public.musteriler DROP CONSTRAINT customers_pkey;
       public            postgres    false    221            �           2606    17267    hesap_tur hesap_tur_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.hesap_tur
    ADD CONSTRAINT hesap_tur_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.hesap_tur DROP CONSTRAINT hesap_tur_pkey;
       public            postgres    false    212            �           2606    17269    islem islem_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.islem
    ADD CONSTRAINT islem_pkey PRIMARY KEY (islem_no);
 :   ALTER TABLE ONLY public.islem DROP CONSTRAINT islem_pkey;
       public            postgres    false    215            �           2606    17271    kredi_tur kredi_islem_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.kredi_tur
    ADD CONSTRAINT kredi_islem_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.kredi_tur DROP CONSTRAINT kredi_islem_pkey;
       public            postgres    false    219            �           2606    17273    kredi_talep kredi_talep_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.kredi_talep
    ADD CONSTRAINT kredi_talep_pkey PRIMARY KEY (kredi_id);
 F   ALTER TABLE ONLY public.kredi_talep DROP CONSTRAINT kredi_talep_pkey;
       public            postgres    false    217            �           2606    17288    sistem sistem_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.sistem
    ADD CONSTRAINT sistem_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.sistem DROP CONSTRAINT sistem_pkey;
       public            postgres    false    224            �           2606    17385    musteriler tc_unique 
   CONSTRAINT     M   ALTER TABLE ONLY public.musteriler
    ADD CONSTRAINT tc_unique UNIQUE (tc);
 >   ALTER TABLE ONLY public.musteriler DROP CONSTRAINT tc_unique;
       public            postgres    false    221            �           2606    17327    calisanlar tc_unique2 
   CONSTRAINT     N   ALTER TABLE ONLY public.calisanlar
    ADD CONSTRAINT tc_unique2 UNIQUE (tc);
 ?   ALTER TABLE ONLY public.calisanlar DROP CONSTRAINT tc_unique2;
       public            postgres    false    210            �           2606    17281    calisanlar workers_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.calisanlar
    ADD CONSTRAINT workers_pkey PRIMARY KEY (id);
 A   ALTER TABLE ONLY public.calisanlar DROP CONSTRAINT workers_pkey;
       public            postgres    false    210            �           2606    17283    yatirim_fonu yat_fon_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.yatirim_fonu
    ADD CONSTRAINT yat_fon_pkey PRIMARY KEY (id);
 C   ALTER TABLE ONLY public.yatirim_fonu DROP CONSTRAINT yat_fon_pkey;
       public            postgres    false    223            =   >   x�3��=�����ԢL�����̜���LNS.#N�ļ�D����{���47 
��qqq L�W      >      x������ � �      @   /   x�3���/�M��2��.JM��2�t9��,��˘�)1/;�+F��� ��      A      x������ � �      C      x������ � �      E      x������ � �      G      x������ � �      I      x������ � �      L      x������ � �      K      x�3���4�2�t��I,�44������ 7�f     