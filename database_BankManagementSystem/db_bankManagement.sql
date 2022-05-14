PGDMP     !    .                z            deneme    14.2    14.2 >    H           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            I           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            J           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            K           1262    33083    deneme    DATABASE     j   CREATE DATABASE deneme WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE deneme;
                postgres    false            �            1255    33084 �   insert_calisanlar(integer, character varying, character varying, character varying, character varying, integer, integer, character varying)    FUNCTION     $  CREATE FUNCTION public.insert_calisanlar("_kullanıcı_kodu" integer, _isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _sifre character varying) RETURNS integer
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
       public          postgres    false            �            1255    33085 b   insert_hesaplar(integer, integer, integer, double precision, character varying, character varying)    FUNCTION     
  CREATE FUNCTION public.insert_hesaplar(_uye_id integer, _hesap_tur_id integer, _yatirim_fon_id integer, _bakiye double precision, _hesap_isim character varying, _hesap_tur_isim character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into hesaplar(uye_id, hesap_tur_id, yatirim_fon_id, bakiye, hesap_isim, hesap_tur_isim)
	values(_uye_id, _hesap_tur_id, _yatirim_fon_id, _bakiye, _hesap_isim, _hesap_tur_isim);
	if found then -- inserted successfully
		return 1;
	else 
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.insert_hesaplar(_uye_id integer, _hesap_tur_id integer, _yatirim_fon_id integer, _bakiye double precision, _hesap_isim character varying, _hesap_tur_isim character varying);
       public          postgres    false            �            1255    33086 �   insert_musteriler(character varying, character varying, character varying, character varying, integer, integer, integer, character varying)    FUNCTION     �  CREATE FUNCTION public.insert_musteriler(_isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _temsilci_id integer, _sifre character varying) RETURNS integer
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
       public          postgres    false            �            1255    33087 8   insert_yatirim_fonu(character varying, double precision)    FUNCTION     2  CREATE FUNCTION public.insert_yatirim_fonu(_para_turu character varying, _kur double precision) RETURNS integer
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
       public          postgres    false            �            1255    41270 >   login_bankacalışanları(integer, character varying, integer)    FUNCTION     �  CREATE FUNCTION public."login_bankacalışanları"(_tc integer, _sifre character varying, "_kullanıcıkodu" integer) RETURNS integer
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
 u   DROP FUNCTION public."login_bankacalışanları"(_tc integer, _sifre character varying, "_kullanıcıkodu" integer);
       public          postgres    false            �            1255    41269 +   login_müşteri(integer, character varying)    FUNCTION     Q  CREATE FUNCTION public."login_müşteri"(_tc integer, _sifre character varying) RETURNS integer
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
       public          postgres    false            �            1255    41271    sorgula_müşteri(integer)    FUNCTION     (  CREATE FUNCTION public."sorgula_müşteri"(_tc integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
      begin
      if(select count(*) from musteriler where tc=_tc) > 0 then 
        return 1; -- sistemde var oldupunu gösterir
      else 
        return 0;
      end if;
     end
      $$;
 7   DROP FUNCTION public."sorgula_müşteri"(_tc integer);
       public          postgres    false            �            1255    33088 �   update_musteriler(integer, character varying, character varying, character varying, character varying, integer, integer, integer, character varying)    FUNCTION     M  CREATE FUNCTION public.update_musteriler(_id integer, _isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _temsilci_id integer, _sifre character varying) RETURNS integer
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
		tc = _tc,
		temsilci_id = _temsilci_id,
		sifre = _sifre
	where id = _id;
	if found then --updated successfully
		return 1;
	else -- update failed
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.update_musteriler(_id integer, _isim character varying, _soyisim character varying, _adres character varying, _email character varying, _telefon integer, _tc integer, _temsilci_id integer, _sifre character varying);
       public          postgres    false            �            1259    33089    banka_uyeleri    TABLE     �   CREATE TABLE public.banka_uyeleri (
    "kullanıcı_kodu" integer NOT NULL,
    uye_isim character varying NOT NULL,
    maas double precision NOT NULL
);
 !   DROP TABLE public.banka_uyeleri;
       public         heap    postgres    false            �            1259    33094 "   banka_uyeleri_kullanıcı_kodu_seq    SEQUENCE     �   ALTER TABLE public.banka_uyeleri ALTER COLUMN "kullanıcı_kodu" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."banka_uyeleri_kullanıcı_kodu_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    209            �            1259    33095 
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
       public         heap    postgres    false            �            1259    33100    calisanlar_id_seq    SEQUENCE     �   ALTER TABLE public.calisanlar ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.calisanlar_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    211            �            1259    33101 	   hesap_tur    TABLE     _   CREATE TABLE public.hesap_tur (
    id integer NOT NULL,
    tur character varying NOT NULL
);
    DROP TABLE public.hesap_tur;
       public         heap    postgres    false            �            1259    33106    hesap_tur_id_seq    SEQUENCE     �   ALTER TABLE public.hesap_tur ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.hesap_tur_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    213            �            1259    33107    hesaplar    TABLE       CREATE TABLE public.hesaplar (
    id integer NOT NULL,
    uye_id integer NOT NULL,
    hesap_tur_id integer NOT NULL,
    yatirim_fon_id integer NOT NULL,
    bakiye double precision,
    hesap_isim character varying NOT NULL,
    hesap_tur_isim character varying NOT NULL
);
    DROP TABLE public.hesaplar;
       public         heap    postgres    false            �            1259    33112    hesaplar_id_seq    SEQUENCE     �   ALTER TABLE public.hesaplar ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.hesaplar_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    215            �            1259    33113    islem    TABLE     L  CREATE TABLE public.islem (
    islem_no integer NOT NULL,
    islem character varying NOT NULL,
    kaynak_hesap_id integer NOT NULL,
    hedef_hesap_id integer NOT NULL,
    tutar double precision NOT NULL,
    kaynak_bakiye double precision,
    hedef_bakiye double precision,
    tarih_saat timestamp with time zone NOT NULL
);
    DROP TABLE public.islem;
       public         heap    postgres    false            �            1259    33118    islem_islem_no_seq    SEQUENCE     �   ALTER TABLE public.islem ALTER COLUMN islem_no ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.islem_islem_no_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    217            �            1259    33119    kredi_talep    TABLE     �   CREATE TABLE public.kredi_talep (
    kredi_id integer NOT NULL,
    uye_id integer NOT NULL,
    talep_miktar double precision NOT NULL,
    onay character varying NOT NULL,
    kredi_tur_id integer NOT NULL
);
    DROP TABLE public.kredi_talep;
       public         heap    postgres    false            �            1259    33124    kredi_talep_kredi_id_seq    SEQUENCE     �   ALTER TABLE public.kredi_talep ALTER COLUMN kredi_id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.kredi_talep_kredi_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    219            �            1259    33125 	   kredi_tur    TABLE     �   CREATE TABLE public.kredi_tur (
    id integer NOT NULL,
    tur character varying NOT NULL,
    vade double precision NOT NULL,
    faiz double precision NOT NULL
);
    DROP TABLE public.kredi_tur;
       public         heap    postgres    false            �            1259    33130    kredi_tur_id_seq    SEQUENCE     �   ALTER TABLE public.kredi_tur ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.kredi_tur_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    221            �            1259    33131 
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
       public         heap    postgres    false            �            1259    33136    musteriler_id_seq    SEQUENCE     �   ALTER TABLE public.musteriler ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.musteriler_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    223            �            1259    33137    sistem    TABLE     j   CREATE TABLE public.sistem (
    tarih date NOT NULL,
    id integer NOT NULL,
    tc integer NOT NULL
);
    DROP TABLE public.sistem;
       public         heap    postgres    false            �            1259    33140    yatirim_fonu    TABLE     �   CREATE TABLE public.yatirim_fonu (
    id integer NOT NULL,
    para_turu character varying NOT NULL,
    kur double precision NOT NULL
);
     DROP TABLE public.yatirim_fonu;
       public         heap    postgres    false            �            1259    33145    yatirim_fonu_id_seq    SEQUENCE     �   ALTER TABLE public.yatirim_fonu ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.yatirim_fonu_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 99999999
    CACHE 1
);
            public          postgres    false    226            3          0    33089    banka_uyeleri 
   TABLE DATA           K   COPY public.banka_uyeleri ("kullanıcı_kodu", uye_isim, maas) FROM stdin;
    public          postgres    false    209   (W       5          0    33095 
   calisanlar 
   TABLE DATA           m   COPY public.calisanlar (id, "kullanıcı_kodu", isim, soyisim, adres, email, telefon, tc, sifre) FROM stdin;
    public          postgres    false    211   EW       7          0    33101 	   hesap_tur 
   TABLE DATA           ,   COPY public.hesap_tur (id, tur) FROM stdin;
    public          postgres    false    213   bW       9          0    33107    hesaplar 
   TABLE DATA           p   COPY public.hesaplar (id, uye_id, hesap_tur_id, yatirim_fon_id, bakiye, hesap_isim, hesap_tur_isim) FROM stdin;
    public          postgres    false    215   W       ;          0    33113    islem 
   TABLE DATA           �   COPY public.islem (islem_no, islem, kaynak_hesap_id, hedef_hesap_id, tutar, kaynak_bakiye, hedef_bakiye, tarih_saat) FROM stdin;
    public          postgres    false    217   �W       =          0    33119    kredi_talep 
   TABLE DATA           Y   COPY public.kredi_talep (kredi_id, uye_id, talep_miktar, onay, kredi_tur_id) FROM stdin;
    public          postgres    false    219   �W       ?          0    33125 	   kredi_tur 
   TABLE DATA           8   COPY public.kredi_tur (id, tur, vade, faiz) FROM stdin;
    public          postgres    false    221   �W       A          0    33131 
   musteriler 
   TABLE DATA           f   COPY public.musteriler (id, isim, soyisim, adres, email, telefon, tc, temsilci_id, sifre) FROM stdin;
    public          postgres    false    223   �W       C          0    33137    sistem 
   TABLE DATA           /   COPY public.sistem (tarih, id, tc) FROM stdin;
    public          postgres    false    225   )X       D          0    33140    yatirim_fonu 
   TABLE DATA           :   COPY public.yatirim_fonu (id, para_turu, kur) FROM stdin;
    public          postgres    false    226   FX       L           0    0 "   banka_uyeleri_kullanıcı_kodu_seq    SEQUENCE SET     S   SELECT pg_catalog.setval('public."banka_uyeleri_kullanıcı_kodu_seq"', 1, false);
          public          postgres    false    210            M           0    0    calisanlar_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.calisanlar_id_seq', 1, false);
          public          postgres    false    212            N           0    0    hesap_tur_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.hesap_tur_id_seq', 1, false);
          public          postgres    false    214            O           0    0    hesaplar_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.hesaplar_id_seq', 1, false);
          public          postgres    false    216            P           0    0    islem_islem_no_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.islem_islem_no_seq', 1, false);
          public          postgres    false    218            Q           0    0    kredi_talep_kredi_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.kredi_talep_kredi_id_seq', 1, false);
          public          postgres    false    220            R           0    0    kredi_tur_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.kredi_tur_id_seq', 1, false);
          public          postgres    false    222            S           0    0    musteriler_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.musteriler_id_seq', 17, true);
          public          postgres    false    224            T           0    0    yatirim_fonu_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.yatirim_fonu_id_seq', 1, false);
          public          postgres    false    227            �           2606    33147    hesaplar accounts_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.hesaplar
    ADD CONSTRAINT accounts_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.hesaplar DROP CONSTRAINT accounts_pkey;
       public            postgres    false    215            �           2606    33149    banka_uyeleri bank_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.banka_uyeleri
    ADD CONSTRAINT bank_pkey PRIMARY KEY ("kullanıcı_kodu");
 A   ALTER TABLE ONLY public.banka_uyeleri DROP CONSTRAINT bank_pkey;
       public            postgres    false    209            �           2606    33151    musteriler customers_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.musteriler
    ADD CONSTRAINT customers_pkey PRIMARY KEY (id);
 C   ALTER TABLE ONLY public.musteriler DROP CONSTRAINT customers_pkey;
       public            postgres    false    223            �           2606    33153    hesap_tur hesap_tur_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.hesap_tur
    ADD CONSTRAINT hesap_tur_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.hesap_tur DROP CONSTRAINT hesap_tur_pkey;
       public            postgres    false    213            �           2606    33155    islem islem_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.islem
    ADD CONSTRAINT islem_pkey PRIMARY KEY (islem_no);
 :   ALTER TABLE ONLY public.islem DROP CONSTRAINT islem_pkey;
       public            postgres    false    217            �           2606    33157    kredi_tur kredi_islem_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.kredi_tur
    ADD CONSTRAINT kredi_islem_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY public.kredi_tur DROP CONSTRAINT kredi_islem_pkey;
       public            postgres    false    221            �           2606    33159    kredi_talep kredi_talep_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.kredi_talep
    ADD CONSTRAINT kredi_talep_pkey PRIMARY KEY (kredi_id);
 F   ALTER TABLE ONLY public.kredi_talep DROP CONSTRAINT kredi_talep_pkey;
       public            postgres    false    219            �           2606    33161    sistem sistem_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.sistem
    ADD CONSTRAINT sistem_pkey PRIMARY KEY (tarih);
 <   ALTER TABLE ONLY public.sistem DROP CONSTRAINT sistem_pkey;
       public            postgres    false    225            �           2606    33163    musteriler tc_unique 
   CONSTRAINT     M   ALTER TABLE ONLY public.musteriler
    ADD CONSTRAINT tc_unique UNIQUE (tc);
 >   ALTER TABLE ONLY public.musteriler DROP CONSTRAINT tc_unique;
       public            postgres    false    223            �           2606    33165    calisanlar tc_unique2 
   CONSTRAINT     N   ALTER TABLE ONLY public.calisanlar
    ADD CONSTRAINT tc_unique2 UNIQUE (tc);
 ?   ALTER TABLE ONLY public.calisanlar DROP CONSTRAINT tc_unique2;
       public            postgres    false    211            �           2606    33167    calisanlar workers_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.calisanlar
    ADD CONSTRAINT workers_pkey PRIMARY KEY (id);
 A   ALTER TABLE ONLY public.calisanlar DROP CONSTRAINT workers_pkey;
       public            postgres    false    211            �           2606    33169    yatirim_fonu yat_fon_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.yatirim_fonu
    ADD CONSTRAINT yat_fon_pkey PRIMARY KEY (id);
 C   ALTER TABLE ONLY public.yatirim_fonu DROP CONSTRAINT yat_fon_pkey;
       public            postgres    false    226            3      x������ � �      5      x������ � �      7      x������ � �      9      x������ � �      ;      x������ � �      =      x������ � �      ?      x������ � �      A   &   x�34猊B CC �NC#cS3sK�(W� �b	      C      x������ � �      D      x������ � �     