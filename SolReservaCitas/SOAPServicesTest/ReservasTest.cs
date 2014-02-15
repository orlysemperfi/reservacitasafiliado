using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;

namespace SOAPServicesTest
{
  
    [TestClass]
    public class ReservasTest
    {
        [TestMethod]
        public void CrearReservaTest()
        {
            try
            {

                ReservaProxy.ReservaCitaServiceClient reservaProxy = new ReservaProxy.ReservaCitaServiceClient();
                string dni = "09392642";
                int idCentro= 1;
                int idMedico = 1;
                int idConsultorio = 1;
                string observacion= "Prueba";
                DateTime fechaAsignada =Convert.ToDateTime("2013-01-10");
                int estado = 0;



                ReservaProxy.ReservaCita res = reservaProxy.CrearReservaCita(dni,idCentro,idMedico,idConsultorio,fechaAsignada,observacion,estado);


                Assert.IsNotNull(res);
            }
               catch(FaultException ex)
            {
                Assert.AreEqual("Afiliado No está Registrado en el sistema.", ex.Message);

            }
        



        }
    }
}
