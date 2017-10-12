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
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();

        }

        public override bool Guardar()
        {
            if (Utilidades.ValidaFormulario(this, errorProvider1) == false)
            {

                try
                {

                    string cmd = string.Format("EXEC ActualizaArticulos '{0}','{1}','{2}'", txtIdpro.Text.Trim(), txtDespro.Text.Trim(), txtPrepro.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se a Guardado Correctamente");
                    return true;

                }
                catch (Exception error)
                {

                    MessageBox.Show("ha ocurrido un error: " + error.Message);
                    return false;
                }

            }

            else {

                return false;
            }


        }

        public override void Eliminar()
        {
            try
            {

                string cadena = string.Format("EXEC EliminarProductos '{0}'",txtIdpro.Text.Trim());
                Utilidades.Ejecutar(cadena);
                MessageBox.Show("Se ha eliminado el producto");


            }
            catch (Exception error) {

                MessageBox.Show("a Ocurrido un Error: " + error.Message);
                
            }
        }

        private void txtIdpro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtIdpro_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
