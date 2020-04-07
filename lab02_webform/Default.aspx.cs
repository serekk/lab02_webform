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
        }
        protected void Button1_Click(object sender, EventArgs e) 
        {

            int a = int.Parse(TextBoxWartosc1.Text);
            int b = int.Parse(TextBoxWartosc2.Text);

            var op = DropDownList1.SelectedValue;

            switch (op)
            {
                case "+":
                    TextBoxWynik.Text = (a + b).ToString();
                    break;
                case "-":
                    TextBoxWynik.Text = (a - b).ToString();
                    break;
                case "*":
                    TextBoxWynik.Text = (a * b).ToString();
                    break;
                case "/":
                    TextBoxWynik.Text = (a / b).ToString();
                    break;
                
                default:
                    TextBoxWynik.Text = "Nieobslugiwany operator";
                    break;
            }
        }
    }
}