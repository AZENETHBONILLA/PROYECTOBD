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
    public partial class FrmActualizarClientes : Form
    {
        public FrmActualizarClientes()
        {
            InitializeComponent();
        }

        private void FrmActualizarClientes_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try// Si la ejecución se lleva a cabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT Num_Clie, Empresa FROM Clientes";
                this.cmbNumClie.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbNumClie.DisplayMember = "Empresa";
                cmbNumClie.ValueMember = "Num_Clie";

                //Limpia los valores de loas labels
                lblSta.Text = "";
                nudCred.Value = 0;
            }
            catch (Exception ex)
            {
            }
        }

        private void cmbIDClie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbIDRep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            //El nombre del procedimiento será el que ustedes pusieron
            cadenaSQL = "EXEC CambiosClientes " + cmbNumClie.DisplayMember + ",'" + cmbNumClie.ValueMember + "',"+ cmbNombre.ValueMember+ ","+ nudCred+"";
            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("Cliente eliminado correctamente");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }

        }

        private void txtnumClie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmp_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            string peticion = "";
            try
            {
                BaseSQL objeto = new BaseSQL();
                //Verifica si se ha seleccionado un elemento en el comboBox cmbNumClie
                if (cmbNumClie.SelectedValue != null)
                {
                    //Obtiene el IDClie seleccionado
                    int IDClie = int.Parse(cmbNumClie.SelectedValue.ToString());

                    //llena el comboBox cmbNombre por medio de la clase leerDatos.

                    peticion = "SELECT Num_Rep FROM Clientes WHERE Num_Clie = " + IDClie + "";

                    cadenaSQL = "SELECT Num_Rep, Nombre FROM Rep_Ventas where Num_Rep = " + peticion + "";
                    this.cmbNombre.DataSource = objeto.LeerDatos(cadenaSQL);

                    //Despliega los valores en el comboBox
                    cmbNombre.DisplayMember = "Nombre";
                    cmbNombre.ValueMember = "Rep_Ventas";
                }
                else
                {
                    //Si no se ha seleccionado ningún elemento, realiza alguna acción apropiada
                    //por ejemplo, puedes limpiar el comboBox cmbIDProd o mostrar un mensaje al usuario
                    cmbNombre.DisplayMember = "Selecciona un fabricante";
                }
            }
            catch (Exception ex) { }
        }


        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();
                if (cmbNombre.SelectedValue != null)
                {

                    cadenaSQL = "SELECT Lim_Cred, StatusClie FROM Clientes WHERE Num_Clie = '" + cmbNumClie.ValueMember + "'";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                    if (dr.Read())
                    {
                        nudCred.Text = dr["Lim_Cred"].ToString();

                        if (Convert.ToBoolean(dr["StatusClie"]))
                        {
                            lblSta.Text = "Activo";
                            lblSta.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblSta.Text = "Descontinuado";
                            lblSta.ForeColor = Color.Red;
                        }
                        lblSta.Font = new Font(lblSta.Font.FontFamily, 14f, FontStyle.Bold);
                    }


                }


            }
            catch (Exception ex) { }
        }
    }
}

