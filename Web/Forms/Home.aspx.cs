using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bul0056.Aggregates;

namespace WF.Forms
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                Zakaznik pot = Zakaznik.getById(Int32.Parse(TextBox2.Text));
                if(pot.Email == TextBox1.Text)
                {
                    Session["login"] = pot;
                }
            }
        }
    }
}