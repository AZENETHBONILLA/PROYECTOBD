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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //Establecer el formulario principal como contenedor MDI
            this.IsMdiContainer = true;
        }

        private void aLTADEINVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciamos el formulario para usarlo
            FrmAltaProductos f = new FrmAltaProductos();
            //le indicamos que correcta dentro del  contenedor
            f.MdiParent = this;
            //Le indicamos que corra
            f.Show();
        }

        private void dESCONTINUARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDescontinuarProd f = new frmDescontinuarProd();  
            f.MdiParent = this; 
            f.Show();   
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
 
        }

        private void aCTUALIZARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarProducto f = new FrmActualizarProducto();
            f.MdiParent = this;
            f.Show();
        }

        private void eLIMINARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmEliminarProd f = new frmEliminarProd();
            f.MdiParent = this;
            f.Show();
        }

        private void cONSULTARPRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryProductos f = new FrmQueryProductos();
            f.MdiParent = this;
            f.Show();
        }

        private void aLTASCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaClientes f = new FrmAltaClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTUALIZARCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarClientes f = new FrmActualizarClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void eLIMINARCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarCliente1 f = new FrmEliminarCliente1();
            f.MdiParent = this;
            f.Show();
        }

        private void aLTASREPVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaRep_Ventas f = new frmAltaRep_Ventas();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTUALIZARREPVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarRep_Ventas f = new frmActualizarRep_Ventas();
            f.MdiParent = this;
            f.Show();
        }

        private void eLIMINARREPVENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarRep_Ventas f = new frmEliminarRep_Ventas();
            f.MdiParent = this;
            f.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aLTASOFICINASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltasOficinas f = new FrmAltasOficinas();
            f.MdiParent = this;
            f.Show();
        }

        private void cONTROLDEPAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagos f = new FrmPagos();
            f.MdiParent = this;
            f.Show();
        }

        private void lÍMITEDECREDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLimitedeCredito f = new FrmLimitedeCredito();
            f.MdiParent = this;
            f.Show();
        }

        private void aCTUALIZAROFICINASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarOficinas f = new FrmActualizarOficinas();
            f.MdiParent = this;
            f.Show();
        }

        private void aLTASPEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos f = new FrmPedidos();
            f.MdiParent = this;
            f.Show();
        }

        private void eLIMINAROFICINASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarOficinas f = new FrmEliminarOficinas();
            f.MdiParent = this;
            f.Show();
        }
    }
}
