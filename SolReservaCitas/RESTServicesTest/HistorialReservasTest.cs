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
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:5001/Implementacion/HistorialReservasService.svc/Historial");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string clienteJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js2 = new JavaScriptSerializer();

            IList<HistorialReservas> Lista = js2.Deserialize<IList<HistorialReservas>>(clienteJson2);
            ICollection<HistorialReservas> modelo = Lista;

            int numero = modelo.Count;
            Assert.AreEqual(numero, 2);
            Assert.IsNotNull(Lista);

        }

    }
    }
