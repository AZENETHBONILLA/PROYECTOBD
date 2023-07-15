namespace Ventas_Azeneth
{
    partial class frmEliminarProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIDFab = new System.Windows.Forms.Label();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.lblIDes = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblExi = new System.Windows.Forms.Label();
            this.lblSta = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbIDFab = new System.Windows.Forms.ComboBox();
            this.cmbIDProd = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIDFab
            // 
            this.lblIDFab.AutoSize = true;
            this.lblIDFab.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblIDFab.Location = new System.Drawing.Point(75, 36);
            this.lblIDFab.Name = "lblIDFab";
            this.lblIDFab.Size = new System.Drawing.Size(129, 16);
            this.lblIDFab.TabIndex = 0;
            this.lblIDFab.Text = "Clave del Fabricante";
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblIDProd.Location = new System.Drawing.Point(75, 67);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(122, 16);
            this.lblIDProd.TabIndex = 1;
            this.lblIDProd.Text = "Clave del Producto";
            // 
            // lblIDes
            // 
            this.lblIDes.AutoSize = true;
            this.lblIDes.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblIDes.Location = new System.Drawing.Point(75, 105);
            this.lblIDes.Name = "lblIDes";
            this.lblIDes.Size = new System.Drawing.Size(78, 16);
            this.lblIDes.TabIndex = 2;
            this.lblIDes.Text = "Descripción";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblPre.Location = new System.Drawing.Point(78, 141);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(45, 16);
            this.lblPre.TabIndex = 3;
            this.lblPre.Text = "Precio";
            // 
            // lblExi
            // 
            this.lblExi.AutoSize = true;
            this.lblExi.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblExi.Location = new System.Drawing.Point(78, 178);
            this.lblExi.Name = "lblExi";
            this.lblExi.Size = new System.Drawing.Size(73, 16);
            this.lblExi.TabIndex = 4;
            this.lblExi.Text = "Existencias";
            // 
            // lblSta
            // 
            this.lblSta.AutoSize = true;
            this.lblSta.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblSta.Location = new System.Drawing.Point(75, 213);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(130, 16);
            this.lblSta.TabIndex = 5;
            this.lblSta.Text = "Estado del Producto";
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Location = new System.Drawing.Point(229, 105);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(0, 13);
            this.lblDescripción.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(229, 213);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 9;
            // 
            // cmbIDFab
            // 
            this.cmbIDFab.FormattingEnabled = true;
            this.cmbIDFab.Location = new System.Drawing.Point(222, 28);
            this.cmbIDFab.Name = "cmbIDFab";
            this.cmbIDFab.Size = new System.Drawing.Size(121, 21);
            this.cmbIDFab.TabIndex = 10;
            this.cmbIDFab.SelectedIndexChanged += new System.EventHandler(this.cmbIDFab_SelectedIndexChanged);
            // 
            // cmbIDProd
            // 
            this.cmbIDProd.FormattingEnabled = true;
            this.cmbIDProd.Location = new System.Drawing.Point(222, 64);
            this.cmbIDProd.Name = "cmbIDProd";
            this.cmbIDProd.Size = new System.Drawing.Size(121, 21);
            this.cmbIDProd.TabIndex = 11;
            this.cmbIDProd.SelectedIndexChanged += new System.EventHandler(this.cmbIDProd_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(115, 250);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(230, 143);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblPrecio.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(232, 177);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 14;
            // 
            // frmEliminarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 312);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbIDProd);
            this.Controls.Add(this.cmbIDFab);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.lblSta);
            this.Controls.Add(this.lblExi);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblIDes);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.lblIDFab);
            this.Name = "frmEliminarProd";
            this.Text = "frmEliminarProd";
            this.Load += new System.EventHandler(this.frmEliminarProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDFab;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.Label lblIDes;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblExi;
        private System.Windows.Forms.Label lblSta;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbIDFab;
        private System.Windows.Forms.ComboBox cmbIDProd;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
    }
}