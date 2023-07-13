using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_OGRENCI (ograd,ogrsoyad,ogrnumara,ogrfoto,ogrsifre,ogrbakiye) values (@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", parametre.AD);
            cmd.Parameters.AddWithValue("@p2", parametre.SOYAD);
            cmd.Parameters.AddWithValue("@p3", parametre.NUMARA);
            cmd.Parameters.AddWithValue("@p4", parametre.FOTO);
            cmd.Parameters.AddWithValue("@p5", parametre.SIFRE);
            cmd.Parameters.AddWithValue("@p6", parametre.BAKIYE);
            return cmd.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd2 = new SqlCommand("Select * From TBL_OGRENCI ", Baglanti.bgl);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["ogrid"].ToString());
                ent.AD = dr["ograd"].ToString();
                ent.SOYAD = dr["ogrsoyad"].ToString();
                ent.NUMARA = dr["ogrnumara"].ToString();
                ent.SIFRE = dr["ogrsifre"].ToString();
                ent.FOTO = dr["ogrfoto"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["ogrbakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand cmd3 = new SqlCommand("Delete From TBL_OGRENCI where ogrid=@p1", Baglanti.bgl);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1", parametre);
            return cmd3.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd4 = new SqlCommand("Select * From TBL_OGRENCI where ogrid=@p1", Baglanti.bgl);
            cmd4.Parameters.AddWithValue("@p1", id);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            SqlDataReader dr = cmd4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ID = Convert.ToInt32(dr["ogrid"].ToString());
                ent.AD = dr["ograd"].ToString();
                ent.SOYAD = dr["ogrsoyad"].ToString();
                ent.NUMARA = dr["ogrnumara"].ToString();
                ent.SIFRE = dr["ogrsifre"].ToString();
                ent.FOTO = dr["ogrfoto"].ToString();
                ent.BAKIYE = Convert.ToDouble(dr["ogrbakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle (EntityOgrenci deger)
        {
            SqlCommand cmd5 = new SqlCommand("Update TBL_OGRENCI Set ograd=@p1, ogrsoyad=@p2, ogrnumara=@p3, ogrsifre=@p4, ogrfoto=@p5, ogrbakiye=@p6 where ogrid=@p7 ", Baglanti.bgl);
            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            cmd5.Parameters.AddWithValue("@p1", deger.AD);
            cmd5.Parameters.AddWithValue("@p2", deger.SOYAD);
            cmd5.Parameters.AddWithValue("@p3", deger.SIFRE);
            cmd5.Parameters.AddWithValue("@p4", deger.NUMARA);
            cmd5.Parameters.AddWithValue("@p5", deger.FOTO);
            cmd5.Parameters.AddWithValue("@p6", deger.BAKIYE);
            cmd5.Parameters.AddWithValue("@p7", deger.ID);

            return cmd5.ExecuteNonQuery() > 0;
        }
    }
}
