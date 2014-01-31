using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebReservaCitasAfiliado
{
    public partial class FrmHistorialDeCitas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Enabled = true;
            LimpiarControles();
 
        }
        private void LimpiarControles()
        {
            txtDNI.Text = string.Empty;
            lblNombre.Text = string.Empty;
            txtDesde.Text = string.Empty;
            txtHasta.Text = string.Empty;
            lblMensaje.Text = string.Empty;
            grdListado.DataSource = null;
            grdListado.DataBind();
        }
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            WSAfiliado.AfiliadoClient proxyAfiliado = new WSAfiliado.AfiliadoClient();

            List<WSAfiliado.Afiliado> LstAfiliado = proxyAfiliado.ListarAfiliado().ToList();
            grdListado.DataSource = LstAfiliado;
            grdListado.DataBind();
        }

    }
}