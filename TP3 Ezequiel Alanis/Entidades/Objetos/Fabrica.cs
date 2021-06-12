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
    public class Fabrica
    {
        #region Atributos

        private string nombreFabrica;
        private List<Vehiculo> listaVehiculos;
        private List<Vehiculo> listaVehiculosTerminados;
        private int stockRuedas;
        private int stockPuertas;
        private int stockPintura;
        private int stockMotor;

        #endregion

        #region Propiedades

        public string NombreFabrica
        {
            get { return this.nombreFabrica; }
            set { this.nombreFabrica = value; }
        }

        public List<Vehiculo> ListaVehiculos
        {
            get { return this.listaVehiculos; }
            set { this.listaVehiculos = value; }
        }

        public List<Vehiculo> ListaVehiculosTerminados
        {
            get { return this.listaVehiculosTerminados; }
            set { this.listaVehiculosTerminados = value; }
        }

        public int StockRuedas
        {
            get { return this.stockRuedas; }
            set { this.stockRuedas = value; }
        }

        public int StockPuertas
        {
            get { return this.stockPuertas; }
            set { this.stockPuertas = value; }
        }

        public int StockPintura
        {
            get { return this.stockPintura; }
            set { this.stockPintura = value; }
        }

        public int StockMotor
        {
            get { return this.stockMotor; }
            set { this.stockMotor = value; }
        }

        #endregion

        #region Constructores

        public Fabrica()
        {
            this.listaVehiculos = new List<Vehiculo>();
            this.listaVehiculosTerminados = new List<Vehiculo>();
        }

        public Fabrica(string nombreFabrica, int stockRuedas, int stockPuertas, int stockPintura, int stockMotor) : this()
        {
            this.nombreFabrica = nombreFabrica;
            this.stockRuedas = stockRuedas;
            this.stockPuertas = stockPuertas;
            this.stockPintura = stockPintura;
            this.stockMotor = stockMotor;
        }

        public Fabrica(string nombre) : this(nombre, 0, 0, 0, 0)
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Recibe un vehiculo y segun sea auto o moto, devuelve si hay stock de ruedas
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public bool StockRuedasDisponible(Vehiculo vehiculo)
        {
            if ((vehiculo is Moto && this.stockRuedas < 2) || (vehiculo is Auto && this.stockRuedas < 4))
            {
                throw new StockNoDisponibleExcepcion();
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Recibe un vehiculo y devuelve si hay stock para agregarle puertas. Caso contrario arroja una excepcion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public bool StockPuertasDisponible(Auto vehiculo)
        {
            if ((this.stockPuertas < 2 && vehiculo.Puertas == Puertas.DosPuertas) || (this.StockPuertas < 4 && vehiculo.Puertas == Puertas.CuatroPuertas))
            {
                throw new StockNoDisponibleExcepcion();
            }

            return true;
        }

        /// <summary>
        /// Recibe un vehiculo y devuelve si hay stock para asigar el motor, caso contrario arroja una excepcion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public bool StockMotorDisponible()
        {
            if (this.StockMotor < 1)
            {
                throw new StockNoDisponibleExcepcion();
            }

            return true;
        }

        /// <summary>
        /// Reecibe un vehiculo y devuelve si hay stock para para pintar, caso contrario arroja una excepcion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public bool StockPinturaDisponible()
        {
            if (this.StockPintura < 1)
            {
                throw new StockNoDisponibleExcepcion("No hay stock de pintura para el vehiculo");
            }

            return true;
        }

        #endregion
    }
}
