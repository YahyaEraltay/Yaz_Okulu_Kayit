using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDersler.DersListesi();
        }

        public static int TalepEkleBll(EntityBasvuruForm p)
        {
            if (p.BASOGRID!=null && p.BASDERSID!=null)
            {
                return DALDersler.TalepEkle(p);
            }
            return -1;
        }
    }
}
