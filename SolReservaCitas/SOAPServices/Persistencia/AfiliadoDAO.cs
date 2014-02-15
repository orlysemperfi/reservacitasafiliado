using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using SOAPServices.Dominio;

namespace SOAPServices.Persistencia
{
    public class AfiliadoDAO:BaseDAO<Afiliado,int>
    {
        SqlConnection cn = new SqlConnection("Data Source=(local);Initial Catalog=BDCitas;Integrated Security=SSPI;");
        public string ValidarDNIExistente(string dni)
        {
            SqlDataAdapter da = new SqlDataAdapter("Usp_ValidadDNIExistente " + dni, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        public string ValidarDNIExistenteReniec(string dni)
        {
            SqlDataAdapter da = new SqlDataAdapter("Usp_ValidadDNIExistenteReniec " + dni, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        public DataSet ObtenerDatosReniec(string dni)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Reniec Where dni='" + dni + "'", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public Afiliado ObtenerAfiliadoPorDNI(string dni)
        {
            Afiliado afiliadoEncontrado = null;
            string sql = "SELECT * FROM Afiliado where DNI=@dni";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
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
                                Nombre = (string)resultado["Nombre"]
                            };

                        }

                    }
                }

            }
            return afiliadoEncontrado;
       
        }
        
    }
}