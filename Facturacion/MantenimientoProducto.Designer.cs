namespace Facturacion
{
    partial class MantenimientoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdpro = new Milibreria2.ErrorTxtBox();
            this.txtDespro = new Milibreria2.ErrorTxtBox();
            this.txtPrepro = new Milibreria2.ErrorTxtBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio:";
            // 
            // txtIdpro
            // 
            this.txtIdpro.Location = new System.Drawing.Point(109, 34);
            this.txtIdpro.Name = "txtIdpro";
            this.txtIdpro.Size = new System.Drawing.Size(134, 20);
            this.txtIdpro.SoloNumeros = true;
            this.txtIdpro.TabIndex = 14;
            this.txtIdpro.Validar = true;
            this.txtIdpro.TextChanged += new System.EventHandler(this.txtIdpro_TextChanged_1);
            // 
            // txtDespro
            // 
            this.txtDespro.Location = new System.Drawing.Point(109, 82);
            this.txtDespro.Name = "txtDespro";
            this.txtDespro.Size = new System.Drawing.Size(134, 20);
            this.txtDespro.SoloNumeros = false;
            this.txtDespro.TabIndex = 15;
            this.txtDespro.Validar = true;
            // 
            // txtPrepro
            // 
            this.txtPrepro.Location = new System.Drawing.Point(109, 135);
            this.txtPrepro.Name = "txtPrepro";
            this.txtPrepro.Size = new System.Drawing.Size(134, 20);
            this.txtPrepro.SoloNumeros = true;
            this.txtPrepro.TabIndex = 16;
            this.txtPrepro.Validar = true;
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 292);
            this.Controls.Add(this.txtPrepro);
            this.Controls.Add(this.txtDespro);
            this.Controls.Add(this.txtIdpro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoProducto";
            this.Text = "MantenimientoProducto";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdpro, 0);
            this.Controls.SetChildIndex(this.txtDespro, 0);
            this.Controls.SetChildIndex(this.txtPrepro, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Milibreria2.ErrorTxtBox txtIdpro;
        private Milibreria2.ErrorTxtBox txtDespro;
        private Milibreria2.ErrorTxtBox txtPrepro;
    }
}