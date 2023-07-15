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
    public partial class frmActualizarRep_Ventas : Form
    {
        public frmActualizarRep_Ventas()
        {
            InitializeComponent();
        }

        private void frmActualizarRep_Ventas_Load(object sender, EventArgs e)
        {

            string cadenaSQL = "";

            try //Si la ejecución se lleva a cabo correctamente

            {

                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT Num_Rep, Nombre FROM Rep_Ventas";
                this.cmbNum_Rep.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbNum_Rep.DisplayMember = "Nombre";
                cmbNum_Rep.ValueMember = "Num_Rep";

                // Limpia los valores de los labels
                cmbNum_Rep.Text = "";
                txtNombre.Text = "";
                nudEdad.Value = 0;
                nudOficina.Value = 0;
                txtTitulo.Text = "";
                txtContra.Text = "";
                nudDirector.Value = 0;
                nudCuotas.Value = 0;
                nudVentas.Value = 0;
                nudOficina.Value = 0;
            }
            catch (Exception ex)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";

            cadenaSQL = "CambiosRepVentas " + cmbNum_Rep.SelectedValue + ",'" + txtNombre.Text + "'," + nudEdad.Value + " ," + nudOficina.Value + ",'" + txtTitulo.Text + "','" + txtContra.Text + "'," + nudDirector.Value + "," + nudCuotas.Value + "," + nudVentas.Value + "," + nudEstado.Value + "";

            try
            {
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("representante actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL " + ex.Message + cadenaSQL);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";

            try //Si la ejecución se lleva a cabo correctamente
            {

                BaseSQL objeto = new BaseSQL();
                int numrep = int.Parse(cmbNum_Rep.SelectedValue.ToString());

                // Verifica si se ha seleccionado un elemento en el ComboBox cmbIDFab

                if (cmbNum_Rep.SelectedValue != null)

                {
                    cadenaSQL = "SELECT Nombre, Edad, Oficina_Rep, Titulo, Contrato, Director, Cuota, Ventas, EstadoRep FROM Rep_Ventas WHERE Num_Rep = " + numrep + "";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                    if (dr.Read())
                    {
                        txtNombre.Text = dr["Nombre"].ToString();
                        nudEdad.Value = (int)dr["Edad"];
                        nudOficina.Value = (int)dr["Oficina"];
                        txtTitulo.Text = dr["Titulo"].ToString();
                        txtContra.Text = dr["Contrato"].ToString();
                        nudDirector.Value = (int)dr["Director"];
                        nudCuotas.Value = (int)dr["Cuota"];
                        nudVentas.Value = (int)dr["Ventas"];
                        nudEstado.Value = (int)dr["Estado"];
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

