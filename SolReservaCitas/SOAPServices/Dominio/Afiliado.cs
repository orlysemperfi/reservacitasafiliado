using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Afiliado
    {
        [DataMember]
        public int IdAfiliado { get; set; }
        [DataMember]
        public string DNI { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string ApePaterno { get; set; }
        [DataMember]
        public string ApeMaterno { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }
        [DataMember]
        public int Estado { get; set; }
    }
}