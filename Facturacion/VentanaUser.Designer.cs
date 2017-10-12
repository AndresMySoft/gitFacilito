namespace Facturacion
{
    partial class VentanaUser
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.LblUs = new System.Windows.Forms.Label();
            this.lblNomUs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(250, 165);
            this.btnSalir.Size = new System.Drawing.Size(143, 23);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Cerrar Sesion";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Cambiar Contraseña";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Contenedor Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo.Location = new System.Drawing.Point(110, 160);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(99, 23);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUs
            // 
            this.LblUs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblUs.Location = new System.Drawing.Point(109, 107);
            this.LblUs.Name = "LblUs";
            this.LblUs.Size = new System.Drawing.Size(100, 23);
            this.LblUs.TabIndex = 16;
            this.LblUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomUs
            // 
            this.lblNomUs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomUs.Location = new System.Drawing.Point(109, 54);
            this.lblNomUs.Name = "lblNomUs";
            this.lblNomUs.Size = new System.Drawing.Size(100, 23);
            this.lblNomUs.TabIndex = 15;
            this.lblNomUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // VentanaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.LblUs);
            this.Controls.Add(this.lblNomUs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaUser_FormClosed);
            this.Load += new System.EventHandler(this.VentanaUser_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblNomUs, 0);
            this.Controls.SetChildIndex(this.LblUs, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label LblUs;
        private System.Windows.Forms.Label lblNomUs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}