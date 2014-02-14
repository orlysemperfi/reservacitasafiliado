using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace RESTServicesTest
{
    [TestClass]
    public class HistorialReservasTest
    {

        [TestMethod]
        public void TestListar()
        {
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:5001/Implementacion/HistorialReservasService.svc/Historias/09392641");
            req2.Method = "GET";         
            HttpWebResponse res2= null;
            try
            {
                res2 = (HttpWebResponse)req2.GetResponse();
                StreamReader reader2 = new StreamReader(res2.GetResponseStream());
                string clienteJson2 = reader2.ReadToEnd();
                JavaScriptSerializer js2 = new JavaScriptSerializer();

                IList<HistorialReservas> Lista = js2.Deserialize<IList<HistorialReservas>>(clienteJson2);
                ICollection<HistorialReservas> modelo = Lista;
                int numero = modelo.Count;

                Assert.AreEqual(2, numero);
                Assert.IsNotNull(Lista);
            }
            catch (WebException e)
            {
                HttpWebResponse res1Error = (HttpWebResponse)e.Response;
                StreamReader reader3 = new StreamReader(res1Error.GetResponseStream());
                string error2 = reader3.ReadToEnd();
                JavaScriptSerializer js3 = new JavaScriptSerializer();
                string errorMessage = js3.Deserialize<string>(error2);
                Assert.AreEqual("No existen reservas para el rango de fechas consultado.", errorMessage);

            }

        }

    }
    }
