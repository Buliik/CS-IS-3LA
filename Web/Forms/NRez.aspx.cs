using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bul0056.Aggregates;
using System.Collections.ObjectModel;

namespace WF.Forms
{
    public partial class NRez : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Zakaznik c = (Zakaznik)Session["login"];

            if (!Page.IsPostBack)
            {
                Collection<Zbran> zbrane = Zbran.SelectAll();
                Collection<Prostor> prostory = Prostor.SelectAll();

                DropDownList1.DataSource = zbrane;
                DropDownList1.DataTextField = "Nazev";
                DropDownList1.DataValueField = "Id";

                DropDownList2.DataSource = prostory;
                DropDownList2.DataTextField = "Vzdalenost";
                DropDownList2.DataValueField = "Id";

                DropDownList1.DataBind();
                DropDownList2.DataBind();
            }



            if (IsPostBack)
            {
                Bul0056.Aggregates.Rezervace rez = new Bul0056.Aggregates.Rezervace();
                rez.Start = DateTime.Parse(TextBox1.Text);
                rez.Vytvoreni = DateTime.Now;
                rez.Zakaznik = c;
                rez.Zbran = Zbran.getById(Int32.Parse(DropDownList1.SelectedValue));
                rez.Prostor = Prostor.getById(Int32.Parse(DropDownList2.SelectedValue));
                Bul0056.Aggregates.Rezervace.insert(rez);
            }
        }

    }
}