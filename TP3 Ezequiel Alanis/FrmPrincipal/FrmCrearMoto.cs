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
using Entidades.Excepciones;

namespace FrmPrincipal
{
    public partial class FrmCrearMoto : Form
    {
        Fabrica auxFabrica;
        Moto auxMoto;

        public FrmCrearMoto(Fabrica miFabrica)
        {
            InitializeComponent();
            auxFabrica = miFabrica;
            auxMoto = new Moto();
        }

        private void FrmCrearMoto_Load(object sender, EventArgs e)
        {
            this.txtGenerarPatente.Enabled = false;
            this.txtCantidadRuedas.Enabled = false;
            this.txtCantidadRuedas.Text = Moto.CantidadRuedas.ToString();
            this.cboModeloMoto.DataSource = Enum.GetValues(typeof(ModeloMoto));
            this.cboTipoMotor.DataSource = Enum.GetValues(typeof(TipoMotor));
            this.cboColor.DataSource = Enum.GetValues(typeof(Color));
        }

        /// <summary>
        /// Crea la patente para el vehiculo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarPatente_Click(object sender, EventArgs e)
        {
            this.txtGenerarPatente.Text = Vehiculo.CrearPatente();
        }

        /// <summary>
        /// Valida que todo este bien y genera el vehiculo nuevo.
        /// Captura las excepciones generadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Auto.ValidarPatente(this.txtGenerarPatente.Text);
                auxMoto.Patente = this.txtGenerarPatente.Text;
                auxMoto.Modelo = (ModeloMoto)this.cboModeloMoto.SelectedItem;
                auxMoto.TipoMotor = (TipoMotor)this.cboTipoMotor.SelectedItem;
                auxMoto.Color = (Color)this.cboColor.SelectedItem;
                auxMoto.Ensamblado.Puertas = true;

                this.auxFabrica.ListaVehiculos += this.auxMoto;
                this.Close();
            }
            catch (ValidarPatenteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error al seleccionar las opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
