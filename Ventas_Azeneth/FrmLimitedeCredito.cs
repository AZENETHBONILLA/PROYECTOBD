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
    public partial class FrmLimitedeCredito : Form
    {
        public FrmLimitedeCredito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamada a la conexión de la base de datos que se encuentra en la clase BaseSQL, se instancia para su uso.
            BaseSQL objeto = new BaseSQL();

            //Se declara la variable cadena que contendrá la sentencia de sql a ejecutar:
            //Los objetos alfanumericos se declaran como  ´"+txtIDFab.Text + "'
            //Los objetos numericos se declaran como  '"+nudPre.Value+'"
            //Se usa  el signo + para concatenar el sql con los objetos de los cuales se extraerán los valores.

            String cadenaSQL = "";
            cadenaSQL = "INSERT INTO LIMITE_CREDITO_PEDIDOS_CLIENTE (Num_Cliente, Lim_Cred, Total, Diferencia) VALUES";
            cadenaSQL = cadenaSQL + "( '" + txtNC.Text + "', '" + txtLC.Text + "', '" + txtT.Text + "', '" + txtD.Text + "');";

            if (int.TryParse(txtLC.Text, out int lcValue))
            {
                if (lcValue > int.Parse(txtT.Text))
                {
                    try
                    {
                        //Se llama el metodo ejecutar que se encuentra en la clase "BaseSQL" y se le pasa el parametro con 
                        //la cadena que contiene el código sql
                        objeto.ejecutar(cadenaSQL);
                        MessageBox.Show("El registro se ha guardado correctamente");
                    }
                    catch (Exception ex)
                    {
                        //Se despliega el mensaje para indicar que el registro del producto se guardo correctamente.
                        MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
                    }
                }
                else
                {
                    MessageBox.Show("El total ingresado excede el límite de crédito");
                }
            }
            else
            {
                MessageBox.Show("El valor ingresado no es un número válido");
            }

            //Se limpian los objetos
            txtNC.Text = "";
            txtLC.Text = "";
            txtT.Text = "";
            txtD.Text = "";
        }

        private void FrmLimitedePago_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            String cadenaSQL = "";
            cadenaSQL = "AltasLCPC '" + txtNC.Text + "','" + txtLC.Text + "','" + txtT.Text + "','" + txtD + "'";

            if (int.TryParse(txtLC.Text, out int lcValue))
            {
                if (lcValue > int.Parse(txtT.Text))
                {
                    try
                    {
                        objeto.ejecutar(cadenaSQL);
                        MessageBox.Show("El registro se ha guardado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + cadenaSQL);
                    }
                }
                else
                {
                    MessageBox.Show("El total ingresado excede el límite de crédito");
                }
            }
            else
            {
                MessageBox.Show("El valor ingresado es un número válido");
            }

            //Se limpian los objetos
            txtNC.Text = "";
            txtLC.Text = "";
            txtT.Text = "";
            txtD.Text = "";
        }
    }
}
