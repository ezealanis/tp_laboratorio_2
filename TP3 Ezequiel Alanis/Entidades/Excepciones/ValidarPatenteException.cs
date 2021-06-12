using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ValidarPatenteException : Exception
    {
        public ValidarPatenteException() : base("Debe generar una patente para el vehiculo")
        {

        }

        public ValidarPatenteException(string mensaje) : base(mensaje)
        {

        }

        public ValidarPatenteException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
