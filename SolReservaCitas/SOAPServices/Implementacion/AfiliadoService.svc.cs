using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SOAPServices.Persistencia;
using SOAPServices.Dominio;
using SOAPServices.Interface;

namespace SOAPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class AfiliadoService : IAfiliado
    {
        private AfiliadoDAO afiliadoDAO = null;
        private AfiliadoDAO AfiliadoDAO
        {
            get
            {
                if (afiliadoDAO == null)
                    afiliadoDAO = new AfiliadoDAO();
                return afiliadoDAO;
               
            }
        }

        public Afiliado CrearAfiliado(string dni, string nombre, string apepaterno, string apematerno, string direccion, DateTime fechaNacimiento, int estado)
        {
            SOAPServices.Dominio.Afiliado afiliadoACrear = new SOAPServices.Dominio.Afiliado()
            {
                DNI = dni,
                Nombre = nombre,
                ApePaterno = apematerno,
                ApeMaterno = apematerno,
                Direccion = direccion,
                FechaNacimiento = fechaNacimiento,
                Estado = estado

            };

            return AfiliadoDAO.Crear(afiliadoACrear);
        }

        public Afiliado ObtenerAfiliado(int idAfiliado)
        {

            return AfiliadoDAO.Obtener(idAfiliado);
        }

        public Afiliado ModificarAfiliado(int idAfiliado, string dni, string nombre, string apepaterno, string apematerno, string direccion, DateTime fechaNacimiento, int estado)
        {
            SOAPServices.Dominio.Afiliado afiliadoACrear = new SOAPServices.Dominio.Afiliado()
            {
                IdAfiliado = idAfiliado,
                DNI = dni,
                Nombre = nombre,
                ApePaterno = apematerno,
                ApeMaterno = apematerno,
                Direccion = direccion,
                FechaNacimiento = fechaNacimiento,
                Estado = estado

            };

            return AfiliadoDAO.Modificar(afiliadoACrear);
        }

        public void EliminarAfiliado(int idAfiliado)
        {
            Afiliado afiliadoExistente = new Afiliado();
            afiliadoExistente = AfiliadoDAO.Obtener(idAfiliado);
            AfiliadoDAO.Eliminar(afiliadoExistente);
        }

        public List<Afiliado> ListarAfiliado()
        {
            Afiliado afiliadoExistente = new Afiliado();
            return AfiliadoDAO.ListarTodos().ToList();
        }
    }
}
