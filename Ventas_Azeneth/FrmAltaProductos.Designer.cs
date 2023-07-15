namespace Ventas_Azeneth
{
    partial class FrmAltaProductos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDFab = new System.Windows.Forms.Label();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.lblIDes = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblExi = new System.Windows.Forms.Label();
            this.txtIDFab = new System.Windows.Forms.TextBox();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.NumericUpDown();
            this.txtExi = new System.Windows.Forms.NumericUpDown();
            this.btnlns = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDFab
            // 
            this.lblDFab.AutoSize = true;
            this.lblDFab.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDFab.Location = new System.Drawing.Point(55, 23);
            this.lblDFab.Name = "lblDFab";
            this.lblDFab.Size = new System.Drawing.Size(124, 18);
            this.lblDFab.TabIndex = 0;
            this.lblDFab.Text = "Clave del Fabricante";
            this.lblDFab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDFab.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProd.Location = new System.Drawing.Point(55, 49);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(115, 18);
            this.lblIDProd.TabIndex = 1;
            this.lblIDProd.Text = "Clave del Producto";
            // 
            // lblIDes
            // 
            this.lblIDes.AutoSize = true;
            this.lblIDes.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDes.Location = new System.Drawing.Point(52, 77);
            this.lblIDes.Name = "lblIDes";
            this.lblIDes.Size = new System.Drawing.Size(74, 18);
            this.lblIDes.TabIndex = 2;
            this.lblIDes.Text = "Descripción";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(51, 108);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(49, 19);
            this.lblPre.TabIndex = 3;
            this.lblPre.Text = "Precio";
            // 
            // lblExi
            // 
            this.lblExi.AutoSize = true;
            this.lblExi.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExi.Location = new System.Drawing.Point(51, 138);
            this.lblExi.Name = "lblExi";
            this.lblExi.Size = new System.Drawing.Size(74, 19);
            this.lblExi.TabIndex = 4;
            this.lblExi.Text = "Existencias";
            // 
            // txtIDFab
            // 
            this.txtIDFab.Location = new System.Drawing.Point(185, 23);
            this.txtIDFab.Name = "txtIDFab";
            this.txtIDFab.Size = new System.Drawing.Size(162, 20);
            this.txtIDFab.TabIndex = 5;
            this.txtIDFab.TextChanged += new System.EventHandler(this.txtIDFab_TextChanged);
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(185, 49);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(162, 20);
            this.txtIDProd.TabIndex = 6;
            this.txtIDProd.TextChanged += new System.EventHandler(this.txtIDProd_TextChanged);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(135, 75);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(212, 20);
            this.txtDes.TabIndex = 7;
            this.txtDes.TextChanged += new System.EventHandler(this.txtDes_TextChanged);
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(135, 107);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(212, 20);
            this.txtPre.TabIndex = 8;
            this.txtPre.ValueChanged += new System.EventHandler(this.txtPre_ValueChanged);
            // 
            // txtExi
            // 
            this.txtExi.Location = new System.Drawing.Point(135, 137);
            this.txtExi.Name = "txtExi";
            this.txtExi.Size = new System.Drawing.Size(212, 20);
            this.txtExi.TabIndex = 9;
            // 
            // btnlns
            // 
            this.btnlns.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlns.Location = new System.Drawing.Point(58, 175);
            this.btnlns.Name = "btnlns";
            this.btnlns.Size = new System.Drawing.Size(123, 49);
            this.btnlns.TabIndex = 10;
            this.btnlns.Text = "Guardar con Insert";
            this.btnlns.UseVisualStyleBackColor = true;
            this.btnlns.Click += new System.EventHandler(this.btnlns_Click);
            // 
            // btnProc
            // 
            this.btnProc.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProc.Location = new System.Drawing.Point(199, 175);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(148, 49);
            this.btnProc.TabIndex = 11;
            this.btnProc.Text = "Guardar con Procedimiento";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // FrmAltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 240);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnlns);
            this.Controls.Add(this.txtExi);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.txtIDFab);
            this.Controls.Add(this.lblExi);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblIDes);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.lblDFab);
            this.Name = "FrmAltaProductos";
            this.Text = "Inventario de Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDFab;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.Label lblIDes;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblExi;
        private System.Windows.Forms.TextBox txtIDFab;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.NumericUpDown txtPre;
        private System.Windows.Forms.NumericUpDown txtExi;
        private System.Windows.Forms.Button btnlns;
        private System.Windows.Forms.Button btnProc;
    }
}

