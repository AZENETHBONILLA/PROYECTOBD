using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ventas_Azeneth
{
    public partial class FrmAltaClientes : Form
    {
        public FrmAltaClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            //Llamada a la conexión de la base de datos que se encuentra en la clase BaseSQL, se instancia para su uso.
            BaseSQL objeto = new BaseSQL();

            //Se declara la variedad cadena que contendrá la sentencia de sql a ejecutar:
            //Los objetos alfabeticos se declaran como '" + txtIDFab.Text + "'
            //Los objetos numericos se declaran como "+ numPre.Value+"
            //Se usa el signo "+" para concatenar el sql con los objetos de los cuales se extraerán los valores.

            string cadenaSQL = "";
            cadenaSQL = "INSERT INTO CLIENTES (NUM_CLIE, EMPRESA, NUM_REP, LIM_CRED) VALUES";
            cadenaSQL = cadenaSQL + "(" + txtIDClie.Text + ",'" + txtEmp.Text + "'," + txtIDRep.Text + "," + nudCred.Value + ");";

            objeto.ejecutar(cadenaSQL);

            //Se llama el método ejecutar que se encuentra en la clase "BaseSQL" y se le pasa el parametro con la que contiene el código sql
            MessageBox.Show("producto guardado correctamente");


            //Se limpian los objetos
            txtIDClie.Text = "";
            txtEmp.Text = "";
            txtIDRep.Text = "";
            nudCred.Value = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "Exec AltasClientes " + txtIDClie.Text + ",'" + txtEmp.Text + "'," + txtIDRep.Text + " ," + nudCred.Value + "";

            try //si la ejecución se lleva a cabo correctamente
            {
                objeto.ejecutar(cadenaSQL);

                //Se despliega el mensaje para indicar que el registro del producto se guardo correctamente
                MessageBox.Show("Producto guardado correctamente");

            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }

            //Se limpian los objetos 
            txtIDClie.Text = "";
            txtEmp.Text = "";
            txtIDRep.Text = "";
            nudCred.Value = 0;
        }

        private void FrmAltaClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDRep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
   
