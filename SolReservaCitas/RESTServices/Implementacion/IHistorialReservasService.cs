using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RESTServices.Dominio;

namespace RESTServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IHistorialReservasService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IHistorialReservasService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Historias/{dni}", ResponseFormat = WebMessageFormat.Json)]
        List<HistorialReservas> ListarHistorial(string dni);
    }
}
