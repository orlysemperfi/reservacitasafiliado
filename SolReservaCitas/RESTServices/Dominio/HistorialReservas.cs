using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RESTServices.Dominio
{
    [DataContract]
    public class HistorialReservas
    {
        [DataMember]
        public int IdReservaCita { get; set; }
        [DataMember]
        public int IdAfiliado { get; set; }
        [DataMember]
        public String NombreAfiliado { get; set; }
        [DataMember]
        public int IdCentroAtencion { get; set; }
        [DataMember]
        public String DescripcionCentro { get; set; }
        [DataMember]
        public int IdMedico { get; set; }
        [DataMember]
        public String NombreMedico { get; set; }
        [DataMember]
        public int IdConsultorio { get; set; }
        [DataMember]
        public String DescripcionConsultorio { get; set; }
        [DataMember]
        public DateTime FechaAsignada { get; set; }
        [DataMember]
        public string Observacion { get; set; }
        [DataMember]
        public int Estado { get; set; }
    }
}