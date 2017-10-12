namespace Facturacion
{
    partial class Facturacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnColocar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescPro = new Milibreria2.ErrorTxtBox();
            this.txtPrePro = new Milibreria2.ErrorTxtBox();
            this.txtCodpro = new Milibreria2.ErrorTxtBox();
            this.txtCantPro = new Milibreria2.ErrorTxtBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtCodigo = new Milibreria2.ErrorTxtBox();
            this.txtCliente = new Milibreria2.ErrorTxtBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblAtiende = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(697, 365);
            this.btnSalir.Size = new System.Drawing.Size(130, 23);
            this.btnSalir.TabIndex = 12;
            // 
            // btnColocar
            // 
            this.btnColocar.Location = new System.Drawing.Point(697, 165);
            this.btnColocar.Name = "btnColocar";
            this.btnColocar.Size = new System.Drawing.Size(130, 23);
            this.btnColocar.TabIndex = 6;
            this.btnColocar.Text = "COLOCAR";
            this.btnColocar.UseVisualStyleBackColor = true;
            this.btnColocar.Click += new System.EventHandler(this.btnColocar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(697, 197);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(697, 231);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(130, 23);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(697, 265);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(130, 23);
            this.btnProductos.TabIndex = 9;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(697, 300);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(697, 333);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(130, 23);
            this.btnFacturar.TabIndex = 11;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "LE ATIENDE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "CODIGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "CLIENTE:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.Location = new System.Drawing.Point(65, 165);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "CODIGO";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(548, 437);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 28);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "TOTAL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtDescPro
            // 
            this.txtDescPro.Location = new System.Drawing.Point(198, 130);
            this.txtDescPro.Name = "txtDescPro";
            this.txtDescPro.Size = new System.Drawing.Size(152, 20);
            this.txtDescPro.SoloNumeros = false;
            this.txtDescPro.TabIndex = 3;
            this.txtDescPro.Validar = true;
            // 
            // txtPrePro
            // 
            this.txtPrePro.Location = new System.Drawing.Point(367, 130);
            this.txtPrePro.Name = "txtPrePro";
            this.txtPrePro.Size = new System.Drawing.Size(100, 20);
            this.txtPrePro.SoloNumeros = false;
            this.txtPrePro.TabIndex = 4;
            this.txtPrePro.Validar = true;
            // 
            // txtCodpro
            // 
            this.txtCodpro.Location = new System.Drawing.Point(64, 130);
            this.txtCodpro.Name = "txtCodpro";
            this.txtCodpro.Size = new System.Drawing.Size(100, 20);
            this.txtCodpro.SoloNumeros = false;
            this.txtCodpro.TabIndex = 2;
            this.txtCodpro.Validar = true;
            // 
            // txtCantPro
            // 
            this.txtCantPro.Location = new System.Drawing.Point(482, 130);
            this.txtCantPro.Name = "txtCantPro";
            this.txtCantPro.Size = new System.Drawing.Size(100, 20);
            this.txtCantPro.SoloNumeros = false;
            this.txtCantPro.TabIndex = 5;
            this.txtCantPro.Validar = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colPrecio,
            this.colCantidad,
            this.colValor});
            this.dataGridView1.Location = new System.Drawing.Point(64, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 235);
            this.dataGridView1.TabIndex = 21;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 200;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 110;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 110;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 110;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(433, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(394, 79);
            this.pbLogo.TabIndex = 22;
            this.pbLogo.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(172, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.SoloNumeros = false;
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Validar = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(172, 79);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(211, 20);
            this.txtCliente.SoloNumeros = false;
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Validar = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescripcion.Location = new System.Drawing.Point(162, 165);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(221, 23);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "DESCRIPCION";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecio.Location = new System.Drawing.Point(364, 165);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(119, 23);
            this.lblPrecio.TabIndex = 26;
            this.lblPrecio.Text = "PRECIO";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantidad.Location = new System.Drawing.Point(482, 165);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(100, 23);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "CANTIDAD";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            this.lblValor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValor.Location = new System.Drawing.Point(579, 165);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(86, 23);
            this.lblValor.TabIndex = 28;
            this.lblValor.Text = "VALOR";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(285, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblAtiende
            // 
            this.lblAtiende.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAtiende.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtiende.Location = new System.Drawing.Point(173, 19);
            this.lblAtiende.Name = "lblAtiende";
            this.lblAtiende.Size = new System.Drawing.Size(100, 23);
            this.lblAtiende.TabIndex = 30;
            this.lblAtiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 474);
            this.Controls.Add(this.lblAtiende);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCantPro);
            this.Controls.Add(this.txtCodpro);
            this.Controls.Add(this.txtPrePro);
            this.Controls.Add(this.txtDescPro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnColocar);
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnColocar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnClientes, 0);
            this.Controls.SetChildIndex(this.btnProductos, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnFacturar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtDescPro, 0);
            this.Controls.SetChildIndex(this.txtPrePro, 0);
            this.Controls.SetChildIndex(this.txtCodpro, 0);
            this.Controls.SetChildIndex(this.txtCantPro, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.lblPrecio, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.lblValor, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblAtiende, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColocar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private Milibreria2.ErrorTxtBox txtDescPro;
        private Milibreria2.ErrorTxtBox txtPrePro;
        private Milibreria2.ErrorTxtBox txtCodpro;
        private Milibreria2.ErrorTxtBox txtCantPro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbLogo;
        private Milibreria2.ErrorTxtBox txtCodigo;
        private Milibreria2.ErrorTxtBox txtCliente;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblAtiende;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}