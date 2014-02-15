using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Medico
    {
        [DataMember]
        public int IdMedico { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string APaterno { get; set; }
        [DataMember]
        public string AMaterno {get; set; }

    }
}