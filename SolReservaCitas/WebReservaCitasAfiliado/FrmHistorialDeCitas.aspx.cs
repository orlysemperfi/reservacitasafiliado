using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
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
                         
            WSReservaCita.ReservaCitaServiceClient proxyReservaCita = new WSReservaCita.ReservaCitaServiceClient();
            List<WSReservaCita.ReservaCita> LstReservas = proxyReservaCita.ListarReservaCita().ToList();
            grdListado.DataSource = LstReservas;
            grdListado.DataBind();
            
        }
        protected void btnListar_Click(object sender, EventArgs e)
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:5001/Implementacion/HistorialReservasService.svc/Historial");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string clienteJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();

            IList<HistorialReservas> Lista = js2.Deserialize<IList<HistorialReservas>>(clienteJson2);
            ICollection<HistorialReservas> modelo = Lista;
            grdListado.DataSource = Lista;
            grdListado.DataBind();
            
        }

    }
}