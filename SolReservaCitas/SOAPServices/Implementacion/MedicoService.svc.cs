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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MedicoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MedicoService.svc o MedicoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MedicoService : IMedicoService
    {
        private MedicoDAO medicoDAO = null;
        private MedicoDAO MedicoDAO
        {
            get
            {
                if (medicoDAO == null)
                    medicoDAO = new MedicoDAO();
                return medicoDAO;

            }
        }

        public Medico CrearMedico(int idMedico, string nombre, string apaterno, string amaterno)
        {
            return null;
        }

        public Medico ObtenerMedico(int idMedico)
        {
            return MedicoDAO.Obtener(idMedico);
        }

        public Medico ModificarMedico(int idMedico, string nombre, string apaterno, string amaterno)
        {
            return null;
        }

        public void EliminarMedico(int idMedico)
        {
            throw new NotImplementedException();
        }

        public List<Medico> ListarMedicos()
        {
            return MedicoDAO.ListarTodos().ToList();
        }
    }
}
