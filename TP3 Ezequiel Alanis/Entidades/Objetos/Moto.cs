using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Entidades.Excepciones;

namespace Entidades
{
    [Serializable]
    public class Moto : Vehiculo
    {
        private ModeloMoto modelo;
        private static int cantidadRuedas;

        #region Propiedades

        public ModeloMoto Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public static int CantidadRuedas
        {
            get { return Moto.cantidadRuedas; }
            set { Moto.cantidadRuedas = value; }
        }

        #endregion

        #region Constructores

        static Moto()
        {
            Moto.cantidadRuedas = 2;
        }

        public Moto() : base()
        {

        }

        public Moto(ModeloMoto modelo, TipoMotor tipoMotor, string patente, Color color) : base(tipoMotor, patente, color)
        {
            this.modelo = modelo;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra el tipo y su patente para la lista.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Tipo: Moto - Patente: {base.Patente}";
        }

        /// <summary>
        /// Toma los datos de la clase padre y le agrega los datos de esta clase para terminar mostrando toda la info.
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("\nMOTO : \n");
            datos.AppendLine($"{base.MostrarDatos()}");
            datos.AppendLine($"Tipo de moto: {this.Modelo}");
            datos.Append($"Ruedas: {Moto.CantidadRuedas}");

            return datos.ToString();
        }

        #endregion
    }
}
