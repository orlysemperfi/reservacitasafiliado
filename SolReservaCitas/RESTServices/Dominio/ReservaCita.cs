using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTServices.Dominio
{
    public class ReservaCita
    {
      
        public int IdReservaCita { get; set; }
        public int IdAfiliado { get; set; }
        public int IdCentroAtencion { get; set; }
        public int IdMedico { get; set; }
        public int IdConsultorio { get; set; }
        public DateTime FechaAsignada { get; set; }
        public string Observacion { get; set; }
        public int Estado { get; set; }
        public string DNI { get; set; }
    }
}