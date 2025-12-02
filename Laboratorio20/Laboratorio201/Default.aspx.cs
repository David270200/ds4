using System;

namespace Laboratorio201
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txtNumero.Text, out numero))
            {
                string tabla = "<h3>Tabla del " + numero + "</h3>";

                for (int i = 1; i <= 25; i++)
                {
                    tabla += numero + " x " + i + " = " + (numero * i) + "<br/>";
                }

                litResultado.Text = tabla;
            }
            else
            {
                litResultado.Text = "<span style='color:red;'>Ingrese un número válido.</span>";
            }
        }
    }
}