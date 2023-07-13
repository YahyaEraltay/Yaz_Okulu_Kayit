using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;
namespace Yaz_Okulu_Kayıt
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> ent = BLLDers.BllListele();
                DropDownList1.DataSource = BLLDers.BllListele();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "DERSID";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm entBas = new EntityBasvuruForm();
            entBas.BASOGRID = Convert.ToInt32(TextBox1.Text);
            entBas.BASDERSID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            BLLDers.TalepEkleBll(entBas);
        }
    }
}