
namespace FrmPrincipal
{
    partial class FrmCrearAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPuertas = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboTipoMotor = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCantidadRuedas = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblPuertas = new System.Windows.Forms.Label();
            this.lblRuedas = new System.Windows.Forms.Label();
            this.btnGenerarPatente = new System.Windows.Forms.Button();
            this.txtGenerarPatente = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gboCrearAuto = new System.Windows.Forms.GroupBox();
            this.gboCrearAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPuertas
            // 
            this.cboPuertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuertas.FormattingEnabled = true;
            this.cboPuertas.Location = new System.Drawing.Point(193, 81);
            this.cboPuertas.Name = "cboPuertas";
            this.cboPuertas.Size = new System.Drawing.Size(118, 24);
            this.cboPuertas.TabIndex = 33;
            // 
            // cboColor
            // 
            this.cboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(84, 154);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(227, 24);
            this.cboColor.TabIndex = 32;
            // 
            // cboTipoMotor
            // 
            this.cboTipoMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMotor.FormattingEnabled = true;
            this.cboTipoMotor.Location = new System.Drawing.Point(146, 116);
            this.cboTipoMotor.Name = "cboTipoMotor";
            this.cboTipoMotor.Size = new System.Drawing.Size(165, 24);
            this.cboTipoMotor.TabIndex = 31;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(100, 198);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(135, 44);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCantidadRuedas
            // 
            this.txtCantidadRuedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadRuedas.Location = new System.Drawing.Point(193, 46);
            this.txtCantidadRuedas.Name = "txtCantidadRuedas";
            this.txtCantidadRuedas.Size = new System.Drawing.Size(118, 24);
            this.txtCantidadRuedas.TabIndex = 29;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(20, 155);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(56, 23);
            this.lblColor.TabIndex = 28;
            this.lblColor.Text = "Color:";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotor.Location = new System.Drawing.Point(17, 116);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(123, 23);
            this.lblMotor.TabIndex = 27;
            this.lblMotor.Text = "Tipo de motor:";
            // 
            // lblPuertas
            // 
            this.lblPuertas.AutoSize = true;
            this.lblPuertas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertas.Location = new System.Drawing.Point(17, 82);
            this.lblPuertas.Name = "lblPuertas";
            this.lblPuertas.Size = new System.Drawing.Size(170, 23);
            this.lblPuertas.TabIndex = 26;
            this.lblPuertas.Text = "Cantidad de puertas:";
            // 
            // lblRuedas
            // 
            this.lblRuedas.AutoSize = true;
            this.lblRuedas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuedas.Location = new System.Drawing.Point(17, 46);
            this.lblRuedas.Name = "lblRuedas";
            this.lblRuedas.Size = new System.Drawing.Size(164, 23);
            this.lblRuedas.TabIndex = 25;
            this.lblRuedas.Text = "Cantidad de ruedas:";
            // 
            // btnGenerarPatente
            // 
            this.btnGenerarPatente.BackColor = System.Drawing.Color.White;
            this.btnGenerarPatente.Location = new System.Drawing.Point(205, 11);
            this.btnGenerarPatente.Name = "btnGenerarPatente";
            this.btnGenerarPatente.Size = new System.Drawing.Size(106, 24);
            this.btnGenerarPatente.TabIndex = 24;
            this.btnGenerarPatente.Text = "Generar Patente";
            this.btnGenerarPatente.UseVisualStyleBackColor = false;
            this.btnGenerarPatente.Click += new System.EventHandler(this.btnGenerarPatente_Click);
            // 
            // txtGenerarPatente
            // 
            this.txtGenerarPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerarPatente.Location = new System.Drawing.Point(100, 11);
            this.txtGenerarPatente.Name = "txtGenerarPatente";
            this.txtGenerarPatente.Size = new System.Drawing.Size(99, 24);
            this.txtGenerarPatente.TabIndex = 23;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(20, 12);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(74, 23);
            this.lblPatente.TabIndex = 22;
            this.lblPatente.Text = "Patente:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(9, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 19);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Formulario para fabricacion de Vehiculo";
            // 
            // gboCrearAuto
            // 
            this.gboCrearAuto.BackColor = System.Drawing.Color.Gainsboro;
            this.gboCrearAuto.Controls.Add(this.lblPuertas);
            this.gboCrearAuto.Controls.Add(this.cboPuertas);
            this.gboCrearAuto.Controls.Add(this.lblPatente);
            this.gboCrearAuto.Controls.Add(this.cboColor);
            this.gboCrearAuto.Controls.Add(this.txtGenerarPatente);
            this.gboCrearAuto.Controls.Add(this.cboTipoMotor);
            this.gboCrearAuto.Controls.Add(this.btnGenerarPatente);
            this.gboCrearAuto.Controls.Add(this.btnConfirmar);
            this.gboCrearAuto.Controls.Add(this.lblRuedas);
            this.gboCrearAuto.Controls.Add(this.txtCantidadRuedas);
            this.gboCrearAuto.Controls.Add(this.lblMotor);
            this.gboCrearAuto.Controls.Add(this.lblColor);
            this.gboCrearAuto.Location = new System.Drawing.Point(12, 51);
            this.gboCrearAuto.Name = "gboCrearAuto";
            this.gboCrearAuto.Size = new System.Drawing.Size(333, 264);
            this.gboCrearAuto.TabIndex = 34;
            this.gboCrearAuto.TabStop = false;
            // 
            // FrmCrearAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(358, 326);
            this.Controls.Add(this.gboCrearAuto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCrearAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCrearAuto";
            this.Load += new System.EventHandler(this.FrmCrearAuto_Load);
            this.gboCrearAuto.ResumeLayout(false);
            this.gboCrearAuto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboPuertas;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboTipoMotor;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCantidadRuedas;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblPuertas;
        private System.Windows.Forms.Label lblRuedas;
        private System.Windows.Forms.Button btnGenerarPatente;
        private System.Windows.Forms.TextBox txtGenerarPatente;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gboCrearAuto;
    }
}