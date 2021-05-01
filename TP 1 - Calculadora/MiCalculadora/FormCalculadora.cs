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

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {            
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.txtNum1.Text = "";
            this.txtNum2.Text = "";
            this.cmbOperador.Text = null;
            this.lblResultado.Text = "";
            this.btnDecimal.Enabled = true;
            this.btnBinario.Enabled = true;
        }

        private static double Operar(string numero1, string numero2, string operador)
        {            
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador;

            if(this.cmbOperador.SelectedItem is null)
            {
                operador = "+";
            }
            else
            {
                operador = this.cmbOperador.SelectedItem.ToString();
            }

            this.lblResultado.Text = Operar(this.txtNum1.Text, this.txtNum2.Text, operador).ToString();
            this.btnDecimal.Enabled = false;
            this.btnBinario.Enabled = true;
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.DecimalBinario(this.lblResultado.Text);
            this.btnBinario.Enabled = false;
            this.btnDecimal.Enabled = true;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Numero.BinarioDecimal(this.lblResultado.Text);
            this.btnDecimal.Enabled = false;
            this.btnBinario.Enabled = true;
        }
    }
}
