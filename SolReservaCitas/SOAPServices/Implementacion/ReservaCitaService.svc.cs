using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Persistencia;
using SOAPServices.Dominio;
using SOAPServices.Interface;
namespace SOAPServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ReservaCitaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ReservaCitaService.svc o ReservaCitaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ReservaCitaService : IReservaCitaService
    {

        private ReservaCitaDAO reservaDAO = null;
        private ReservaCitaDAO ReservaDAO
        {
            get
            {
                if ( reservaDAO == null)
                    reservaDAO = new ReservaCitaDAO();
                return reservaDAO;

            }
        }

        public ReservaCita CrearReservaCita(int idReserva, int idAfiliado, int idCentro, int idMedico, int idConsultorio, DateTime fechaAsignacion, string observacion, int estado)
        {
            return null;
        }

        public ReservaCita ObtenerReservaCita(int idReserva)
        {
             return ReservaDAO.Obtener(idReserva);

        }

        public ReservaCita ModificarReservaCita(int idReserva, int idAfiliado, int idCentro, int idMedico, int idConsultorio, DateTime fechaAsignacion, string observacion, int estado)
        {
            return null;

        }

        public void EliminarReservaCita(int idReserva)
        {
            throw new NotImplementedException();
        }


        public List<ReservaCita> ListarReservaCita()
        {
            ReservaCita reservaExistente = new ReservaCita();
            return ReservaDAO.ListarTodos().ToList();
        }
    }
}
