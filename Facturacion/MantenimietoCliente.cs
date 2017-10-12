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
    public partial class MantenimietoCliente : Mantenimiento
    {
        public MantenimietoCliente()
        {
            InitializeComponent();
        }
        public override bool Guardar()
        {
            try
            {

                string cmd = string.Format("EXEC ActualizaCLientes '{0}','{1}','{2}'", txtIdCliente.Text.Trim(),txtNombre.Text.Trim(),txtApellido.Text.Trim());
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

        public override void Eliminar()
        {
            try
            {

                string cadena = string.Format("EXEC EliminarClientes {0}", txtIdCliente.Text.Trim());
                Utilidades.Ejecutar(cadena);
                MessageBox.Show("Se ha eliminado el Cliente");


            }
            catch (Exception error)
            {

                MessageBox.Show("a Ocurrido un Error: " + error.Message);

            }
        }
    }
}
