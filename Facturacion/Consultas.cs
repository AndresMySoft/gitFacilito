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
    public partial class Consultas : FormBase
    
    {
        public Consultas()
        {
            InitializeComponent();
        }


        public DataSet LlenarDataGV(string Tabla) {

            DataSet ds;

            string cmd = string.Format("Select * from "+Tabla);
            ds = Utilidades.Ejecutar(cmd);
            return ds;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
