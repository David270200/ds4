using System;
using System.Text;

namespace Laboratorio202
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            litMatriz.Text = string.Empty;
            lblError.Visible = false;

            if (!int.TryParse(txtN.Text.Trim(), out int N) || N <= 0)
            {
                lblError.Text = "Ingrese un número entero positivo para N.";
                lblError.Visible = true;
                return;
            }

            // Generar tabla HTML
            var sb = new StringBuilder();
            sb.Append($"<table class='matriz-table'>");

            for (int i = 0; i < N; i++)
            {
                sb.Append("<tr>");
                for (int j = 0; j < N; j++)
                {
                    // Diagonal inversa significa j == (N - 1 - i)
                    if (j == (N - 1 - i))
                    {
                        sb.Append("<td class='uno'>1</td>");
                    }
                    else
                    {
                        sb.Append("<td>0</td>");
                    }
                }
                sb.Append("</tr>");
            }

            sb.Append("</table>");

            litMatriz.Text = sb.ToString();
        }
    }
}