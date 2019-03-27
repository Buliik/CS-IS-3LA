using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WF.Forms
{
    public partial class Zbrane : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LinkButtonInsert_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["Nazev"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtNazev")).Text;
            SqlDataSource1.InsertParameters["Typ_zbrane"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtTyp")).Text;
            SqlDataSource1.InsertParameters["Raze"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtRaze")).Text;
            SqlDataSource1.InsertParameters["Rok_vyroby"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("txtRok")).Text;

            SqlDataSource1.Insert();
        }
    }
}