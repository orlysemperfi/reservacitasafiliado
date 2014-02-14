using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Web;
using RESTServices.Dominio;

namespace RESTServices.Persistencia
{
    public class HistorialReservasDAO
    {
        public List<HistorialReservas> ListarTodos(string dni)
        {
            List<HistorialReservas> Listado = new List<HistorialReservas>();
            string sql = "select r.IdReservaCita,r.IdAfiliado,(a.Nombre+' ' +a.APaterno) as NombreAfiliado, "+
            "r.IdCentroAtencion,ca.Descripcion as DescripcionCentro,"+
            "r.IdMedico,(m.Nombre+' ' +m.APaterno) as NombreMedico, "+
            "r.IdConsultorio,c.Descripcion as DescripcionConsultorio, "+
            "r.FechaAsignada,r.Observacion,r.Estado "+
            "from ReservaCita r left outer join Afiliado a on a.IdAfiliado=r.IdAfiliado "+
            "left outer join CentroAtencion ca on ca.IdCentroAtencion=r.IdCentroAtencion "+ 
            "left outer join Medico m on m.IdMedico=r.IdMedico "+
            "left outer join Consultorio c on c.IdCentroAtencion=r.IdCentroAtencion and c.IdConsultorio=r.IdConsultorio"+
            " where a.DNI=@dni ";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@dni", dni));

                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            HistorialReservas historia= new HistorialReservas()
                            {
                                IdReservaCita=(int)resultado["IdReservaCita"],
                                IdAfiliado = (int)resultado["IdAfiliado"],
                                NombreAfiliado = (string)resultado["NombreAfiliado"],
                                IdCentroAtencion = (int)resultado["IdCentroAtencion"],
                                DescripcionCentro = (string)resultado["DescripcionCentro"],
                                IdMedico = (int)resultado["IdMedico"],
                                NombreMedico = (string)resultado["NombreMedico"],
                                IdConsultorio = (int)resultado["IdConsultorio"],
                                DescripcionConsultorio = (string)resultado["DescripcionConsultorio"],
                                FechaAsignada = (DateTime)resultado["FechaAsignada"],
                                Observacion = (string)resultado["Observacion"],
                                Estado = (int)resultado["Estado"]
                            };
                            Listado.Add(historia);
                        }
                    }
                }
            }
       
            return Listado;
        }

    }
}