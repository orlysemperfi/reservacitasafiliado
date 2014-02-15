using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Consultorio
    {
        [DataMember]
        public int IdConsultorio { get; set; }
        [DataMember]
        public int IdCentroAtencion { get; set; }
        [DataMember]
        public string NroConsultorio { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public int Estado { get; set; }
    }
}