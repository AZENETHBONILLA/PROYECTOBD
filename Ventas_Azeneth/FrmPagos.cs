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
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
            string cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();
            InitializeComponent();
            cadenaSQL2 = "SELECT DISTINCT Num_Pedido FROM Pedidos";
            this.numpedido.DataSource = objeto2.LeerDatos(cadenaSQL2);
            numpedido.DisplayMember = "Num_Pedido";
            numpedido.ValueMember = "Num_Pedido";

        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            BaseSQL objeto = new BaseSQL();
            try //Si la ejecucion se lleva acabo correctamente
            {
                if (numpedido.SelectedValue != null)
                {
                    //Obtiene el Id_Fab seleccionado

                    //Llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Num_Clie, total FROM Pedidos WHERE Num_Pedido = " + numpedido.SelectedValue + "";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                    if (dr.Read())
                    {
                        lbcp.Text = dr["total"].ToString();
                        Double num3 = Convert.ToDouble(lbcp.Text);
                        int munc = Convert.ToInt32(num3);
                        lbcp.Text = munc.ToString();
                        lbcliente.Text = dr["Num_Clie"].ToString();
                        String val1 = lbcp.Text;
                        int num1 = Convert.ToInt32(val1);
                        String val2 = numontp.Text;
                        int num2 = Convert.ToInt32(val2);
                        int resultado = num1 - num2;
                        lbdeuda.Text = Convert.ToString(resultado);

                    }
                }

            }
            catch (Exception ex)
            {

            }
            String cadenaSQL2 = "";
            BaseSQL objeto2 = new BaseSQL();

            cadenaSQL2 = "Exec Altaspagos " + lbcliente.Text + " , " + numontp.Text + "  , '" + tbfech.Text + "'," + lbdeuda.Text + "," + numpedido.Text + "," + lbcp.Text + "";

            try //Si la ejecucion se lleva acabo correctamente
            {
                objeto2.ejecutar(cadenaSQL2);
                //Se despliega el mensaje para indicar que el registro del producto se guaro correctamente
                MessageBox.Show("Producto guardado correctamente!");
            }
            catch (Exception ex)
            {
                //Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL2);
            }

            //Se limpian los objetos
            lbcliente.Text = "";
            numontp.Text = "";
            tbfech.Text = "";
            lbdeuda.Text = "";
            lbcp.Text = "";

        }

        private void numpedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

