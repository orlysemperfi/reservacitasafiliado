using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;
using SOAPServices.Interface;
using SOAPServices.Persistencia;
namespace SOAPServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ConsultorioService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ConsultorioService.svc o ConsultorioService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ConsultorioService : IConsultorioService
    {
        private ConsultorioDAO consultorioDAO = null;
        private ConsultorioDAO ConsultorioDAO
        {
            get
            {
                if (consultorioDAO == null)
                    consultorioDAO = new ConsultorioDAO();
                return consultorioDAO;

            }
        }

        public Consultorio CrearConsultorio(int idConsultorio, int idCentro, string nroConsultorio, string descripcion, int estado)
        {
            return null;
        }

        public Consultorio ObtenerConsultorio(int idConsultorio)
        {
            return ConsultorioDAO.Obtener(idConsultorio);
        }

        public Consultorio ModificarConsultorio(int idConsultorio, int idCentro, string nroConsultorio, string descripcion, int estado)
        {
            return null;
        }

        public void EliminarConsultorio(int idConsultorio)
        {
            throw new NotImplementedException();
        }

        public List<Consultorio> ListarConsultorios()
        {
            return ConsultorioDAO.ListarTodos().ToList();
        }

        public List<Consultorio> ListarPorCentro(int idCentro)
        {
            return ConsultorioDAO.ListarPorCentro(idCentro).ToList();
        }
    }
}
