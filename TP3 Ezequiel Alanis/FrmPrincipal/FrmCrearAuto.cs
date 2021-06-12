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
    public partial class FrmCrearAuto : Form
    {
        Fabrica auxFabrica;
        Auto auxAuto;

        public FrmCrearAuto(Fabrica miFabrica)
        {
            InitializeComponent();
            auxFabrica = miFabrica;
            auxAuto = new Auto();
        }

        private void FrmCrearAuto_Load(object sender, EventArgs e)
        {
            this.txtGenerarPatente.Enabled = false;
            this.txtCantidadRuedas.Enabled = false;
            this.txtCantidadRuedas.Text = Auto.CantidadRuedas.ToString();
            this.cboPuertas.DataSource = Enum.GetValues(typeof(Puertas));
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
                auxAuto.Patente = this.txtGenerarPatente.Text;
                auxAuto.Puertas = (Puertas)this.cboPuertas.SelectedItem;
                auxAuto.TipoMotor = (TipoMotor)this.cboTipoMotor.SelectedItem;
                auxAuto.Color = (Color)this.cboColor.SelectedItem;

                this.auxFabrica.ListaVehiculos += this.auxAuto;
                this.Close();
            }
            catch(ValidarPatenteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Error al seleccionar las opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
