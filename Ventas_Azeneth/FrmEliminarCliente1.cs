using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Azeneth
{
    public partial class FrmEliminarCliente1 : Form
    {
        public FrmEliminarCliente1()
        {
            InitializeComponent();
        }

        private void FrmEliminarCliente1_Load(object sender, EventArgs e)
        {

        }

        private void cmbIDClie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();

            string cadenaSQL = "";
            cadenaSQL = "EXEC elimina_clientes '" + cmbIDClie.Text + "','" + txtNumRep.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("El Cliente se Elimino!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }

            //Se limpian los objetos
            cmbIDClie.Text = "";
            txtNumRep.Text = "";
        }

        public void eliminarRepVentas(int numClie)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbIDClie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

        }
    }
}
