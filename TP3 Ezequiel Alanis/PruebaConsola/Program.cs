using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Archivos;
using Entidades.Excepciones;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREO FABRICAS, AUTOS Y MOTOS
            Auto auto0 = new Auto();
            Auto auto1 = new Auto(Puertas.CuatroPuertas, TipoMotor.Mediano, "SVB 319", Color.Blanco);
            Moto moto = new Moto(ModeloMoto.Enduro, TipoMotor.Grande, "SLG 923", Color.Negro);
            Moto aux = new Moto();
            Fabrica miFabrica = new Fabrica("Fabrica");
            Fabrica auxFab = new Fabrica();

            //AGREGO DOS AUTOS IGUALES PARA PROBAR LA EXCEPCION
            try
            {
                miFabrica.ListaVehiculos += auto0;
                miFabrica.ListaVehiculos += auto0;
            }
            catch (VehiculoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }

            miFabrica.ListaVehiculos.Clear();

            Console.ReadKey();
            Console.Clear();

            //AGREGO LOS AUTOS Y LAS MOTOS A LA FABRICA
            miFabrica.ListaVehiculos += auto0;
            miFabrica.ListaVehiculos += auto1;
            miFabrica.ListaVehiculos += moto;
          
            //SE GUARDA UNA MOTO EN UN ARCHIVO DE TEXTO, SE LEE ESE MISMO ARCHIVO Y SE MUESTRA EN PANTALLA
            ArchivoTexto texto = new ArchivoTexto();
            Console.WriteLine("Guardo la moto en un archivo de texto y lo leo desde el mismo archivo.");

            texto.GuardarArchivo("Prueba.txt", moto.MostrarDatos()); // Creo archivo de texto
            Console.WriteLine(texto.LeerArchivo("Prueba.txt")); // Leo archivo de texto y lo muestro

            Console.ReadKey();
            Console.Clear();

            //SERIALIZA LA FABRICA
            Console.WriteLine("Guardo la fabrica en un archivo xml, lo leo desde el mismo archivo y lo asigno en otro objeto. Despues muestro los autos que tiene cargados");

            ArchivoXml<Fabrica> xml = new ArchivoXml<Fabrica>();
            xml.GuardarArchivo("PruebaXML.xml", miFabrica); // Serializo la fabrica completa
            auxFab = xml.LeerArchivo("PruebaXML.xml"); // Cargo la serializacion en la fabrica auxiliar

            Console.WriteLine(auxFab.ListaVehiculos[0].MostrarDatos());
            Console.WriteLine(auxFab.ListaVehiculos[1].MostrarDatos());
            Console.WriteLine(auxFab.ListaVehiculos[2].MostrarDatos());

            Console.WriteLine("\n\nMuestro el detalle del ensamble de un vehiculo.");

            Console.WriteLine(auxFab.ListaVehiculos[2].DetalleDeEnsamblado());


            Console.ReadKey();
            Console.Clear();
        }
    }
}
