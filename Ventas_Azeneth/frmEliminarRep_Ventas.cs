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
    public partial class frmEliminarRep_Ventas : Form
    {
        public frmEliminarRep_Ventas()
        {
            InitializeComponent();
        }

        private void frmEliminarRep_Ventas_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT Num_Rep FROM Rep_Ventas";
                this.cmbNum_Rep.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbNum_Rep.DisplayMember = "Num_Rep";
                cmbNum_Rep.ValueMember = "Num_Rep";

                cmbNum_Rep.Text = "";
                lblno.Text = "";
                lbled.Text = "";
                lblofi.Text = "";
                lbltit.Text = "";
                lblcon.Text = "";
                lbldir.Text = "";
                lblcuo.Text = "";
                lblven.Text = "";
                lblest.Text = "";
            }
            catch (Exception ex)
            {

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = cmbNum_Rep.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                int numRep = Convert.ToInt32(selectedRow["Num_Rep"]);

                // Llama al método eliminarRepVentas pasando el número de reporte seleccionado
                eliminarRepVentas(numRep);
            }
        }

        public void eliminarRepVentas(int numRep)
            {
                string cadenaSQL = "";

                try
                {
                    BaseSQL objeto = new BaseSQL();

                    cadenaSQL = "DELETE FROM Rep_Ventas WHERE Num_Rep = " + numRep;
                    objeto.ejecutar(cadenaSQL);

                    // Realiza cualquier otra acción que necesites después de eliminar el registro

                    // Limpia los controles después de la eliminación
                    lblno.Text = "";
                    lbled.Text = "";
                    lblofi.Text = "";
                    lbltit.Text = "";
                    lblcon.Text = "";
                    lbldir.Text = "";
                    lblcuo.Text = "";
                    lblven.Text = "";
                    lblest.Text = "";

                    MessageBox.Show("Borrado representante");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta SQL el representante tiene datos asociados: " + ex.Message + " " + cadenaSQL);
                }
            }
        
    


private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";

            try //Si la ejecución se lleva a cabo correctamente
            {

                BaseSQL objeto = new BaseSQL();

                // Verifica si se ha seleccionado un elemento en el ComboBox cmbIDFab
                DataRowView selectedRow = cmbNum_Rep.SelectedItem as DataRowView;


                if (selectedRow != null)

                {
                    // Obtiene el ID_Fab seleccionado
                    int numRep = Convert.ToInt32(selectedRow["Num_Rep"]);

                    cadenaSQL = "SELECT Nombre, Edad, Oficina_Rep, Titulo, Contrato, Director, Cuota, Ventas, EstadoRep  FROM Rep_Ventas WHERE Num_Rep = " + numRep;
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                    if (dr.Read())
                    {
                        lblno.Text = dr["Nombre"].ToString();
                        lbled.Text = dr["Edad"].ToString();
                        lblofi.Text = dr["Oficina_Rep"].ToString();
                        lbltit.Text = dr["Titulo"].ToString();
                        lblcon.Text = dr["Contrato"].ToString();
                        lbldir.Text = dr["Director"].ToString();
                        lblcuo.Text = dr["Cuota"].ToString();
                        lblven.Text = dr["Ventas"].ToString();
                        lblest.Text = dr["EstadoRep"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta sql " + ex.Message + " " + cadenaSQL);

            }

        }
    }
}
