using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_15_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(TextBox1.Text);
            int n2 = int.Parse(TextBox2.Text);

            // Realizar la suma
            int resultado = n1 + n2;

            Label2.InnerHtml = "El resultado de la suma es: " + resultado;
        }
    }
}