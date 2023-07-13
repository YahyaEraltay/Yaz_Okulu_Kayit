using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private int ogrid;
        private string ad;
        private string soyad;
        private string numara;
        private string foto;
        private string sifre;
        private double bakiye;


        public int ID
        {
            get { return ogrid; }
            set { ogrid = value; }
        }
        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string NUMARA
        {
            get { return numara; }
            set { numara = value; }
        }
        public string FOTO
        {
            get { return foto; }
            set { foto = value; }
        }
        public string SIFRE
        {
            get { return sifre; }
            set { sifre = value; }
        }
        public double BAKIYE
        {
            get { return bakiye; }
            set { bakiye = value; }
        }
    }
}
