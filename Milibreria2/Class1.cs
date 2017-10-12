using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Milibreria2
{
    public class Utilidades
    {

        public static DataSet Ejecutar(string cmd) {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True"); //conexion a la BD
            con.Open(); // Abre la conexion a la BD
            DataSet DS = new DataSet(); //Para almacenar lo que quiero consultar
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con); //para adaptar los datos de la consulta al dataset
            DP.Fill(DS); //Para llenar el DataSet
            con.Close(); //Cerrar la Conexion
            return DS; //Retorna el DataSets

        }

        public static Boolean ValidaFormulario(Control objeto, ErrorProvider errorProvider) {

            Boolean hayError = false;

            foreach (Control Item in objeto.Controls) {

                if (Item is ErrorTxtBox) {

                    ErrorTxtBox obj = (ErrorTxtBox)Item;

                    if (obj.Validar == true)
                    {

                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {

                            errorProvider.SetError(obj, "No puede estar Vacio");
                            hayError = true;

                        }
                    }

                    if (obj.SoloNumeros == true) {

                        int cont = 0, LetrasEncontradas = 0;

                        foreach(char letra in obj.Text.Trim())
                        {

                            if (char.IsLetter(obj.Text.Trim(),cont)) {

                                LetrasEncontradas++;

                            }

                            cont++;

                        }

                        if (LetrasEncontradas != 0){
                            hayError = true;
                            errorProvider.SetError(obj,"Solo Numeros");
                        }

                    }

                }
            }

            return hayError;

        }
    }
}
