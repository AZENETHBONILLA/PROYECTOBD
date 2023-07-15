using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_Azeneth
{
    class BaseSQL
    {
        //Se llama la clase SqlConnection y se intancia en un nuevo objeto llamado "conn"
        //Se requiere agregar la librería "using System.Data.SqlClient"
        SqlConnection conn = new SqlConnection();

        //Se declara publica la clase BaseSQL, que es la que llamará la conexión
        public BaseSQL()
        {
            //Invoca el método conectar
            conectar();
        }

        //El método conectar no devuelve ningún valor por lo que se declara como vacio (void)

        void conectar()
        {
            //Se asigna a "conn" la cadena de conexión con el servidor de SQL Server
            //"Data Source=nombre del servidor; Initial Catalog=Nombre de la base de datos; User ID=Usuario que se conecta a la BD; Password= Clave del usuario
            //Persist Security Info=True indica que se requiere autenticación 

            conn.ConnectionString = "Data Source=AZENETHBONILLA;Initial Catalog=Empresa_AzenethBF; User ID = AzenethBF; Password=Azeneth1;";

            // Si el estado de conexión de SQL Server está cerrado, se abre
            if(conn.State==System.Data.ConnectionState.Closed) {
                //abre la conexión con el servidor SQL
                conn.Open();
            }
        }

        //Aquí se declaran los métodos más comunes que se utilizarán en el formulario para no repetir los códigos cada vez que se utilizen
        //El método "Ejecutar" se usa para ejecutar cláusulas (insert, update, delete) pasando la cadena de la sentencia SQL y la conexión al comando "ExecuteReader()"

        public void ejecutar(string Sqltexto)
        {
            SqlCommand command = new SqlCommand(Sqltexto, conn);
            command.ExecuteNonQuery();
        }

        //El método "ConsultaSQL" se usa para ejecutar claúsulas (select) pasan la cadena de sentencia SQL y la conexión al comando "ExecuteReader()"
        public SqlDataReader ConsultaSQL (string Sqltexto)
        {
            SqlCommand command1 = new SqlCommand(Sqltexto, conn);
            return command1.ExecuteReader();
        }

        //El método "LeerDatos" se utiliza para ejecutar una consulta SELECT y los resultados en un objeto BindingSource.
        
        public BindingSource LeerDatos(string Sqltexto)
        {
            BindingSource bindingSource1 = new BindingSource();

            //Se crea un nuevo objeto SqlCommand con la consulta SQL y la conexión establecida
            SqlCommand command1 = new SqlCommand(Sqltexto, conn);

            //Se crea un objeto SqlDataAdapter para adaptar los resultados de la consulta
            SqlDataAdapter adapter = new SqlDataAdapter();

            //Se asigna el comando SqlCommand al objeto SqlDataAdapter.
            adapter.SelectCommand = command1;

            //Se crea un nuevo objeto DataTable para almacenar los resultados de la consulta.
            DataTable table = new DataTable();

            //Se establece la configuración regional del DataTable
            table.Locale = System.Globalization.CultureInfo.InstalledUICulture;

            //Se llena el DataTable con los resultados de la consulta utilizando el objeto SqlData Adapter
            adapter.Fill(table);

            //Se asigna el DataTable al objeto BindingSource.
            bindingSource1.DataSource = table;  

            //Se devuelve el objeto BindingSource con los resultados de la consulta
            return bindingSource1;

        } 
        //El método "LlenarCombo" se usa para leer datos de una consulta select y llenar un objeto ComboBox con los resultados
        //se pasa la cadena de Texto  y el nombre del objetos

        public void llenargrid(string Sqltexto, DataGridView dg)
        {
            dg.DataSource = LeerDatos(Sqltexto); 
        }
    }
}
