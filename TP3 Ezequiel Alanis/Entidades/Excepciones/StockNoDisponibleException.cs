using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class StockNoDisponibleExcepcion : Exception
    {
        public StockNoDisponibleExcepcion() : base("No hay stock para ensamblar esta parte")
        {

        }

        public StockNoDisponibleExcepcion(string mensaje) : base(mensaje)
        {

        }

        public StockNoDisponibleExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
