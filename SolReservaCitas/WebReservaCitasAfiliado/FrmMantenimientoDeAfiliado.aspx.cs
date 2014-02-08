using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebReservaCitasAfiliado
{
    public partial class FrmMantenimientoDeAfiliado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ListarTodosAfiliados();
            }
        }

        protected void btnRegistrarAfiliado_Click(object sender, EventArgs e)
        {
            WSAfiliado.AfiliadoClient proxyAfiliado = new WSAfiliado.AfiliadoClient();

            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apepaterno = txtApeMaterno.Text;
            string apematerno = txtApeMaterno.Text;
            string direccion = txtDireccion.Text;
            DateTime fechaNacimiento = CaFechaNacimiento.SelectedDate;
            int estado = Convert.ToInt32(rdbLstEstado.SelectedValue);

            try
            {
                //Validando si el DNI ya existe
                string resultadovalidacion =proxyAfiliado.ValidarDNIExistente(dni);
                if (resultadovalidacion.Equals("SI"))
                {
                    lblMensaje.Text = "El DNI ya ha sido registrado.!";
                    lblMensaje.Visible = true;
                    return;
                }
                //Grabo el afiliado en la Base De Datos
                WSAfiliado.Afiliado afi = proxyAfiliado.CrearAfiliado(dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);
                //Limpio los Controles
                LimpiarControles();
                //Listo todos los afiliados en la grila incluyendo el nuevo registro.
                ListarTodosAfiliados();
            }
            catch(Exception ex)
            {
                
            }
            
        }

        private void ListarTodosAfiliados()
        {
            WSAfiliado.AfiliadoClient proxyAfiliado = new WSAfiliado.AfiliadoClient();

            List<WSAfiliado.Afiliado> LstAfiliado = proxyAfiliado.ListarAfiliado().ToList();
            GvAfiliados.DataSource = LstAfiliado;
            GvAfiliados.DataBind();
        }

        private void LimpiarControles()
        {
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApePaterno.Text = string.Empty;
            txtApeMaterno.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            rdbLstEstado.SelectedValue = "1";
            lblMensaje.Visible = false;
        }

        protected void GvAfiliados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDNI.Enabled = false;

            WSAfiliado.AfiliadoClient proxyAfiliado = new WSAfiliado.AfiliadoClient();

            int IdAfiliado = Convert.ToInt32(GvAfiliados.SelectedRow.Cells[1].Text);
            WSAfiliado.Afiliado Afiliado = proxyAfiliado.ObtenerAfiliado(IdAfiliado);

            Session["IdAfiliado"] = IdAfiliado;
            txtDNI.Text = Afiliado.DNI;
            txtNombre.Text = Afiliado.Nombre;
            txtApePaterno.Text = Afiliado.ApePaterno;
            txtApeMaterno.Text = Afiliado.ApeMaterno;
            txtDireccion.Text = Afiliado.Direccion;
            rdbLstEstado.SelectedValue = Afiliado.Estado.ToString();
            CaFechaNacimiento.SelectedDate = Afiliado.FechaNacimiento;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Enabled = true;
            LimpiarControles();
        }

        protected void BtnActualizarAfiliado_Click(object sender, EventArgs e)
        {
            WSAfiliado.AfiliadoClient proxyAfiliado = new WSAfiliado.AfiliadoClient();

            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apepaterno = txtApeMaterno.Text;
            string apematerno = txtApeMaterno.Text;
            string direccion = txtDireccion.Text;
            DateTime fechaNacimiento = CaFechaNacimiento.SelectedDate;
            int estado = Convert.ToInt32(rdbLstEstado.SelectedValue);
            txtDNI.Enabled = true;
            try
            {
                if (Session["IdAfiliado"] != null)
                {
                    //Actualizo el afiliado en la Base De Datos
                    WSAfiliado.Afiliado afi = proxyAfiliado.ModificarAfiliado(Convert.ToInt32(Session["IdAfiliado"]), dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);
                    //Limpio los Controles
                    LimpiarControles();
                    //Listo todos los afiliados en la grila incluyendo el nuevo registro.
                    ListarTodosAfiliados();
                }
            }
            catch (Exception ex)
            {

            }
        }
        
        protected void btnCamcelarRegistro_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        protected void GvAfiliados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
                var IdAfiliado = Convert.ToInt32(GvAfiliados.DataKeys[e.RowIndex].Values[0].ToString());
                WSAfiliado.AfiliadoClient proxyAfiliado = new WSAfiliado.AfiliadoClient();

                proxyAfiliado.EliminarAfiliado(IdAfiliado);
                ListarTodosAfiliados();
                LimpiarControles();
        }

        protected void btnBuscarAfiliado_Click(object sender, EventArgs e)
        {

        }

    }
}