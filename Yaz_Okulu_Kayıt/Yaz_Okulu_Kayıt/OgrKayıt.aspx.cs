using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
namespace Yaz_Okulu_Kayıt
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = TextBox1.Text;
            ent.SOYAD = TextBox2.Text;
            ent.NUMARA = TextBox3.Text;
            ent.SIFRE = TextBox4.Text;
            ent.FOTO = TextBox5.Text;
            ent.BAKIYE = double.Parse(TextBox6.Text);
            BLLOgrenci.OgrenciEkle(ent);
        }
    }
}