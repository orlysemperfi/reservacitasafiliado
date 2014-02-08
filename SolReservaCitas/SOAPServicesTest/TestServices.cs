using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;

namespace SOAPServicesTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestServices
    {

        [TestMethod]
        public void TestCrear()
        {
            AfiliadoProxy.AfiliadoClient afiliadoProxy = new AfiliadoProxy.AfiliadoClient();
            string dni = "44634941";
            string nombre= "Fernando";
            string apepaterno = "Llanos";
            string apematerno = "Rosero";
            string direccion = "Lima";
            DateTime fechaNacimiento = DateTime.Now;
            int estado = 1;


            AfiliadoProxy.Afiliado afi = afiliadoProxy.CrearAfiliado(dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);


            Assert.IsNotNull(afi);
        }

        [TestMethod]
        public void TestObtener()
        {
            AfiliadoProxy.AfiliadoClient afiliadoProxy = new AfiliadoProxy.AfiliadoClient();
            int idAfiliado = 3;



            AfiliadoProxy.Afiliado afi = afiliadoProxy.ObtenerAfiliado(idAfiliado);


            Assert.IsNotNull(afi);
        }

        [TestMethod]
        public void TestModificar()
        {
            try
            {

                AfiliadoProxy.AfiliadoClient afiliadoProxy = new AfiliadoProxy.AfiliadoClient();
                int idAfiliado = 3;
                string dni = "44634946";
                string nombre = "Carlos";
                string apepaterno = "Llanos";
                string apematerno = "Rosero";
                string direccion = "Lima";
                DateTime fechaNacimiento = DateTime.Now;
                int estado = 1;


                AfiliadoProxy.Afiliado afi = afiliadoProxy.ModificarAfiliado(idAfiliado, dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);


                Assert.IsNotNull(afi);
            }
            catch (WebException e)
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader reader2 = new StreamReader(resError.GetResponseStream());
                string error = reader2.ReadToEnd();
                JavaScriptSerializer js2 = new JavaScriptSerializer();
                Error errorMessage = js2.Deserialize<Error>(error);
                Assert.AreEqual("Afiliado ya existe.", errorMessage.MensajeNegocio);


            }
        }

        [TestMethod]
        public void Testeliminar()
        {
            AfiliadoProxy.AfiliadoClient afiliadoProxy = new AfiliadoProxy.AfiliadoClient();
            int idAfiliado = 3;

            afiliadoProxy.EliminarAfiliado(idAfiliado);
            AfiliadoProxy.Afiliado afi = afiliadoProxy.ObtenerAfiliado(idAfiliado);

            Assert.IsNull(afi);
        }

        [TestMethod]
        public void TestListarTodos()
        {
            AfiliadoProxy.AfiliadoClient afiliadoProxy = new AfiliadoProxy.AfiliadoClient();

            List<AfiliadoProxy.Afiliado> LstAfiliado = afiliadoProxy.ListarAfiliado().ToList();


            Assert.IsNotNull(LstAfiliado);
        }

        [TestMethod]
        public void TestValidarDNIExistente()
        {
            AfiliadoProxy.AfiliadoClient afiliadoProxy = new AfiliadoProxy.AfiliadoClient();

            string dni = "44634946";
            string resultadovalidacion = afiliadoProxy.ValidarDNIExistente(dni);


            Assert.AreEqual("SI",resultadovalidacion);
        }
    }
}
