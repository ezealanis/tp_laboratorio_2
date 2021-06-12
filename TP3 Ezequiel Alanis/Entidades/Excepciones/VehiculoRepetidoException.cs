using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class VehiculoRepetidoException : Exception
    {
        public VehiculoRepetidoException() : base("El vehiculo ya se encuentra en la lista")
        {

        }

        public VehiculoRepetidoException(string mensaje) : base(mensaje)
        {

        }

        public VehiculoRepetidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
