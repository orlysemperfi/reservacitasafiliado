using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RESTServices.Dominio;
using RESTServices.Persistencia;

namespace RESTServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "HistorialReservasService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione HistorialReservasService.svc o HistorialReservasService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class HistorialReservasService : IHistorialReservasService
    {
        private HistorialReservasDAO dao = new HistorialReservasDAO();

        public List<HistorialReservas> ListarHistorial()
        {
            
            return dao.ListarTodos();
        }
    }
}
