using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bul0056.Aggregates;

namespace WF.Forms
{
    public partial class MujProfil : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Zakaznik c = (Zakaznik)Session["login"];
                if(c != null)
                {
                    Label1.Text = c.Jmeno;
                    Label2.Text = c.Prijmeni;
                    Label3.Text = c.Email;
                }
                
            }

            if(IsPostBack)
            {
                Zakaznik c = (Zakaznik)Session["login"];
                c.DelRequest();
            }
               
        }
    }
}