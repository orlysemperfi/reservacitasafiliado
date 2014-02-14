using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using RESTServices.Dominio;

namespace RESTServices.Persistencia
{
    public class AfiliadoDAO
    {
        public Afiliado Obtener(string dni)
        {
            Afiliado afiliadoEncontrado = null;
            string sql = "SELECT * FROM Afiliado where DNI=@dni";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            afiliadoEncontrado = new Afiliado()
                            {
                                IdAfiliado = (int)resultado["IdAfiliado"],
                                DNI = (string)resultado["DNI"],
                                Nombre=(string)resultado["Nombre"]
                            };

                        }

                    }
                }

            }
            return afiliadoEncontrado;
        }

    }
}