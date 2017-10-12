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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

            string cmd = "Select * from Usuario where id_usuario = " + VentanaLogin.codigo;
            DataSet ds = Utilidades.Ejecutar(cmd);

            lblAtiende.Text = ds.Tables[0].Rows[0]["nombreUsuario"].ToString().Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigo.Text.Trim()) == false) {


                try
                {

                    string cmd = string.Format("Select * from cliente where id_clientes = '{0}'", txtCodigo.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);

                    txtCliente.Text = ds.Tables[0].Rows[0]["nom_cli"].ToString().Trim();

                    txtCodpro.Focus();


                }
                catch (Exception error) {

                    MessageBox.Show("Ha Ocurrido un Error : " + error.Message);
                }


            }


        }

        public static int cont_fila = 0;
        public static double total;

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidaFormulario(this, errorProvider1) == false)
            {

                bool existe = false;
                int num_fila = 0;


                if (cont_fila == 0)
                {

                    dataGridView1.Rows.Add(txtCodpro.Text, txtDescPro.Text, txtPrePro.Text, txtCantPro.Text);

                    double valor = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);

                    dataGridView1.Rows[cont_fila].Cells[4].Value = valor;

                    cont_fila++;

                }
                else
                {

                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {

                        if (fila.Cells[0].Value.ToString() == txtCodpro.Text)
                        {

                            existe = true;
                            num_fila = fila.Index;
                        }


                    }
                    if (existe == true)
                    {


                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantPro.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double valor = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);

                        dataGridView1.Rows[num_fila].Cells[4].Value = valor;
                    }
                    else
                    {

                        dataGridView1.Rows.Add(txtCodpro.Text, txtDescPro.Text, txtPrePro.Text, txtCantPro.Text);

                        double valor = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);

                        dataGridView1.Rows[cont_fila].Cells[4].Value = valor;
                        cont_fila++;

                    }


                }

                total = 0;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {

                    total += Convert.ToDouble(fila.Cells[4].Value);


                }

                lblTotal.Text = "$" + total.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (cont_fila > 0) {


                total = total - Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value);
                lblTotal.Text = total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                cont_fila--;

            } 

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ConsultarClientes conCli = new ConsultarClientes();

            conCli.ShowDialog();

            if (conCli.DialogResult == DialogResult.OK) {



                txtCodigo.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = conCli.dataGridView1.Rows[conCli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                txtCodpro.Focus();

            }



        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ConsultarProductos conPro = new ConsultarProductos();

            conPro.ShowDialog();

            if (conPro.DialogResult == DialogResult.OK)
            {



                txtCodpro.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescPro.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrePro.Text = conPro.dataGridView1.Rows[conPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCantPro.Focus();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public override void Nuevo()
        {
            txtCodigo.Text = "";
            txtCliente.Text = "";
            txtCodpro.Text = "";
            txtDescPro.Text = "";
            txtPrePro.Text = "";
            txtCantPro.Text = "";
            lblTotal.Text = "$ 0";
            dataGridView1.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtCodigo.Focus();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (cont_fila != 0) {


                try
                {

                    string cadena = string.Format("Execute ActualizaFacturas '{0}'", txtCodigo.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cadena);

                    string numFact = ds.Tables[0].Rows[0]["Num_Fac"].ToString().Trim();


                    foreach (DataGridViewRow fila in dataGridView1.Rows) {

                         cadena = string.Format("Execute ActualizaDetalles '{0}','{1}','{2}','{3}'",numFact,fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(), fila.Cells[3].Value.ToString());
                        ds = Utilidades.Ejecutar(cadena);

                    }

                    cadena = "Execute DatosFacturas " + numFact;
                    ds = Utilidades.Ejecutar(cadena);

                    //Ventana reporte


                    Reporte rp = new Reporte();


                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();
                    Nuevo();



                }



                catch (Exception error) {

                    MessageBox.Show("Mensaje de Error: " + error.Message);


                }




            }
        }
    }
}
