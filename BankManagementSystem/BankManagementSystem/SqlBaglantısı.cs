using Npgsql;
using System;
using System.Linq;

namespace BankManagementSystem
{
    class SqlBaglantısı
    {
        public NpgsqlConnection Veritabani()
        {
            NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port_5432; Database= ;user Id=Postgres; password=7163");
            baglan.Open();
            return baglan;
        }
    }
}
