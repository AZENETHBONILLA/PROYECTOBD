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
    public partial class FrmActualizarProducto : Form
    {
        public FrmActualizarProducto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmActualizarProducto_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try// Si la ejecución se lleva a cabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT ID_Fab FROM Productos";
                this.cmbIDFab.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbIDFab.DisplayMember = "Id_Fab";
                cmbIDFab.ValueMember = "Id_Fab";

                //Limpia los valores de loas labels
                txtDes.Text = "";
                nudPre.Text = "";
                nudExi.Text = "";
            }
            catch (Exception ex)
            {
            }
        }

        private void lblIDFab_Click(object sender, EventArgs e)
        {

        }

        //Cuando cambie el combo del Fabricante
        private void cmbIDFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();
                //Verifica si se ha seleccionado un elemento en el comboBox cmbIDFab
                if (cmbIDFab.SelectedValue != null)
                {
                    //Obtiene el ID_Fab seleccionado
                    string idFab = (string)cmbIDFab.SelectedValue;

                    //llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Id_Producto FROM Productos WHERE Id_Fab = '" + idFab + "' ORDER BY Id_Fab";
                    this.cmbIDProd.DataSource = objeto.LeerDatos(cadenaSQL);

                    //Despliega los valores en el comboBox
                    cmbIDProd.DisplayMember = "Id_Producto";
                    cmbIDProd.ValueMember = "Id_Producto";
                }
                else
                {
                    //Si no se ha seleccionado ningún elemento, realiza alguna acción apropiada
                    //por ejemplo, puedes limpiar el comboBox cmbIDProd o mostrar un mensaje al usuario
                    cmbIDProd.DisplayMember = "Selecciona un fabricante";
                }
            }
            catch (Exception ex) { }
        }

        private void cmbIDProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();
                if (cmbIDProd.SelectedValue != null)
                {
                    //llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Descripcion, Precio, Existencias, StatusProd FROM Productos WHERE Id_Fab ='" + cmbIDFab.SelectedValue + "' AND Id_Producto = '" + cmbIDProd.SelectedValue.ToString() + "'";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                    if (dr.Read())
                    {
                        txtDes.Text = dr["Descripcion"].ToString();
                        nudPre.Value = (decimal)dr["Precio"];
                        nudExi.Value = (int)dr["Existencias"];
                       
                        if (Convert.ToBoolean(dr["StatusProd"]))
                        {
                            lblStatus.Text = "ACTIVO";
                            lblStatus.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblStatus.Text = "Descontinuado";
                            lblStatus.ForeColor = Color.Green;
                        }
                        lblStatus.Font = new Font(lblStatus.Font.FontFamily, 14f, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void Actualizar_Click_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            //El nombre del procedimiento será el que ustedes pusieron
            cadenaSQL = "EXEC CambiosProductos '" + cmbIDFab.SelectedValue + "','" + cmbIDProd.SelectedValue + "','" + txtDes.Text + "' ," + nudPre.Value + "," + nudExi.Value + "";
            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("Producto actualizado correctamente");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}

