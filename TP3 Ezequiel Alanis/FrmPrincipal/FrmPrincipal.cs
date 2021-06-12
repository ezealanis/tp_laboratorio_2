using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Archivos;
using Entidades.Excepciones;

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        Fabrica miFabrica = new Fabrica("Fabrica");

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarStock();
            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
        }

        /// <summary>
        /// Abre una instancia del form CrearAuto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            FrmCrearAuto formAuto = new FrmCrearAuto(this.miFabrica);
            formAuto.ShowDialog();
            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
        }

        /// <summary>
        /// Setea todos los atributos del stock en valores al azar entre 10 y 20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRenovarStock_Click(object sender, EventArgs e)
        {
            AumentarStock();
        }

        /// <summary>
        /// Actualiza la listBox con los autos que se agregan y los que se terminan pasan a la listaVehiculosTerminados
        /// </summary>
        private void ActualizarListaVehiculos<T>(List<Vehiculo> lista) where T : Vehiculo
        {
            this.lstVehiculos.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Ensamblado.VerificarEnsambleCompleto())
                {
                    this.miFabrica.ListaVehiculosTerminados.Add(lista[i]);
                    this.miFabrica.ListaVehiculos.Remove(lista[i]);
                    ActualizarListaVehiculosTerminados();
                }
            }

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] is T)
                {
                    this.lstVehiculos.Items.Add(lista[i]);
                    ActualizarStock();
                }
            }
        }

        /// <summary>
        /// Actualiza la lista de vehiculos terminados
        /// </summary>
        private void ActualizarListaVehiculosTerminados()
        {
            this.lstVehiculosTerminados.Items.Clear();

            for (int i = 0; i < this.miFabrica.ListaVehiculosTerminados.Count; i++)
            {
                this.lstVehiculosTerminados.Items.Add(this.miFabrica.ListaVehiculosTerminados[i]);
            }
        }

        /// <summary>
        /// Recorre la lista de vehiculos terminados y muestra toda la informacion en forma de texto
        /// </summary>
        private string InformeVehiculosTerminados()
        {
            StringBuilder info = new StringBuilder();

            foreach (Vehiculo item in this.miFabrica.ListaVehiculosTerminados)
            {
                info.AppendLine(item.MostrarDatos());
                info.AppendLine("-----------------------------------");
            }

            return info.ToString();
        }

        /// <summary>
        /// Actualiza las cantidades que tiene la fabrica en stock
        /// </summary>
        private void ActualizarStock()
        {
            this.lblCantVehiculo.Text = this.miFabrica.ListaVehiculos.Count.ToString();
            this.lblCantRuedas.Text = this.miFabrica.StockRuedas.ToString();
            this.lblCantPuertas.Text = this.miFabrica.StockPuertas.ToString();
            this.lblCantMotor.Text = this.miFabrica.StockMotor.ToString();
            this.lblCantPintura.Text = this.miFabrica.StockPintura.ToString();
        }

        /// <summary>
        /// Setea las variables de stock con un numero al azar entre 10 y 20
        /// </summary>
        private void AumentarStock()
        {
            Random random = new Random();

            this.miFabrica.StockRuedas = random.Next(10, 20);
            this.miFabrica.StockPuertas = random.Next(10, 20);
            this.miFabrica.StockMotor = random.Next(10, 20);
            this.miFabrica.StockPintura = random.Next(10, 20);

            ActualizarStock();
        }

        /// <summary>
        /// Verifica si el vehiculo tiene las ruedas ensambladas, si hay stock disponible y las agrega al vehiculo.
        /// Controla las excepciones lanzadas por los metodos que utiliza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarRuedas_Click(object sender, EventArgs e)
        {
            Vehiculo aux = (Vehiculo)this.lstVehiculos.SelectedItem;

            try
            {
                if (aux.Ensamblado.Ruedas != true && miFabrica.StockRuedasDisponible(aux))
                {
                    if (aux is Auto)
                    {
                        aux.Ensamblado.Ruedas = true;
                        this.miFabrica.StockRuedas -= 4;
                        ActualizarEstado();
                    }
                    else
                    {
                        aux.Ensamblado.Ruedas = true;
                        this.miFabrica.StockRuedas -= 2;
                        ActualizarEstado();
                    }
                }
                else
                {
                    MessageBox.Show("El vehiculo ya tiene ensambladas las ruedas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (StockNoDisponibleExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (NullReferenceException)
            {

            }

            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
            ActualizarStock();
        }

        /// <summary>
        /// Verifica si el vehiculo tiene las puertas ensambladas, si hay stock disponible y las agrega al vehiculo.
        /// Controla las excepciones lanzadas por los metodos que utiliza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarPuertas_Click(object sender, EventArgs e)
        {
            Vehiculo aux = (Vehiculo)this.lstVehiculos.SelectedItem;

            try
            {
                if (!(aux is Moto))
                {
                    if (aux.Ensamblado.Puertas == false && miFabrica.StockPuertasDisponible((Auto)aux))
                    {
                        if (((Auto)aux).Puertas == Puertas.CuatroPuertas)
                        {
                            aux.Ensamblado.Puertas = true;
                            this.miFabrica.StockPuertas -= 4;
                            ActualizarEstado();
                        }
                        else
                        {
                            aux.Ensamblado.Puertas = true;
                            this.miFabrica.StockPuertas -= 2;
                            ActualizarEstado();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El vehiculo ya tiene ensambladas las puertas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Imposible agregarle puertas a la moto, campeon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (StockNoDisponibleExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (NullReferenceException)
            {

            }

            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
            ActualizarStock();
        }

        /// <summary>
        /// Verifica si el vehiculo tiene el motor ensamblado, si hay stock disponible y lo agrega al vehiculo.
        /// Controla las excepciones lanzadas por los metodos que utiliza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColocarMotor_Click(object sender, EventArgs e)
        {
            Vehiculo aux = (Vehiculo)this.lstVehiculos.SelectedItem;

            try
            {
                if (aux.Ensamblado.Motor != true && miFabrica.StockMotorDisponible())
                {
                    aux.Ensamblado.Motor = true;
                    this.miFabrica.StockMotor -= 1;
                    ActualizarEstado();
                }
                else
                {
                    MessageBox.Show("El vehiculo ya tiene ensamblado el motor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (StockNoDisponibleExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (NullReferenceException)
            {

            }

            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
            ActualizarStock();
        }

        /// <summary>
        /// Verifica si el vehiculo esta pintado, si hay stock disponible y lo agrega al vehiculo.
        /// Controla las excepciones lanzadas por los metodos que utiliza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPintarVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo aux = (Vehiculo)this.lstVehiculos.SelectedItem;

            try
            {
                if (aux.Ensamblado.Pintura != true && this.miFabrica.StockPinturaDisponible())
                {
                    aux.Ensamblado.Pintura = true;
                    this.miFabrica.StockPintura -= 1;
                    ActualizarEstado();
                }
                else
                {
                    MessageBox.Show("El vehiculo ya esta pintado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (StockNoDisponibleExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (NullReferenceException)
            {

            }

            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
            ActualizarStock();
        }


        /// <summary>
        /// Muestra el detalle de ensable del vehiculo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEstado();
        }

        /// <summary>
        /// Muestra el detalle del ensamble en forma de texto.
        /// </summary>
        private void ActualizarEstado()
        {
            try
            {
                this.rtbInfoVehiculo.Text = ((Vehiculo)this.lstVehiculos.SelectedItem).DetalleDeEnsamblado();
            }
            catch (NullReferenceException)
            {
                this.rtbInfoVehiculo.Text = "Seleccione un vehiculo para ver la informacion.";
            }
        }

        /// <summary>
        /// Abre una instancia del form CrearMoto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarMoto_Click(object sender, EventArgs e)
        {
            FrmCrearMoto formMoto = new FrmCrearMoto(this.miFabrica);
            formMoto.ShowDialog();
            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
        }

        /// <summary>
        /// Elimina de la lista el vehiculo seleccioando.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            this.miFabrica.ListaVehiculos.Remove(((Vehiculo)this.lstVehiculos.SelectedItem));
            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
            ActualizarStock();
        }

        /// <summary>
        /// Muestra en la lista solamente las motos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarMotos_Click(object sender, EventArgs e)
        {
            ActualizarListaVehiculos<Moto>(this.miFabrica.ListaVehiculos);
        }

        /// <summary>
        /// Muestra en la lista solamente los autos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarAutos_Click(object sender, EventArgs e)
        {
            ActualizarListaVehiculos<Auto>(this.miFabrica.ListaVehiculos);
        }

        /// <summary>
        /// Muestra todos los vehiculos en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
        }

        /// <summary>
        /// Genera el archivo de texto de la lista de vehiculos terminados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarArchivoTexto_Click(object sender, EventArgs e)
        {
            try
            {
                this.Width = 1194;
                this.rtbVehiculosTerminados.ReadOnly = true;
                ArchivoTexto texto = new ArchivoTexto();
                texto.GuardarArchivo("InformeVehiculosTerminados.txt", InformeVehiculosTerminados());
                this.rtbVehiculosTerminados.Text = texto.LeerArchivo("InformeVehiculosTerminados.txt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Genera un archivo xml de la fabrica completa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                ArchivoXml<Fabrica> xml = new ArchivoXml<Fabrica>();
                xml.GuardarArchivo("FabricaSerializada.xml", this.miFabrica);
                MessageBox.Show("Archivo generado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga la fabrica desde el archivo xml generado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarSerializado_Click(object sender, EventArgs e)
        {
            try
            {
                ArchivoXml<Fabrica> xml = new ArchivoXml<Fabrica>();
                this.miFabrica = xml.LeerArchivo("FabricaSerializada.xml");
                ActualizarStock();
                ActualizarListaVehiculos<Vehiculo>(this.miFabrica.ListaVehiculos);
                ActualizarListaVehiculosTerminados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
