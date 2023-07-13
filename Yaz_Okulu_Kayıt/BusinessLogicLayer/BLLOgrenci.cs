using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;


namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci p)
        {
            if (p.AD != null && p.AD != "" && p.SOYAD != null && p.SOYAD != "" && p.NUMARA != null && p.NUMARA != "" && p.FOTO != null && p.FOTO != "" && p.SIFRE != null && p.SIFRE != "")
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p >= 0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> BllDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool OgrenciGuncelleBll(EntityOgrenci p)
        {
            if (p.AD != null && p.AD != "" && p.SOYAD != null && p.SOYAD != "" && p.NUMARA != null && p.NUMARA != "" && p.FOTO != null && p.FOTO != "" && p.SIFRE != null && p.SIFRE != "")
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
