
namespace FrmPrincipal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarMoto = new System.Windows.Forms.Button();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.gboStock = new System.Windows.Forms.GroupBox();
            this.lblCantMotor = new System.Windows.Forms.Label();
            this.lblCantPintura = new System.Windows.Forms.Label();
            this.lblCantPuertas = new System.Windows.Forms.Label();
            this.lblCantRuedas = new System.Windows.Forms.Label();
            this.lblCantVehiculo = new System.Windows.Forms.Label();
            this.lblStockMotor = new System.Windows.Forms.Label();
            this.lblStockPintura = new System.Windows.Forms.Label();
            this.btnRenovarStock = new System.Windows.Forms.Button();
            this.lblStockPuertas = new System.Windows.Forms.Label();
            this.lblStockRuedas = new System.Windows.Forms.Label();
            this.lblStockVehiculo = new System.Windows.Forms.Label();
            this.gboFabricacion = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarMotos = new System.Windows.Forms.Button();
            this.btnMostrarAutos = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbInfoVehiculo = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPintarVehiculo = new System.Windows.Forms.Button();
            this.btnColocarMotor = new System.Windows.Forms.Button();
            this.btnColocarRuedas = new System.Windows.Forms.Button();
            this.btnColocarPuertas = new System.Windows.Forms.Button();
            this.lblEtapa2 = new System.Windows.Forms.Label();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.btnGenerarArchivoTexto = new System.Windows.Forms.Button();
            this.rtbVehiculosTerminados = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstVehiculosTerminados = new System.Windows.Forms.ListBox();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCargarSerializado = new System.Windows.Forms.Button();
            this.gboColumnaStock = new System.Windows.Forms.GroupBox();
            this.gboStock.SuspendLayout();
            this.gboFabricacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gboColumnaStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarMoto
            // 
            this.btnAgregarMoto.BackColor = System.Drawing.Color.White;
            this.btnAgregarMoto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMoto.Location = new System.Drawing.Point(15, 76);
            this.btnAgregarMoto.Name = "btnAgregarMoto";
            this.btnAgregarMoto.Size = new System.Drawing.Size(171, 36);
            this.btnAgregarMoto.TabIndex = 1;
            this.btnAgregarMoto.Text = "Agregar Moto";
            this.btnAgregarMoto.UseVisualStyleBackColor = false;
            this.btnAgregarMoto.Click += new System.EventHandler(this.btnAgregarMoto_Click);
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.BackColor = System.Drawing.Color.White;
            this.btnAgregarAuto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAuto.Location = new System.Drawing.Point(15, 34);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(171, 36);
            this.btnAgregarAuto.TabIndex = 0;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = false;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // gboStock
            // 
            this.gboStock.BackColor = System.Drawing.Color.Gainsboro;
            this.gboStock.Controls.Add(this.lblCantMotor);
            this.gboStock.Controls.Add(this.lblCantPintura);
            this.gboStock.Controls.Add(this.lblCantPuertas);
            this.gboStock.Controls.Add(this.lblCantRuedas);
            this.gboStock.Controls.Add(this.lblCantVehiculo);
            this.gboStock.Controls.Add(this.lblStockMotor);
            this.gboStock.Controls.Add(this.lblStockPintura);
            this.gboStock.Controls.Add(this.btnRenovarStock);
            this.gboStock.Controls.Add(this.lblStockPuertas);
            this.gboStock.Controls.Add(this.lblStockRuedas);
            this.gboStock.Controls.Add(this.lblStockVehiculo);
            this.gboStock.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboStock.Location = new System.Drawing.Point(15, 118);
            this.gboStock.Name = "gboStock";
            this.gboStock.Size = new System.Drawing.Size(171, 258);
            this.gboStock.TabIndex = 20;
            this.gboStock.TabStop = false;
            this.gboStock.Text = "Lista de Stock ";
            // 
            // lblCantMotor
            // 
            this.lblCantMotor.AutoSize = true;
            this.lblCantMotor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantMotor.Location = new System.Drawing.Point(113, 121);
            this.lblCantMotor.Name = "lblCantMotor";
            this.lblCantMotor.Size = new System.Drawing.Size(15, 16);
            this.lblCantMotor.TabIndex = 16;
            this.lblCantMotor.Text = "0";
            // 
            // lblCantPintura
            // 
            this.lblCantPintura.AutoSize = true;
            this.lblCantPintura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPintura.Location = new System.Drawing.Point(113, 147);
            this.lblCantPintura.Name = "lblCantPintura";
            this.lblCantPintura.Size = new System.Drawing.Size(15, 16);
            this.lblCantPintura.TabIndex = 15;
            this.lblCantPintura.Text = "0";
            // 
            // lblCantPuertas
            // 
            this.lblCantPuertas.AutoSize = true;
            this.lblCantPuertas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPuertas.Location = new System.Drawing.Point(113, 95);
            this.lblCantPuertas.Name = "lblCantPuertas";
            this.lblCantPuertas.Size = new System.Drawing.Size(15, 16);
            this.lblCantPuertas.TabIndex = 14;
            this.lblCantPuertas.Text = "0";
            // 
            // lblCantRuedas
            // 
            this.lblCantRuedas.AutoSize = true;
            this.lblCantRuedas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantRuedas.Location = new System.Drawing.Point(113, 69);
            this.lblCantRuedas.Name = "lblCantRuedas";
            this.lblCantRuedas.Size = new System.Drawing.Size(15, 16);
            this.lblCantRuedas.TabIndex = 13;
            this.lblCantRuedas.Text = "0";
            // 
            // lblCantVehiculo
            // 
            this.lblCantVehiculo.AutoSize = true;
            this.lblCantVehiculo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantVehiculo.Location = new System.Drawing.Point(113, 40);
            this.lblCantVehiculo.Name = "lblCantVehiculo";
            this.lblCantVehiculo.Size = new System.Drawing.Size(15, 16);
            this.lblCantVehiculo.TabIndex = 12;
            this.lblCantVehiculo.Text = "0";
            // 
            // lblStockMotor
            // 
            this.lblStockMotor.AutoSize = true;
            this.lblStockMotor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMotor.Location = new System.Drawing.Point(35, 121);
            this.lblStockMotor.Name = "lblStockMotor";
            this.lblStockMotor.Size = new System.Drawing.Size(59, 16);
            this.lblStockMotor.TabIndex = 11;
            this.lblStockMotor.Text = "Motores:";
            // 
            // lblStockPintura
            // 
            this.lblStockPintura.AutoSize = true;
            this.lblStockPintura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPintura.Location = new System.Drawing.Point(35, 147);
            this.lblStockPintura.Name = "lblStockPintura";
            this.lblStockPintura.Size = new System.Drawing.Size(60, 16);
            this.lblStockPintura.TabIndex = 10;
            this.lblStockPintura.Text = "Pinturas:";
            // 
            // btnRenovarStock
            // 
            this.btnRenovarStock.BackColor = System.Drawing.Color.White;
            this.btnRenovarStock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenovarStock.Location = new System.Drawing.Point(6, 194);
            this.btnRenovarStock.Name = "btnRenovarStock";
            this.btnRenovarStock.Size = new System.Drawing.Size(159, 46);
            this.btnRenovarStock.TabIndex = 1;
            this.btnRenovarStock.Text = "Renovar Stock";
            this.btnRenovarStock.UseVisualStyleBackColor = false;
            this.btnRenovarStock.Click += new System.EventHandler(this.btnRenovarStock_Click);
            // 
            // lblStockPuertas
            // 
            this.lblStockPuertas.AutoSize = true;
            this.lblStockPuertas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPuertas.Location = new System.Drawing.Point(35, 95);
            this.lblStockPuertas.Name = "lblStockPuertas";
            this.lblStockPuertas.Size = new System.Drawing.Size(57, 16);
            this.lblStockPuertas.TabIndex = 9;
            this.lblStockPuertas.Text = "Puertas:";
            // 
            // lblStockRuedas
            // 
            this.lblStockRuedas.AutoSize = true;
            this.lblStockRuedas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockRuedas.Location = new System.Drawing.Point(35, 69);
            this.lblStockRuedas.Name = "lblStockRuedas";
            this.lblStockRuedas.Size = new System.Drawing.Size(56, 16);
            this.lblStockRuedas.TabIndex = 8;
            this.lblStockRuedas.Text = "Ruedas:";
            // 
            // lblStockVehiculo
            // 
            this.lblStockVehiculo.AutoSize = true;
            this.lblStockVehiculo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockVehiculo.Location = new System.Drawing.Point(35, 40);
            this.lblStockVehiculo.Name = "lblStockVehiculo";
            this.lblStockVehiculo.Size = new System.Drawing.Size(72, 16);
            this.lblStockVehiculo.TabIndex = 7;
            this.lblStockVehiculo.Text = "Vehiculos :";
            // 
            // gboFabricacion
            // 
            this.gboFabricacion.BackColor = System.Drawing.Color.Gainsboro;
            this.gboFabricacion.Controls.Add(this.groupBox2);
            this.gboFabricacion.Controls.Add(this.btnEliminarVehiculo);
            this.gboFabricacion.Controls.Add(this.label2);
            this.gboFabricacion.Controls.Add(this.rtbInfoVehiculo);
            this.gboFabricacion.Controls.Add(this.groupBox1);
            this.gboFabricacion.Controls.Add(this.lblEtapa2);
            this.gboFabricacion.Controls.Add(this.lstVehiculos);
            this.gboFabricacion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFabricacion.Location = new System.Drawing.Point(229, 12);
            this.gboFabricacion.Name = "gboFabricacion";
            this.gboFabricacion.Size = new System.Drawing.Size(415, 478);
            this.gboFabricacion.TabIndex = 1;
            this.gboFabricacion.TabStop = false;
            this.gboFabricacion.Text = "  Proceso de Fabricacion  ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.btnMostrarMotos);
            this.groupBox2.Controls.Add(this.btnMostrarAutos);
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Location = new System.Drawing.Point(215, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 58);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar";
            // 
            // btnMostrarMotos
            // 
            this.btnMostrarMotos.BackColor = System.Drawing.Color.White;
            this.btnMostrarMotos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMotos.Location = new System.Drawing.Point(120, 22);
            this.btnMostrarMotos.Name = "btnMostrarMotos";
            this.btnMostrarMotos.Size = new System.Drawing.Size(50, 36);
            this.btnMostrarMotos.TabIndex = 31;
            this.btnMostrarMotos.Text = "Motos";
            this.btnMostrarMotos.UseVisualStyleBackColor = false;
            this.btnMostrarMotos.Click += new System.EventHandler(this.btnMostrarMotos_Click);
            // 
            // btnMostrarAutos
            // 
            this.btnMostrarAutos.BackColor = System.Drawing.Color.White;
            this.btnMostrarAutos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarAutos.Location = new System.Drawing.Point(60, 22);
            this.btnMostrarAutos.Name = "btnMostrarAutos";
            this.btnMostrarAutos.Size = new System.Drawing.Size(50, 36);
            this.btnMostrarAutos.TabIndex = 30;
            this.btnMostrarAutos.Text = "Autos";
            this.btnMostrarAutos.UseVisualStyleBackColor = false;
            this.btnMostrarAutos.Click += new System.EventHandler(this.btnMostrarAutos_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.White;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.Location = new System.Drawing.Point(0, 22);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(50, 36);
            this.btnMostrarTodos.TabIndex = 29;
            this.btnMostrarTodos.Text = "Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.BackColor = System.Drawing.Color.White;
            this.btnEliminarVehiculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(16, 425);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(180, 36);
            this.btnEliminarVehiculo.TabIndex = 28;
            this.btnEliminarVehiculo.Text = "Eliminar vehiculo";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = false;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Estado";
            // 
            // rtbInfoVehiculo
            // 
            this.rtbInfoVehiculo.Location = new System.Drawing.Point(215, 65);
            this.rtbInfoVehiculo.Name = "rtbInfoVehiculo";
            this.rtbInfoVehiculo.Size = new System.Drawing.Size(174, 121);
            this.rtbInfoVehiculo.TabIndex = 26;
            this.rtbInfoVehiculo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btnPintarVehiculo);
            this.groupBox1.Controls.Add(this.btnColocarMotor);
            this.groupBox1.Controls.Add(this.btnColocarRuedas);
            this.groupBox1.Controls.Add(this.btnColocarPuertas);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(215, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Ensamble";
            // 
            // btnPintarVehiculo
            // 
            this.btnPintarVehiculo.BackColor = System.Drawing.Color.White;
            this.btnPintarVehiculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPintarVehiculo.Location = new System.Drawing.Point(7, 158);
            this.btnPintarVehiculo.Name = "btnPintarVehiculo";
            this.btnPintarVehiculo.Size = new System.Drawing.Size(161, 29);
            this.btnPintarVehiculo.TabIndex = 3;
            this.btnPintarVehiculo.Text = "Pintar Vehiculo";
            this.btnPintarVehiculo.UseVisualStyleBackColor = false;
            this.btnPintarVehiculo.Click += new System.EventHandler(this.btnPintarVehiculo_Click);
            // 
            // btnColocarMotor
            // 
            this.btnColocarMotor.BackColor = System.Drawing.Color.White;
            this.btnColocarMotor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarMotor.Location = new System.Drawing.Point(6, 123);
            this.btnColocarMotor.Name = "btnColocarMotor";
            this.btnColocarMotor.Size = new System.Drawing.Size(161, 29);
            this.btnColocarMotor.TabIndex = 2;
            this.btnColocarMotor.Text = "Colocar Motor";
            this.btnColocarMotor.UseVisualStyleBackColor = false;
            this.btnColocarMotor.Click += new System.EventHandler(this.btnColocarMotor_Click);
            // 
            // btnColocarRuedas
            // 
            this.btnColocarRuedas.BackColor = System.Drawing.Color.White;
            this.btnColocarRuedas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarRuedas.Location = new System.Drawing.Point(6, 37);
            this.btnColocarRuedas.Name = "btnColocarRuedas";
            this.btnColocarRuedas.Size = new System.Drawing.Size(161, 29);
            this.btnColocarRuedas.TabIndex = 0;
            this.btnColocarRuedas.Text = "Colocar Ruedas";
            this.btnColocarRuedas.UseVisualStyleBackColor = false;
            this.btnColocarRuedas.Click += new System.EventHandler(this.btnColocarRuedas_Click);
            // 
            // btnColocarPuertas
            // 
            this.btnColocarPuertas.BackColor = System.Drawing.Color.White;
            this.btnColocarPuertas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarPuertas.Location = new System.Drawing.Point(6, 76);
            this.btnColocarPuertas.Name = "btnColocarPuertas";
            this.btnColocarPuertas.Size = new System.Drawing.Size(161, 29);
            this.btnColocarPuertas.TabIndex = 1;
            this.btnColocarPuertas.Text = "Colocar Puertas";
            this.btnColocarPuertas.UseVisualStyleBackColor = false;
            this.btnColocarPuertas.Click += new System.EventHandler(this.btnColocarPuertas_Click);
            // 
            // lblEtapa2
            // 
            this.lblEtapa2.AutoSize = true;
            this.lblEtapa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtapa2.Location = new System.Drawing.Point(13, 38);
            this.lblEtapa2.Name = "lblEtapa2";
            this.lblEtapa2.Size = new System.Drawing.Size(183, 16);
            this.lblEtapa2.TabIndex = 7;
            this.lblEtapa2.Text = "Vehiculos en Fabricacion";
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 14;
            this.lstVehiculos.Location = new System.Drawing.Point(16, 65);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(180, 354);
            this.lstVehiculos.TabIndex = 0;
            this.lstVehiculos.SelectedIndexChanged += new System.EventHandler(this.lstVehiculos_SelectedIndexChanged);
            // 
            // btnGenerarArchivoTexto
            // 
            this.btnGenerarArchivoTexto.BackColor = System.Drawing.Color.White;
            this.btnGenerarArchivoTexto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarArchivoTexto.Location = new System.Drawing.Point(22, 433);
            this.btnGenerarArchivoTexto.Name = "btnGenerarArchivoTexto";
            this.btnGenerarArchivoTexto.Size = new System.Drawing.Size(180, 36);
            this.btnGenerarArchivoTexto.TabIndex = 0;
            this.btnGenerarArchivoTexto.Text = "Mostrar como texto";
            this.btnGenerarArchivoTexto.UseVisualStyleBackColor = false;
            this.btnGenerarArchivoTexto.Click += new System.EventHandler(this.btnGenerarArchivoTexto_Click);
            // 
            // rtbVehiculosTerminados
            // 
            this.rtbVehiculosTerminados.Location = new System.Drawing.Point(17, 36);
            this.rtbVehiculosTerminados.Name = "rtbVehiculosTerminados";
            this.rtbVehiculosTerminados.Size = new System.Drawing.Size(228, 422);
            this.rtbVehiculosTerminados.TabIndex = 25;
            this.rtbVehiculosTerminados.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.lstVehiculosTerminados);
            this.groupBox3.Controls.Add(this.btnGenerarArchivoTexto);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(661, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 478);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Vehiculos Terminados";
            // 
            // lstVehiculosTerminados
            // 
            this.lstVehiculosTerminados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVehiculosTerminados.FormattingEnabled = true;
            this.lstVehiculosTerminados.ItemHeight = 14;
            this.lstVehiculosTerminados.Location = new System.Drawing.Point(22, 38);
            this.lstVehiculosTerminados.Name = "lstVehiculosTerminados";
            this.lstVehiculosTerminados.Size = new System.Drawing.Size(180, 382);
            this.lstVehiculosTerminados.TabIndex = 32;
            // 
            // btnSerializar
            // 
            this.btnSerializar.BackColor = System.Drawing.Color.White;
            this.btnSerializar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializar.Location = new System.Drawing.Point(15, 382);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(171, 36);
            this.btnSerializar.TabIndex = 2;
            this.btnSerializar.Text = "Serializar Fabrica";
            this.btnSerializar.UseVisualStyleBackColor = false;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.rtbVehiculosTerminados);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(903, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 478);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar Vehiculos Terminados";
            // 
            // btnCargarSerializado
            // 
            this.btnCargarSerializado.BackColor = System.Drawing.Color.White;
            this.btnCargarSerializado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarSerializado.Location = new System.Drawing.Point(15, 424);
            this.btnCargarSerializado.Name = "btnCargarSerializado";
            this.btnCargarSerializado.Size = new System.Drawing.Size(171, 36);
            this.btnCargarSerializado.TabIndex = 3;
            this.btnCargarSerializado.Text = "Cargar Fabrica Serializada";
            this.btnCargarSerializado.UseVisualStyleBackColor = false;
            this.btnCargarSerializado.Click += new System.EventHandler(this.btnCargarSerializado_Click);
            // 
            // gboColumnaStock
            // 
            this.gboColumnaStock.BackColor = System.Drawing.Color.LightGray;
            this.gboColumnaStock.Controls.Add(this.gboStock);
            this.gboColumnaStock.Controls.Add(this.btnCargarSerializado);
            this.gboColumnaStock.Controls.Add(this.btnAgregarAuto);
            this.gboColumnaStock.Controls.Add(this.btnAgregarMoto);
            this.gboColumnaStock.Controls.Add(this.btnSerializar);
            this.gboColumnaStock.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gboColumnaStock.Location = new System.Drawing.Point(12, 12);
            this.gboColumnaStock.Name = "gboColumnaStock";
            this.gboColumnaStock.Size = new System.Drawing.Size(201, 475);
            this.gboColumnaStock.TabIndex = 0;
            this.gboColumnaStock.TabStop = false;
            this.gboColumnaStock.Text = "Stock";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(899, 501);
            this.Controls.Add(this.gboColumnaStock);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gboFabricacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ezequiel Alanis 2C";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gboStock.ResumeLayout(false);
            this.gboStock.PerformLayout();
            this.gboFabricacion.ResumeLayout(false);
            this.gboFabricacion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gboColumnaStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMoto;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.GroupBox gboStock;
        private System.Windows.Forms.Label lblCantMotor;
        private System.Windows.Forms.Label lblCantPintura;
        private System.Windows.Forms.Label lblCantPuertas;
        private System.Windows.Forms.Label lblCantRuedas;
        private System.Windows.Forms.Label lblCantVehiculo;
        private System.Windows.Forms.Label lblStockMotor;
        private System.Windows.Forms.Label lblStockPintura;
        private System.Windows.Forms.Label lblStockPuertas;
        private System.Windows.Forms.Label lblStockRuedas;
        private System.Windows.Forms.Label lblStockVehiculo;
        private System.Windows.Forms.Button btnRenovarStock;
        private System.Windows.Forms.GroupBox gboFabricacion;
        private System.Windows.Forms.Button btnGenerarArchivoTexto;
        private System.Windows.Forms.Label lblEtapa2;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPintarVehiculo;
        private System.Windows.Forms.Button btnColocarMotor;
        private System.Windows.Forms.Button btnColocarRuedas;
        private System.Windows.Forms.Button btnColocarPuertas;
        private System.Windows.Forms.RichTextBox rtbVehiculosTerminados;
        private System.Windows.Forms.RichTextBox rtbInfoVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarMotos;
        private System.Windows.Forms.Button btnMostrarAutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.ListBox lstVehiculosTerminados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCargarSerializado;
        private System.Windows.Forms.GroupBox gboColumnaStock;
    }
}

