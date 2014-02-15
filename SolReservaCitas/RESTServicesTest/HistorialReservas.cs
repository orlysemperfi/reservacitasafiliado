using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTServicesTest
{
    class HistorialReservas
    {
        public int IdReservaCita { get; set; }
        public int IdAfiliado { get; set; }
        public String NombreAfiliado { get; set; }
        public int IdCentroAtencion { get; set; }
        public String DescripcionCentro { get; set; }
        public int IdMedico { get; set; }
        public String NombreMedico { get; set; }
        public int IdConsultorio { get; set; }
        public String DescripcionConsultorio { get; set; }
        public DateTime FechaAsignada { get; set; }
        public string Observacion { get; set; }
        public int Estado { get; set; }
        public string DNI { get; set; }
 
    }
}
