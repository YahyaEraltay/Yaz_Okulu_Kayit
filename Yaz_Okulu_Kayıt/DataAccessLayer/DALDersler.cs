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
    public class DALDersler
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand cmd = new SqlCommand("Select * From TBL_DERS ", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DERSID = Convert.ToInt32(dr["dersid"].ToString());
                ent.DERSAD = dr["dersad"].ToString();
                ent.MIN = Convert.ToInt32(dr["dersminkont"].ToString());
                ent.MAX = Convert.ToInt32(dr["dersmakskont"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand cmd2 = new SqlCommand("insert into TBL_BASVURU (ogrenciid, dersid) values (@p1, @p2)", Baglanti.bgl);
            cmd2.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            cmd2.Parameters.AddWithValue("@p2", parametre.BASDERSID);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            return cmd2.ExecuteNonQuery();
        }
    }
}
