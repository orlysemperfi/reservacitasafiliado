using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReservaCitaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReservaCitaService
    {

        [OperationContract]
        [FaultContract(typeof(string))]
        ReservaCita CrearReservaCita(string dni, int idCentro, int idMedico, int idConsultorio,DateTime fechaAsignacion, string observacion, int estado);

        [OperationContract]
        ReservaCita ObtenerReservaCita(int idReserva);

        [OperationContract]
        ReservaCita ModificarReservaCita(int idReserva, int idAfiliado, int idCentro, int idMedico, int idConsultorio, DateTime fechaAsignacion, string observacion, int estado);

        [OperationContract]
        void EliminarReservaCita(int idReserva);

        [OperationContract]
        List<ReservaCita> ListarReservaCita();
    }
}
