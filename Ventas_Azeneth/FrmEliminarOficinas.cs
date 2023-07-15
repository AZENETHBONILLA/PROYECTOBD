using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Azeneth
{
    public partial class FrmEliminarOficinas : Form
    {
        public FrmEliminarOficinas()
        {
            InitializeComponent();
        }

        private void FrmEliminarOficinas_Load(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            cadenaSQL = "elimina_oficinas '" + txtOficina.Text + "','" + txtNum_Rep_Dir.Text + "'";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("La Oficina se ELIMINO correctamente!");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }


            //Se limpian los objetos
            txtOficina.Text = "";
            txtNum_Rep_Dir.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void CmbOficinas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
