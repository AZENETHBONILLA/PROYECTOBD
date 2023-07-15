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
    public partial class FrmAltasOficinas : Form
    {
        public FrmAltasOficinas()
        {
            InitializeComponent();
        }

        private void FrmAltasOficinas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            String cadenaSQL = "";
            cadenaSQL = "INSERT INTO Oficinas (Oficina, Ciudad, Region, Num_Rep_Dir, Objetivo, Ventas) VALUES";
            cadenaSQL = cadenaSQL + "(" + txtOficina.Text + ",'" + txtCiudad.Text + "','" + txtRegion.Text + "'," + txtDireccion.Text + "," + numObjetivo.Value + "," + numVentas.Value + ");";

            //Se llana el método ejecutar que se encuentra en la clase "BaseSQL" y se Le pasa el paranetro con la cadena que contiene el código sql
            objeto.ejecutar(cadenaSQL);

            //Se despliega el mensaje para indicar que el registro del producto se guardo correctamente
            MessageBox.Show("producto guardado correctamente");

            //Se limpian Los objetos
            txtOficina.Text = "";
            txtCiudad.Text = "";
            txtRegion.Text = "";
            txtDireccion.Text = "";
            numObjetivo.Value = 0;
            numVentas.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            String cadenaSQL = "";
            cadenaSQL = "EXEC AltasOficinas " + txtOficina.Text + ",'" + txtCiudad.Text + "','" + txtRegion.Text + "'," + txtDireccion.Text + "," + numObjetivo.Value + "," + numVentas.Value + "";
            try // Si la ejecucucion se lleva a cavo correctamente
            {
                objeto.ejecutar(cadenaSQL);

                // Se despliega el mensaje para indicar que el registro del producto se guardo correctamente
                MessageBox.Show("Registro guardado correctamente");
            }
            catch (Exception ex)
            {
                // Muestra el error dek mensaje para ver el error
                MessageBox.Show("Error al ejecutar la cadena SQL: " + ex.Message + cadenaSQL);
            }
            //Se limpian Los objetos
            txtOficina.Text = "";
            txtCiudad.Text = "";
            txtRegion.Text = "";
            txtDireccion.Text = "";
            numObjetivo.Value = 0;
            numVentas.Value = 0;
        }
    }

}
    

