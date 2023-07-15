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
    public partial class frmEliminarProd : Form
    {
        public frmEliminarProd()
        {
            InitializeComponent();
        }

        private void cmbIDFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";

            try //Si la ejecución se lleva a cabo correctamente
            {
                BaseSQL objeto = new BaseSQL();

                //verifica si se ha seleccionado un elemento en el ComboBox cmbIDFab
                if (cmbIDFab.SelectedValue != null)
                {
                    //Obtiene el ID_Fab seleccionado
                    string idFab = (string)cmbIDFab.SelectedValue;

                    //Llena el combox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Id_Producto FROM Productos WHERE Id_Fab = '" + idFab + "' order by Id_Fab";
                    this.cmbIDProd.DataSource = objeto.LeerDatos(cadenaSQL);

                    //Despliega los valores en el comboBox
                    cmbIDProd.DisplayMember = "Id_Producto";
                    cmbIDProd.ValueMember = "Id_Producto";
                }
                else
                {
                    //Si no ha seleccionado ningún elemento, realiza alguna acción apropiada
                    //por ejemplo, puedes limpiar el ComboBox cmbIDProd o mostrar un mensaje al usuario.
                    cmbIDProd.DisplayMember = "Selecciona un fabricante";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbIDProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();
                if (cmbIDFab.SelectedValue != null)
                {
                    if (cmbIDProd.SelectedValue != null)
                    {
                        //llena el comboBox cmbIDProd por medio de la clase leerDatos.
                        cadenaSQL = "SELECT Descripcion, Precio, Existencias,StatusProd FROM Productos WHERE Id_Fab ='" + cmbIDFab.SelectedValue + "' AND Id_Producto ='" + cmbIDProd.SelectedValue.ToString() + "'";
                        SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                        if (dr.Read())
                        {
                            //Muestra los valores en los labels de lbldescripción, lblprecio y lblcantidad, de acuerdo a los valores obtenidos en la consulta

                            //el sqlDataReader guarda los valores obtenidos de la consulta en posiciones o casillas
                            //en la posición [0] el valor de la descripción, en la [1] el precio y en la [2] la cantidad 
                            //lblPrecio.Text = dr[0].ToString();
                            //lblCantidad.Text = dr[2].To String();
                            //También se puede poner directamente el nombre del objeto
                            lblDescripción.Text = dr["Descripcion"].ToString();
                            lblPrecio.Text = dr[1].ToString();
                            lblCantidad.Text = dr[2].ToString();
                            if (Convert.ToBoolean(dr["StatusProd"]))
                            {
                                lblStatus.Text = "Activo";
                                lblStatus.ForeColor = Color.Green;
                            }
                            else
                            {
                                lblStatus.Text = "Descontinuado";
                                lblStatus.ForeColor = Color.Red;
                            }
                            lblStatus.Font = new Font(lblStatus.Font.FontFamily, 14f, FontStyle.Bold);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                //Muestra el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + "" + cadenaSQL);
            }
        }

        private void frmEliminarProd_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try //Si la ejecución se lleva a cabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT ID_Fab FROM Productos";
                this.cmbIDFab.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbIDFab.DisplayMember = "Id_Fab";
                cmbIDFab.ValueMember = "Id_Fab";
                
                //Limpia los valores de los labels
                lblDescripción.Text = "";
                lblPrecio.Text = "";
                lblCantidad.Text = "";
            }
            catch (Exception ex)
            {
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            //El nombre del procedimiento será el que ustedes pusieron
            cadenaSQL = "EXEC EliminarProductos '" + cmbIDFab.SelectedValue + "','" + cmbIDProd.SelectedValue + "'";
            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("Producto eliminado correctamente");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }
        }
    }
}
