using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Persistencia;
using SOAPServices.Dominio;
using SOAPServices.Interface;
using System.Messaging;
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
        private AfiliadoDAO afiliadoDAO = null;
        private AfiliadoDAO AfiliadoDAO
        {
            get
            {
                if (afiliadoDAO == null)
                    afiliadoDAO = new AfiliadoDAO();
                return afiliadoDAO;

            }
        }
        public ReservaCita CrearReservaCita(string dni, int idCentro, int idMedico, int idConsultorio, DateTime fechaAsignada, string observacion, int estado)
        {
            ReservaCita reservaCreada = null;
            try
            {
           
                    Afiliado afiliadoABuscar = AfiliadoDAO.ObtenerAfiliadoPorDNI(dni);
                    ReservaCita reservaACrear = null;

                    if (afiliadoABuscar == null)
                    {
                        throw new FaultException("Afiliado No está Registrado en el sistema.");
                    }
                    else
                    {
                        reservaACrear = new ReservaCita()
                        {
                        IdAfiliado = afiliadoABuscar.IdAfiliado,
                        IdCentroAtencion = idCentro,
                        IdMedico = idMedico,
                        IdConsultorio = idConsultorio,
                        Observacion = observacion,
                        FechaAsignada = fechaAsignada,
                        Estado = estado
 
                         };
                    }
                    reservaCreada = ReservaDAO.Crear(reservaACrear);
            }
            catch
            {


            }
            return reservaCreada;
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

        public void RecuperarDeCola()
        {
            string rutaCola = @".\private$\Reservas";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);
            MessageQueue cola = new MessageQueue(rutaCola);
            cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(ReservaCita) });
            Message[] mensajesenCola = cola.GetAllMessages();

            foreach (Message msg in mensajesenCola)
            {
                Message mensaje = msg;
                mensaje = cola.Receive();
                ReservaCita reservaACrear = (ReservaCita)mensaje.Body;

                ReservaCita reserva = null;
                try
                {

                    reserva = new ReservaCita()
                    {
                        IdAfiliado = reservaACrear.IdAfiliado,
                        IdCentroAtencion = reservaACrear.IdCentroAtencion,
                        IdMedico = reservaACrear.IdMedico,
                        IdConsultorio = reservaACrear.IdConsultorio,
                        Observacion = reservaACrear.Observacion,
                        FechaAsignada = reservaACrear.FechaAsignada,
                        Estado = reservaACrear.Estado,
                        DNI=reservaACrear.DNI

                    };
                    ReservaCita res = CrearReservaCita(reserva.DNI,reserva.IdCentroAtencion,reserva.IdMedico,reserva.IdConsultorio,reserva.FechaAsignada,reserva.Observacion,reserva.Estado);

                }
                catch
                {
                }
            }




        }
    }
}
