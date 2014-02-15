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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AfiliadoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AfiliadoService.svc o AfiliadoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AfiliadoService : IAfiliadoService
    {

        private AfiliadoDAO dao = new AfiliadoDAO();

        public Afiliado ObtenerAfiliado(string dni)
        {
            return dao.Obtener(dni);
        }
    }
}
