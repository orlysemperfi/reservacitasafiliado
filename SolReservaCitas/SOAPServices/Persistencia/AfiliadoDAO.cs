using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SOAPServices.Dominio;
using System.Data;
using System.Data.SqlClient;

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
    }
}