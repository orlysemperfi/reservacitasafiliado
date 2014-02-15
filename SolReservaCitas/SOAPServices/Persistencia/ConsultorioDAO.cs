using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SOAPServices.Dominio;

namespace SOAPServices.Persistencia
{
    public class ConsultorioDAO:BaseDAO<Consultorio, int>
    {
            public List<Consultorio> ListarPorCentro(int idcentro)
        {
            List<Consultorio> Listado = new List<Consultorio>();
            string sql = "select * from Consultorio where IdCentroAtencion=@idcentro ";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idcentro", idcentro));
       
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            Consultorio consultorio = new Consultorio()
                            {
                                IdConsultorio= (int)resultado["IdConsultorio"],
                                IdCentroAtencion = (int)resultado["IdCentroAtencion"],
                                NroConsultorio = (string)resultado["NroConsultorio"],
                                Descripcion = (string)resultado["Descripcion"],
                                Estado = (int)resultado["Estado"]
                            };
                            Listado.Add(consultorio);
                        }
                    }
                }
            }

            return Listado;
        }
    }
    
}