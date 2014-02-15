using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebReservaCitasAfiliado
{
    public partial class FrmReservaCita : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LimpiarControles();
            }
        }

        protected void btnRegistrarReserva_Click(object sender, EventArgs e)
        {

        }

        protected void BtnActualizarReserva_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void CargarComboConsultorio()
        {
            int valor = Convert.ToInt32(cboCentro.SelectedValue.ToString());
            WSConsultorio.ConsultorioServiceClient proxyConsultorio = new WSConsultorio.ConsultorioServiceClient();
            List<WSConsultorio.Consultorio> LstConsultorios = proxyConsultorio.ListarPorCentro(valor).ToList();
            cboConsultorio.DataSource = LstConsultorios.ToList();
            cboConsultorio.DataValueField = "IdConsultorio";
            cboConsultorio.DataTextField = "NroConsultorio";

            cboConsultorio.DataBind();


        }

        private void LimpiarControles()
        {
            WSCentro.CentroServiceClient proxyCentro = new WSCentro.CentroServiceClient();
            List<WSCentro.Centro> LstCentros = proxyCentro.ListarCentros().ToList();
            cboCentro.DataSource = LstCentros.ToList();
            cboCentro.DataValueField = "IdCentroAtencion";
            cboCentro.DataTextField = "Descripcion";
            
            cboCentro.DataBind();

            WSMedico.MedicoServiceClient proxyMedico= new WSMedico.MedicoServiceClient();
            List<WSMedico.Medico> LstMedicos = proxyMedico.ListarMedicos().ToList();
            cboMedico.DataSource = LstMedicos.ToList();
            cboMedico.DataValueField = "IdMedico";
            cboMedico.DataTextField = "APaterno";
            cboMedico.DataBind();
            CargarComboConsultorio();
            txtDNI.Text = string.Empty;
            
            
            txtObservacion.Text = string.Empty;
            txtFecha.Text=string.Empty;
            lblMensaje.Visible = false;
        }

    }
}