using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab02_webform
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var obj = Session["Kalkulator"];

                if (obj != null)
                {
                    var kalkulator = (Kalkulator)obj;
                    TextBoxWartosc1.Text = kalkulator.a.ToString();
                    TextBoxWartosc2.Text = kalkulator.b.ToString();
                    DropDownList1.SelectedValue = kalkulator.op;
                }

                else
                {
                    if (Request.Cookies["Kalkulator"] != null)
                    {
                        TextBoxWartosc1.Text = Request.Cookies["Kalkulator"].Values["a"];
                        TextBoxWartosc2.Text = Request.Cookies["Kalkulator"].Values["b"];
                        DropDownList1.SelectedValue = Request.Cookies["Kalkulator"].Values["op"];
                    }
                }

            }

        }
        protected void Button1_Click(object sender, EventArgs e) 
        {
            var kalkulator = new Kalkulator();


            kalkulator.a = int.Parse(TextBoxWartosc1.Text);
            kalkulator.b = int.Parse(TextBoxWartosc2.Text);
            kalkulator.op = DropDownList1.SelectedValue;

            Session["Kalkulator"] = kalkulator;

            Response.Cookies["Kalkulator"].Values["a"] = kalkulator.a.ToString();
            Response.Cookies["Kalkulator"].Values["b"] = kalkulator.b.ToString();
            Response.Cookies["Kalkulator"].Values["op"] = kalkulator.op;

            switch (kalkulator.op)
            {
                case "+":
                    TextBoxWynik.Text = (kalkulator.a + kalkulator.b).ToString();
                    break;
                case "-":
                    TextBoxWynik.Text = (kalkulator.a - kalkulator.b).ToString();
                    break;
                case "*":
                    TextBoxWynik.Text = (kalkulator.a * kalkulator.b).ToString();
                    break;
                case "/":
                    TextBoxWynik.Text = (kalkulator.a / kalkulator.b).ToString();
                    break;
                
                default:
                    TextBoxWynik.Text = "Nieobslugiwany operator";
                    break;
            }

        }

    }
}