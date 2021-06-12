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
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Moto))]
    public abstract class Vehiculo
    {
        protected string patente;
        protected TipoMotor tipoMotor;
        protected Color color;
        protected PartesEnsamble ensamblado;

        #region Propiedades

        public TipoMotor TipoMotor
        {
            get { return this.tipoMotor; }
            set { this.tipoMotor = value; }
        }
        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Patente
        {
            get { return this.patente; }
            set { this.patente = value; }
        }

        public PartesEnsamble Ensamblado
        {
            get { return this.ensamblado; }
            set { this.ensamblado = value; }
        }

        #endregion

        #region Constructores

        protected Vehiculo()
        {
            this.ensamblado = new PartesEnsamble();
        }

        public Vehiculo(TipoMotor tipoMotor, string patente, Color color) : this()
        {
            this.tipoMotor = tipoMotor;
            this.patente = patente;
            this.color = color;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Crea la patente para el vehiculo con 3 letras y 3 numeros al azar.
        /// </summary>
        /// <returns></returns>
        public static string CrearPatente()
        {
            Random random = new Random();
            StringBuilder patente = new StringBuilder();
            char letra;

            for (int i = 0; i < 3; i++)
            {
                letra = Convert.ToChar(random.Next(65, 90));
                patente.Append(letra);
            }

            patente.Append(" ");

            for (int i = 0; i < 3; i++)
            {
                patente.Append(random.Next(0, 9));
            }

            return patente.ToString();
        }

        /// <summary>
        /// Valida que se haya recibido una patente para el vehiculo
        /// </summary>
        /// <param name="patente"></param>
        public static void ValidarPatente(string patente)
        {
            if (string.IsNullOrEmpty(patente))
            {
                throw new ValidarPatenteException();
            }
        }

        /// <summary>
        /// Muestra los datos del vehiculo. Se sobrecarga en la clase hija para agregar mas datos.
        /// </summary>
        /// <returns></returns>
        public virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Patente: {this.Patente}");
            datos.AppendLine($"Tipo de motor: {this.TipoMotor.ToString()}");
            datos.Append($"Color: {this.Color.ToString()}");

            return datos.ToString();
        }

        /// <summary>
        /// Verifica si el vehiculo esta en la lista de vehiculos.
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator ==(List<Vehiculo> lista, Vehiculo vehiculo)
        {
            foreach (Vehiculo item in lista)
            {
                if (item.Patente == vehiculo.Patente)
                {
                    throw new VehiculoRepetidoException();
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si el vehiculo no se encuentra en la lista.
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator !=(List<Vehiculo> lista, Vehiculo vehiculo)
        {
            try
            {
                return !(lista == vehiculo);
            }
            catch (Exception)
            {
                throw new VehiculoRepetidoException();
            }
        }

        /// <summary>
        /// Verifica si el vehiculo no esta en la lista y lo agrega.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static List<Vehiculo> operator +(List<Vehiculo> lista, Vehiculo vehiculo)
        {
            try
            {
                if (lista != vehiculo)
                {
                    lista.Add(vehiculo);
                }

                return lista;
            }
            catch(Exception)
            {
                throw new VehiculoRepetidoException();
            }
        }

        /// <summary>
        /// Devuelve toda la informacion de si la partes del vehiculo estan ensambladas.
        /// </summary>
        /// <returns></returns>
        public string DetalleDeEnsamblado()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("Detalle de ensamble:\n");

            if (this.Ensamblado.Ruedas == true)
            {
                datos.AppendLine($"Ruedas: Listas");
            }
            else
            {
                datos.AppendLine($"Ruedas: Sin ensamblar");
            }

            if (this.GetType() != typeof(Moto))
            {
                if (this.Ensamblado.Puertas == true)
                {
                    datos.AppendLine($"Puertas: Listas");
                }
                else
                {
                    datos.AppendLine($"Puertas: Sin ensamblar");
                }
            }

            if (this.Ensamblado.Motor == true)
            {
                datos.AppendLine($"Motor: Listo");
            }
            else
            {
                datos.AppendLine($"Motor: Sin ensamblar");
            }

            if (this.Ensamblado.Pintura == true)
            {
                datos.AppendLine($"Pintura: Pintado");
            }
            else
            {
                datos.AppendLine($"Pintura: Sin pintar");
            }

            return datos.ToString();
        }

        #endregion

    }
}
