using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;

namespace SOAPServices.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMedicoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMedicoService
    {

        [OperationContract]
        Medico CrearMedico(int idMedico, string nombre, string apaterno, string amaterno);

        [OperationContract]
        Medico ObtenerMedico(int idMedico);

        [OperationContract]
        Medico ModificarMedico(int idMedico, string nombre, string apaterno, string amaterno);

        [OperationContract]
        void EliminarMedico(int idMedico);

        [OperationContract]
        List<Medico> ListarMedicos();
    }
}
