using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DalPersonel
    {

        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * From Tbl_PersonelBilgi", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["PersonelID"].ToString());
                ent.Ad = dr["PersonelAd"].ToString();
                ent.Sehir = dr["PersonelSehir"].ToString();
                ent.Gorev = dr["PersonelGorev"].ToString();
                ent.Maas = int.Parse(dr["Maas"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {

            SqlCommand komut2 = new SqlCommand("insert into Tbl_PersonelBilgi (PersonelAd,PersonelSehir,PersonelGorev,Maas) VALUES (@P1,@P2,@P3,@P4)", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Ad);
            komut2.Parameters.AddWithValue("@P2", p.Sehir);
            komut2.Parameters.AddWithValue("@P3", p.Gorev);
            komut2.Parameters.AddWithValue("@P4", p.Maas);
            return komut2.ExecuteNonQuery();


        }
        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_PersonelBilgi where PersonelID = @P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool PersonelGuncelle(EntityPersonel ent)
            
        {
            SqlCommand komut4 = new SqlCommand("UPDATE Tbl_PersonelBilgi SET PersonelAd = @P1, PersonelSehir = @P2, PersonelGorev = @P3, Maas = @P4 WHERE PersonelID = @P5", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", ent.Ad);
            komut4.Parameters.AddWithValue("@P2", ent.Sehir);
            komut4.Parameters.AddWithValue("@P3", ent.Gorev);
            komut4.Parameters.AddWithValue("@P4", ent.Maas);
            komut4.Parameters.AddWithValue("@P5", ent.Id);
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
