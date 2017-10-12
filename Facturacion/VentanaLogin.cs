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

using System.Data.SqlClient; //importar espacio de nombre para realizar la conexion a la BD

namespace Facturacion
{
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }


        public static string codigo;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string cadena = string.Format("Select * from Usuario where cuentaUsuario = '{0}' and password = '{1}'",txtCuenta.Text.Trim(),txtPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(cadena);

                string cuenta = ds.Tables[0].Rows[0]["cuentaUsuario"].ToString().Trim();
                string password = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                if (cuenta == txtCuenta.Text.Trim() && password == txtPass.Text.Trim())
                {

                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]) == true)
                    {
                        VentanaAdmin vta = new VentanaAdmin();
                        this.Hide();
                        vta.Show();
                    }
                    else
                    {

                        VentanaUser vtu = new VentanaUser();
                        this.Hide();
                        vtu.Show();

                    }


                   

                }
              


            }
            catch (Exception error) {

                // MessageBox.Show("Error : "+error.Message);
                
                MessageBox.Show("Usuario o contraseña incorrecta: "+ error.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
