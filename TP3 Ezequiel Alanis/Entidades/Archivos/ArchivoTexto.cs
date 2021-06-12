using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class ArchivoTexto : IArchivos<string>
    {
        /// <summary>
        /// Crea un txt y guarda los datos recibidos, sobrescribe el archivo si ya existe
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="datos"></param>
        public void GuardarArchivo(string nombreArchivo, string datos)
        {
            try
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory;
                ruta += nombreArchivo;

                using (StreamWriter sw = new StreamWriter(ruta, false))
                {
                    sw.WriteLine($"Informacion del dia: {DateTime.Now.ToString("dd/MM/yyyy")}");
                    sw.WriteLine(datos);
                }
            }
            catch(Exception)
            {
                throw new Exception("Error al generar archivo.");
            }            
        }

        /// <summary>
        /// Lee un archivo de texto y devuelve su contenido como string
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        public string LeerArchivo(string nombreArchivo)
        {
            try
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory;
                ruta += nombreArchivo;
                StringBuilder retorno = new StringBuilder();

                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        retorno.AppendLine(linea);
                    }
                }

                return retorno.ToString();
            }
            catch (Exception)
            {
                throw new Exception("Error al leer el archivo.");
            }
            
        }
    }
}
