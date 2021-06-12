using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public interface IArchivos<T>
    {
        /// <summary>
        /// Guarda en un archivo el dato recibido
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="datos"></param>
        void GuardarArchivo(string nombreArchivo, T datos);
        
        /// <summary>
        /// Lee un un archivo y devuelve lo leido.
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        T LeerArchivo(string nombreArchivo);
    }
}
