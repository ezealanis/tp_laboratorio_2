
namespace FrmPrincipal
{
    partial class FrmCrearMoto
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
            this.cboModeloMoto = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboTipoMotor = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCantidadRuedas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarPatente = new System.Windows.Forms.Button();
            this.txtGenerarPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboModeloMoto
            // 
            this.cboModeloMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModeloMoto.FormattingEnabled = true;
            this.cboModeloMoto.Location = new System.Drawing.Point(153, 82);
            this.cboModeloMoto.Name = "cboModeloMoto";
            this.cboModeloMoto.Size = new System.Drawing.Size(146, 24);
            this.cboModeloMoto.TabIndex = 46;
            // 
            // cboColor
            // 
            this.cboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(72, 155);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(227, 24);
            this.cboColor.TabIndex = 45;
            // 
            // cboTipoMotor
            // 
            this.cboTipoMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMotor.FormattingEnabled = true;
            this.cboTipoMotor.Location = new System.Drawing.Point(134, 117);
            this.cboTipoMotor.Name = "cboTipoMotor";
            this.cboTipoMotor.Size = new System.Drawing.Size(165, 24);
            this.cboTipoMotor.TabIndex = 44;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(88, 203);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(135, 44);
            this.btnConfirmar.TabIndex = 43;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCantidadRuedas
            // 
            this.txtCantidadRuedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadRuedas.Location = new System.Drawing.Point(181, 47);
            this.txtCantidadRuedas.Name = "txtCantidadRuedas";
            this.txtCantidadRuedas.Size = new System.Drawing.Size(118, 24);
            this.txtCantidadRuedas.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tipo de motor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Modelo de moto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cantidad de ruedas:";
            // 
            // btnGenerarPatente
            // 
            this.btnGenerarPatente.BackColor = System.Drawing.Color.White;
            this.btnGenerarPatente.Location = new System.Drawing.Point(193, 10);
            this.btnGenerarPatente.Name = "btnGenerarPatente";
            this.btnGenerarPatente.Size = new System.Drawing.Size(106, 26);
            this.btnGenerarPatente.TabIndex = 37;
            this.btnGenerarPatente.Text = "Generar Patente";
            this.btnGenerarPatente.UseVisualStyleBackColor = false;
            this.btnGenerarPatente.Click += new System.EventHandler(this.btnGenerarPatente_Click);
            // 
            // txtGenerarPatente
            // 
            this.txtGenerarPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerarPatente.Location = new System.Drawing.Point(88, 12);
            this.txtGenerarPatente.Name = "txtGenerarPatente";
            this.txtGenerarPatente.Size = new System.Drawing.Size(99, 24);
            this.txtGenerarPatente.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Patente:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 19);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "Formulario para fabricacion de Moto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboModeloMoto);
            this.groupBox1.Controls.Add(this.txtGenerarPatente);
            this.groupBox1.Controls.Add(this.cboColor);
            this.groupBox1.Controls.Add(this.btnGenerarPatente);
            this.groupBox1.Controls.Add(this.cboTipoMotor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantidadRuedas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 260);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // FrmCrearMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(328, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCrearMoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCrearMoto";
            this.Load += new System.EventHandler(this.FrmCrearMoto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboModeloMoto;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboTipoMotor;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCantidadRuedas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarPatente;
        private System.Windows.Forms.TextBox txtGenerarPatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}