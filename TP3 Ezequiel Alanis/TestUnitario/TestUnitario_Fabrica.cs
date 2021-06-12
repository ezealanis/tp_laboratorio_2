using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Excepciones;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario_Fabrica
    {
        private Fabrica fabrica = new Fabrica("Test", 10, 10, 0, 10);
        private Auto miAuto = new Auto(Puertas.CuatroPuertas, TipoMotor.Mediano, "SDF 123", Color.Negro);

        /// <summary>
        /// Testea que instancie correctamente la fabrica
        /// </summary>
        [TestMethod]
        public void InstanciarFabrica()
        {
            Fabrica miFabrica = new Fabrica("Fabrica");

            Assert.IsNotNull(miFabrica);
            Assert.AreEqual("Fabrica", miFabrica.NombreFabrica);
        }

        /// <summary>
        /// Testea que devuelta true si valida que hay motor en stock
        /// </summary>
        [TestMethod]
        public void StockMotorDisponible()
        {
            Auto vehiculo = new Auto();
            bool test = fabrica.StockMotorDisponible();

            Assert.IsTrue(test);
        }


        /// <summary>
        /// Testea que arroje la excepcion si no hay stock de pintura
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(StockNoDisponibleExcepcion))]
        public void StockNoDisponibleExcepcion()
        {
            Auto vehiculo = new Auto();
            bool test = fabrica.StockPinturaDisponible();

            Assert.Fail();
        }
    }
}
