using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades.Archivos
{
    public class ArchivoXml<T> : IArchivos<T> where T : new()
    {
        /// <summary>
        /// Serializa y guarda un tipo de dato recibido
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="dato"></param>
        public void GuardarArchivo(string nombreArchivo, T dato)
        {
            try
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory;
                ruta += nombreArchivo;

                using (XmlTextWriter escribir = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializar = new XmlSerializer((typeof(T)));
                    serializar.Serialize(escribir, dato);
                }
            }
            catch
            {
                throw new Exception("Error al serializar.");
            }
        }

        /// <summary>
        /// Deserializa un tipo de dato recibido y lo devuelve
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        public T LeerArchivo(string nombreArchivo)
        {
            try
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory;
                ruta += nombreArchivo;
                T aux = new T();

                using (XmlTextReader leer = new XmlTextReader(ruta))
                {
                    XmlSerializer deserializar = new XmlSerializer((typeof(T)));
                    aux = (T)deserializar.Deserialize(leer);
                }

                return aux;
            }
            catch
            {
                throw new Exception("Error al leer el archivo serializado.");
            }                       
        }
    }
}
