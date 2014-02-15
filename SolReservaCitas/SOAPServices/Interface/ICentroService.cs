using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICentroService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICentroService
    {

        [OperationContract]
        Centro CrearCentro(int idCentro, string descripcion, string direccion);

        [OperationContract]
        Centro ObtenerCentro(int idCentro);

        [OperationContract]
        Centro ModificarCentro(int idCentro, string descripcion, string direccion);

        [OperationContract]
        void EliminarCentro(int idCentro);

        [OperationContract]
        List<Centro> ListarCentros();
    }
}
