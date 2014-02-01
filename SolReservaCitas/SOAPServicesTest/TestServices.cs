using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            string dni = "44634946";
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
            AfiliadoProxy.AfiliadoClient afiliadoProxy = new AfiliadoProxy.AfiliadoClient();
            int idAfiliado = 3;
            string dni = "44634946";
            string nombre = "Carlos";
            string apepaterno = "Llanos";
            string apematerno = "Rosero";
            string direccion = "Lima";
            DateTime fechaNacimiento = DateTime.Now;
            int estado = 1;


            AfiliadoProxy.Afiliado afi = afiliadoProxy.ModificarAfiliado(idAfiliado,dni, nombre, apepaterno, apematerno, direccion, fechaNacimiento, estado);


            Assert.IsNotNull(afi);
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

            string dni = "44634947";
            string resultadovalidacion = afiliadoProxy.ValidarDNIExistente(dni);


            Assert.AreEqual("SI",resultadovalidacion);
        }
    }
}
