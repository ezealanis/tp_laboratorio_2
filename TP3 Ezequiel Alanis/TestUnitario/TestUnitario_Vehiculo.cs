using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Excepciones;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario_Vehiculo
    {
        /// <summary>
        /// Testea que el metodo arroje la excepcion si recibe un parametro invalido.
        /// </summary>
        /// <param name="patente"></param>
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [ExpectedException(typeof(ValidarPatenteException))]
        public void ValidarPatenteExcepcion(string patente)
        {
            Vehiculo.ValidarPatente(patente);

            Assert.Fail();
        }

        /// <summary>
        /// Valida que devuelva el string para la cadena
        /// </summary>
        [TestMethod]
        public void CrearPatente()
        {
            string patente;

            patente = Vehiculo.CrearPatente();

            Assert.IsNotNull(patente);
        }

        /// <summary>
        /// Valida que arroje la excepcion si se agregan dos autos iguales.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(VehiculoRepetidoException))]
        public void VehiculoRepetidoExcepcion()
        {
            List<Vehiculo> lista = new List<Vehiculo>();
            Auto vehiculo = new Auto(Puertas.CuatroPuertas, TipoMotor.Grande, "SLF 213", Color.Negro);

            lista += vehiculo;
            lista += vehiculo;

            Assert.Fail();
        }
    }
}
