using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAPServices.Dominio
{
    [DataContract]
    public class ReservaCita
    {
        [DataMember]
        public int IdReservaCita { get; set; }
        [DataMember]
        public int IdAfiliado { get; set; }
        [DataMember]
        public int IdCentroAtencion { get; set; }
        [DataMember]
        public int IdMedico { get; set; }
        [DataMember]
        public int IdConsultorio { get; set; }
        [DataMember]
        public DateTime FechaAsignada { get; set; }
        [DataMember]
        public string Observacion { get; set; }
        [DataMember]
        public int Estado { get; set; }
        [DataMember]
        public string DNI { get; set; }
    }
}