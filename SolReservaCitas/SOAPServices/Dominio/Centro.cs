using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class Centro
    {

        [DataMember]
        public int IdCentroAtencion { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string Direccion { get; set; }
    }
}