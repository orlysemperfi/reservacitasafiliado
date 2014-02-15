using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Persistencia;
using SOAPServices.Dominio;

namespace SOAPServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CentroService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CentroService.svc o CentroService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CentroService : ICentroService
    {
        private CentroDAO centroDAO = null;
        private CentroDAO CentroDAO
        {
            get
            {
                if (centroDAO == null)
                    centroDAO = new CentroDAO();
                return centroDAO;

            }
        }

        public Centro CrearCentro(int idCentro, string descripcion, string direccion)
        {
            return null;
        }

        public Centro ObtenerCentro(int idCentro)
        {
            return CentroDAO.Obtener(idCentro);
        }

        public Centro ModificarCentro(int idCentro, string descripcion, string direccion)
        {
            return null;
        }

        public void EliminarCentro(int idCentro)
        {
            throw new NotImplementedException();
        }

        public List<Centro> ListarCentros()
        {
            
            return CentroDAO.ListarTodos().ToList();
        }
    }
}
