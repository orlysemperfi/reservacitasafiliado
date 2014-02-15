using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IConsultorioService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IConsultorioService
    {

        [OperationContract]
        Consultorio CrearConsultorio(int idConsultorio,int idCentro, string nroConsultorio, string descripcion , int estado);

        [OperationContract]
        Consultorio ObtenerConsultorio(int idConsultorio);

        [OperationContract]
        Consultorio ModificarConsultorio(int idConsultorio, int idCentro, string nroConsultorio, string descripcion, int estado);

        [OperationContract]
        void EliminarConsultorio(int idConsultorio);

        [OperationContract]
        List<Consultorio> ListarConsultorios();

        [OperationContract]
        List<Consultorio> ListarPorCentro(int idCentro);
    }
}
