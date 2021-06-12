using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entidades.Excepciones;

namespace Entidades
{
    [Serializable]
    public class Auto : Vehiculo
    {
        #region Atributos

        private static int cantidadRuedas;
        private Puertas puertas;

        #endregion

        #region Propiedades

        public Puertas Puertas { get { return this.puertas; } set { this.puertas = value; } }
        public static int CantidadRuedas { get { return Auto.cantidadRuedas; } set { Auto.cantidadRuedas = value; } }

        #endregion

        #region Constructores

        static Auto()
        {
            Auto.cantidadRuedas = 4;
        }

        public Auto() : base()
        {

        }

        public Auto(Puertas puertas, TipoMotor tipoMotor, string patente, Color color) : base(tipoMotor, patente, color)
        {
            this.puertas = puertas;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra el tipo y su patente para la lista.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Tipo: Auto - Patente: {base.Patente}";
        }

        /// <summary>
        /// Toma los datos de la clase padre y le agrega los datos de esta clase para terminar mostrando toda la info.
        /// </summary>
        /// <returns></returns>
        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("\nAUTO : \n");
            datos.AppendLine($"{base.MostrarDatos()}");
            datos.AppendLine($"Puertas: {this.Puertas}");
            datos.Append($"Ruedas: {Auto.CantidadRuedas}");

            return datos.ToString();
        }

        #endregion
    }
}
