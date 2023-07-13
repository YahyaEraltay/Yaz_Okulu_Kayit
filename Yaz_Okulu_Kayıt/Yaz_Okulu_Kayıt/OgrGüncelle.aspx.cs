using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;
namespace Yaz_Okulu_Kayıt
{
    public partial class OgrGüncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            TextBox7.Text = x.ToString();
            TextBox7.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityOgrenci> ogrlist = BLLOgrenci.BllDetay(x);
                TextBox1.Text = ogrlist[0].AD.ToString();
                TextBox2.Text = ogrlist[0].SOYAD.ToString();
                TextBox3.Text = ogrlist[0].NUMARA.ToString();
                TextBox4.Text = ogrlist[0].SIFRE.ToString();
                TextBox5.Text = ogrlist[0].FOTO.ToString();
                TextBox6.Text = ogrlist[0].BAKIYE.ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            EntityOgrenci ent = new EntityOgrenci();
            ent.ID = Convert.ToInt32(TextBox7.Text);
            ent.AD = TextBox1.Text;
            ent.SOYAD = TextBox2.Text;
            ent.NUMARA = TextBox3.Text;
            ent.SIFRE = TextBox4.Text;
            ent.FOTO = TextBox5.Text;
            ent.BAKIYE = Convert.ToDouble(TextBox6.Text);
            BLLOgrenci.OgrenciGuncelleBll(ent);
            Response.Redirect("Öğrenci.aspx");

        }
    }
}