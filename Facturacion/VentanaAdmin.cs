using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milibreria2;

namespace Facturacion
{
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {

            string cadena = "Select * from usuario where id_usuario =" + VentanaLogin.codigo;
            DataSet ds = Utilidades.Ejecutar(cadena);

            lblAdmin.Text = ds.Tables[0].Rows[0]["cuentaUsuario"].ToString().Trim();
            lblUsAdmin.Text = ds.Tables[0].Rows[0]["nombreUsuario"].ToString().Trim();
            lblCodigo.Text = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

            pictureBox1.Image = Image.FromFile(ds.Tables[0].Rows[0]["foto"].ToString().Trim());



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal cp = new ContenedorPrincipal();
            this.Hide();
            cp.Show();
        }
    }
}
