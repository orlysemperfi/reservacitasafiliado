using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.Messaging;
using SOAPServicesTest.ReservaProxy;

namespace SOAPServicesTest
{
  
    [TestClass]
    public class ReservasTest
    {
        [TestMethod]
        public void CrearReservaTest()
        {
            string dni = "09392641";
            int idAfiliado = 1;
            int idCentro = 1;
            int idMedico = 1;
            int idConsultorio = 1;
            string observacion = "Prueba";
            DateTime fechaAsignada = Convert.ToDateTime("2013-01-12");
            int estado = 0;
            try
            {

                ReservaProxy.ReservaCitaServiceClient reservaProxy = new ReservaProxy.ReservaCitaServiceClient();
             
                
                ReservaProxy.ReservaCita res = reservaProxy.CrearReservaCita(dni,idCentro,idMedico,idConsultorio,fechaAsignada,observacion,estado);


                Assert.IsNotNull(res);
            }
               catch(FaultException ex)
            {
                Assert.AreEqual("Afiliado No está Registrado en el sistema.", ex.Message);

            }
        
            finally
                {
                         //Graba en Cola
                string rutaCola = @".\private$\Reservas";
                if (MessageQueue.Exists(rutaCola) == false)
                    MessageQueue.Create(rutaCola);
                MessageQueue cola = new MessageQueue(rutaCola);
                Message mensaje = new Message();
                mensaje.Label = "Reserva";

                ReservaCita reservaCreada = new ReservaCita
                {
                    IdAfiliado = idAfiliado,
                    IdCentroAtencion = idCentro,
                    IdMedico = idMedico,
                    IdConsultorio = idConsultorio,
                    Observacion = observacion,
                    FechaAsignada = fechaAsignada,
                    Estado = estado,
                    DNI=dni

                };
                mensaje.Body = reservaCreada;
                cola.Send(mensaje);
                }



        }
    }
}
