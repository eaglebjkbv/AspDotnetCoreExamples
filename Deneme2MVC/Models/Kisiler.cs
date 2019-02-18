using System.Collections.Generic;
using System.Data.SqlClient;
namespace Deneme2MVC.Models
{
    public class Kisiler
    {
        public string ID { get; set; }
        public string Ad { get; set; }

        public List<Kisiler> KisileriGetir()
        {
            List<Kisiler> listem = new List<Kisiler>();

            string baglantiCumlesi = "Data Source=HPBV\\BVSQLEXPRESS;Initial Catalog=ogrenci;User ID=sa;Password=123456";
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = baglantiCumlesi;
            SqlCommand cmd = new SqlCommand("Select * From bilgi", baglanti);
            baglanti.Open();
            SqlDataReader okuyucu = cmd.ExecuteReader();
            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    var kisi = new Kisiler();
                    kisi.ID = okuyucu[0].ToString();
                    kisi.Ad = okuyucu[1].ToString();
                    listem.Add(kisi);
                }
            }
            return listem;
        }
    }
}
