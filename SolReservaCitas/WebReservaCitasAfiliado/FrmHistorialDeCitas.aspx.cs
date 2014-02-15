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
            
            if (!IsPostBack)
            {
                DateTime today = System.DateTime.Today;
       
                       
                txtDesde.Text = String.Format("{0:dd/MM/yyyy}", today);
                txtHasta.Text = String.Format("{0:dd/MM/yyyy}", today);
            }
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
     //   protected void btnConsultar_Click(object sender, EventArgs e)
      //  {
                         
      //      WSReservaCita.ReservaCitaServiceClient proxyReservaCita = new WSReservaCita.ReservaCitaServiceClient();
        //    List<WSReservaCita.ReservaCita> LstReservas = proxyReservaCita.ListarReservaCita().ToList();
       //     grdListado.DataSource = LstReservas;
       //     grdListado.DataBind();
            
      //  }
        protected void btnListar_Click(object sender, EventArgs e)
        {
            if (!txtDNI.Text.Equals(string.Empty) && !txtDesde.Text.Equals(string.Empty) &&
                !txtHasta.Text.Equals(string.Empty))
            {
                HttpWebRequest req2 = (HttpWebRequest)WebRequest
                    .Create("http://localhost:5001/Implementacion/HistorialReservasService.svc/Historias/" + txtDNI.Text.Trim() + "/" + String.Format("{0:yyyy-MM-dd}", txtDesde.Text) + "/" + String.Format("{0:yyyy-MM-dd}", txtHasta.Text));
                req2.Method = "GET";
                HttpWebResponse res2 = null;
                try
                {
                    res2 = (HttpWebResponse)req2.GetResponse();
                    StreamReader reader2 = new StreamReader(res2.GetResponseStream());
                    string clienteJson2 = reader2.ReadToEnd();
                    JavaScriptSerializer js2 = new JavaScriptSerializer();

                    IList<HistorialReservas> Lista = js2.Deserialize<IList<HistorialReservas>>(clienteJson2);
                    grdListado.DataSource = Lista;
                    lblMensaje.Text = string.Empty;
                    HistorialReservas item = (HistorialReservas)Lista.First();
                    lblNombre.Text = item.NombreAfiliado;
                }
                catch (WebException error)
                {
                    HttpWebResponse res1Error = (HttpWebResponse)error.Response;
                    StreamReader reader3 = new StreamReader(res1Error.GetResponseStream());
                    string error2 = reader3.ReadToEnd();
                    JavaScriptSerializer js3 = new JavaScriptSerializer();
                    string errorMessage = js3.Deserialize<string>(error2);
                    grdListado.DataSource = null;
                    lblMensaje.Text = errorMessage;
                    lblNombre.Text = string.Empty;
                }

                grdListado.DataBind();
            }
            else
            {
                grdListado.DataSource = null;
                lblMensaje.Text = "Ingrese Un DNI y Un rango de Fechas a Consultar";
                grdListado.DataBind();
                
            }
        }

    }
}