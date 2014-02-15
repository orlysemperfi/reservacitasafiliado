using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

            WSReservaCita.ReservaCitaServiceClient proxyReserva=new WSReservaCita.ReservaCitaServiceClient();

            string dni = txtDNI.Text;
            int idcentro =Convert.ToInt32( cboCentro.SelectedValue);
            int idconsultorio = Convert.ToInt32(cboConsultorio.SelectedValue);
            int idmedico = Convert.ToInt32(cboMedico.SelectedValue);
            string observacion = txtObservacion.Text;
            DateTime fechaAsignada = txtFecha.Text;
            int estado = 0;          
            try
            {
                WSReservaCita.ReservaCita reserva = proxyReserva.CrearReservaCita(dni, idcentro, idmedico, idconsultorio, fechaAsignada, observacion, estado);
                //Limpio los Controles
                LimpiarControles();
               

            }
            catch (FaultException<WSReservaCita.Error> ex)
            {
                //Validando si el DNI no existe
                lblMensaje.Visible = true;
                lblMensaje.Text = ex.Detail.MensajeNegocio;

            }
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

        protected void cboCentro_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarComboConsultorio();
         
        }

    }
}