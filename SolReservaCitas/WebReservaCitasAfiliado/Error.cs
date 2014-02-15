using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebReservaCitasAfiliado
{
    [DataContract]
    public class Error
    {
        [DataMember]
        public string CodigoNegocio { get; set; }
        [DataMember]
        public string MensajeNegocio { get; set; }
    }
}