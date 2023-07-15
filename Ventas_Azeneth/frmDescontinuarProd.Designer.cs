namespace Ventas_Azeneth
{
    partial class frmDescontinuarProd
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
            this.lblDes = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblExi = new System.Windows.Forms.Label();
            this.lblSta = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbIDFab = new System.Windows.Forms.ComboBox();
            this.cmbIDProd = new System.Windows.Forms.ComboBox();
            this.btnDescontinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDFab
            // 
            this.lblIDFab.AutoSize = true;
            this.lblIDFab.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFab.Location = new System.Drawing.Point(51, 28);
            this.lblIDFab.Name = "lblIDFab";
            this.lblIDFab.Size = new System.Drawing.Size(138, 18);
            this.lblIDFab.TabIndex = 0;
            this.lblIDFab.Text = "Clave del Fabricante";
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProd.Location = new System.Drawing.Point(51, 65);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(129, 18);
            this.lblIDProd.TabIndex = 1;
            this.lblIDProd.Text = "Clave del Producto";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(54, 100);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(85, 18);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "Descripción";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(54, 132);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(49, 18);
            this.lblPre.TabIndex = 3;
            this.lblPre.Text = "Precio";
            // 
            // lblExi
            // 
            this.lblExi.AutoSize = true;
            this.lblExi.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExi.Location = new System.Drawing.Point(54, 164);
            this.lblExi.Name = "lblExi";
            this.lblExi.Size = new System.Drawing.Size(78, 18);
            this.lblExi.TabIndex = 4;
            this.lblExi.Text = "Existencias";
            // 
            // lblSta
            // 
            this.lblSta.AutoSize = true;
            this.lblSta.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSta.Location = new System.Drawing.Point(51, 199);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(132, 18);
            this.lblSta.TabIndex = 5;
            this.lblSta.Text = "Estado de Producto";
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Location = new System.Drawing.Point(189, 103);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(0, 13);
            this.lblDescripción.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(189, 135);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblPrecio.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(189, 164);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(189, 202);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 9;
            // 
            // cmbIDFab
            // 
            this.cmbIDFab.FormattingEnabled = true;
            this.cmbIDFab.Location = new System.Drawing.Point(195, 25);
            this.cmbIDFab.Name = "cmbIDFab";
            this.cmbIDFab.Size = new System.Drawing.Size(171, 21);
            this.cmbIDFab.TabIndex = 10;
            this.cmbIDFab.SelectedIndexChanged += new System.EventHandler(this.cmbIDFab_SelectedIndexChanged);
            // 
            // cmbIDProd
            // 
            this.cmbIDProd.FormattingEnabled = true;
            this.cmbIDProd.Location = new System.Drawing.Point(195, 62);
            this.cmbIDProd.Name = "cmbIDProd";
            this.cmbIDProd.Size = new System.Drawing.Size(171, 21);
            this.cmbIDProd.TabIndex = 11;
            this.cmbIDProd.SelectedIndexChanged += new System.EventHandler(this.cmbIDProd_SelectedIndexChanged);
            // 
            // btnDescontinuar
            // 
            this.btnDescontinuar.Location = new System.Drawing.Point(115, 234);
            this.btnDescontinuar.Name = "btnDescontinuar";
            this.btnDescontinuar.Size = new System.Drawing.Size(191, 30);
            this.btnDescontinuar.TabIndex = 12;
            this.btnDescontinuar.Text = "Descontinuar";
            this.btnDescontinuar.UseVisualStyleBackColor = true;
            this.btnDescontinuar.Click += new System.EventHandler(this.btnDescontinuar_Click);
            // 
            // frmDescontinuarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 276);
            this.Controls.Add(this.btnDescontinuar);
            this.Controls.Add(this.cmbIDProd);
            this.Controls.Add(this.cmbIDFab);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.lblSta);
            this.Controls.Add(this.lblExi);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.lblIDFab);
            this.Name = "frmDescontinuarProd";
            this.Text = "frmDescontinuarProd";
            this.Load += new System.EventHandler(this.frmDescontinuarProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDFab;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblExi;
        private System.Windows.Forms.Label lblSta;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbIDFab;
        private System.Windows.Forms.ComboBox cmbIDProd;
        private System.Windows.Forms.Button btnDescontinuar;
    }
}