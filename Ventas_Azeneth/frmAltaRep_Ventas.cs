using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Azeneth
{
    public partial class frmAltaRep_Ventas : Form
    {
        public frmAltaRep_Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            string cadenaSQL = "";

            cadenaSQL = "Exec AltasRep_Ventas " + txtNum_Rep.Text + ",'" + txtNombre.Text + "'," + txtEdad.Text + "," + txtOficina.Text + ",'" + txtTitulo.Text + "','" + txtContrato.Text + "'," + txtDirector.Text + "," + txtCuotas.Text + "," + txtVentas.Text + "," + lblStatus.Text + "";

            try //Si la ejecución se lleva a cabo correctamente
            {
                objeto.ejecutar(cadenaSQL);

                // Se despliega el mensaje para indicar que el registro del producto se guardó correctamente
                MessageBox.Show("Producto guardado correctamente");

            }

            catch (Exception ex)
            {
                // Muestra el error en el mensaje para ver el error

                MessageBox.Show("Error al ejecutar la consulta SQL:" + ex.Message + cadenaSQL);
            }
            // Se limpian los objetos

            txtNum_Rep.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtOficina.Text = "";
            txtTitulo.Text = "";
            txtContrato.Text = "";
            txtDirector.Text = "";
            txtCuotas.Text = "";
            txtVentas.Text = "";
            lblStatus.Text = ""; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Llamada a la conexión de la base de datos que se encuentra en la clase BaseSQL, se instancia para su uso.
            BaseSQL objeto = new BaseSQL();

            //Se declara la variable cadena que contendrá la sentencia de sql a ejecutar:

            //Los objetos alfanumericos se declaran como " + txtIDFab.Text + " //Los objetos nunericos se declaran como "+nudPre.Value + " // Se usa el signo "+" para concatenar el sql con los objetos de los cuales se extraerán los valores.

            string cadenaSQL = "";

            cadenaSQL = "INSERT INTO Rep_Ventas (Num_Rep, Nombre, Edad, Oficina_Rep, Titulo,Contrato, Director, Cuota,Ventas, EstadoRep) VALUES";
            cadenaSQL = cadenaSQL + "( " + txtNum_Rep.Text + ",'" + txtNombre.Text + "'," + txtEdad.Text + "," + txtOficina.Text + ",'" + txtTitulo.Text + "','" + txtContrato.Text + "'," + txtDirector.Text + "," + txtCuotas.Text + "," + txtVentas.Text + "," + lblStatus.Text + ");";

            //Se llama el método ejecutar que se encuentra en la clase "BaseSQL" y se le pasa el parametro con la cadena que contiene el código sql
            objeto.ejecutar(cadenaSQL);

            //Se despliega el mensaje para indicar que el registro del producto se guardo correctamente
            MessageBox.Show("producto guardado correctamente");

            //Se limpian los objetos

            txtNum_Rep.Text = "";

            txtNombre.Text = "";

            txtEdad.Text = "";

            txtOficina.Text = "";

            txtTitulo.Text = "";

            txtContrato.Text = "";

            txtDirector.Text = "";

            txtCuotas.Text = "";

            txtVentas.Text = "";
            lblStatus.Text = "";

        }

        private void frmAltaRep_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
