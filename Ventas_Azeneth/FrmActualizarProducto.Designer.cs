namespace Ventas_Azeneth
{
    partial class FrmActualizarProducto
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
            this.cmbIDFab = new System.Windows.Forms.ComboBox();
            this.cmbIDProd = new System.Windows.Forms.ComboBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.nudPre = new System.Windows.Forms.NumericUpDown();
            this.nudExi = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDFab
            // 
            this.lblIDFab.AutoSize = true;
            this.lblIDFab.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblIDFab.Location = new System.Drawing.Point(60, 37);
            this.lblIDFab.Name = "lblIDFab";
            this.lblIDFab.Size = new System.Drawing.Size(129, 16);
            this.lblIDFab.TabIndex = 0;
            this.lblIDFab.Text = "Clave del Fabricante";
            this.lblIDFab.Click += new System.EventHandler(this.lblIDFab_Click);
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblIDProd.Location = new System.Drawing.Point(60, 69);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(122, 16);
            this.lblIDProd.TabIndex = 1;
            this.lblIDProd.Text = "Clave del Producto";
            this.lblIDProd.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIDes
            // 
            this.lblIDes.AutoSize = true;
            this.lblIDes.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblIDes.Location = new System.Drawing.Point(63, 105);
            this.lblIDes.Name = "lblIDes";
            this.lblIDes.Size = new System.Drawing.Size(78, 16);
            this.lblIDes.TabIndex = 2;
            this.lblIDes.Text = "Descripción";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblPre.Location = new System.Drawing.Point(63, 144);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(45, 16);
            this.lblPre.TabIndex = 3;
            this.lblPre.Text = "Precio";
            // 
            // lblExi
            // 
            this.lblExi.AutoSize = true;
            this.lblExi.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblExi.Location = new System.Drawing.Point(63, 176);
            this.lblExi.Name = "lblExi";
            this.lblExi.Size = new System.Drawing.Size(73, 16);
            this.lblExi.TabIndex = 4;
            this.lblExi.Text = "Existencias";
            this.lblExi.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSta
            // 
            this.lblSta.AutoSize = true;
            this.lblSta.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.lblSta.Location = new System.Drawing.Point(60, 222);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(128, 16);
            this.lblSta.TabIndex = 5;
            this.lblSta.Text = "Estado del producto";
            // 
            // cmbIDFab
            // 
            this.cmbIDFab.FormattingEnabled = true;
            this.cmbIDFab.Location = new System.Drawing.Point(195, 31);
            this.cmbIDFab.Name = "cmbIDFab";
            this.cmbIDFab.Size = new System.Drawing.Size(121, 21);
            this.cmbIDFab.TabIndex = 6;
            this.cmbIDFab.SelectedIndexChanged += new System.EventHandler(this.cmbIDFab_SelectedIndexChanged);
            // 
            // cmbIDProd
            // 
            this.cmbIDProd.FormattingEnabled = true;
            this.cmbIDProd.Location = new System.Drawing.Point(195, 66);
            this.cmbIDProd.Name = "cmbIDProd";
            this.cmbIDProd.Size = new System.Drawing.Size(121, 21);
            this.cmbIDProd.TabIndex = 7;
            this.cmbIDProd.SelectedIndexChanged += new System.EventHandler(this.cmbIDProd_SelectedIndexChanged);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(195, 102);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 20);
            this.txtDes.TabIndex = 8;
            // 
            // nudPre
            // 
            this.nudPre.Location = new System.Drawing.Point(195, 142);
            this.nudPre.Name = "nudPre";
            this.nudPre.Size = new System.Drawing.Size(120, 20);
            this.nudPre.TabIndex = 9;
            // 
            // nudExi
            // 
            this.nudExi.Location = new System.Drawing.Point(195, 174);
            this.nudExi.Name = "nudExi";
            this.nudExi.Size = new System.Drawing.Size(120, 20);
            this.nudExi.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(195, 222);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.btnActualizar.Location = new System.Drawing.Point(78, 270);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(237, 26);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar Registro";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.Actualizar_Click_Click);
            // 
            // FrmActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 331);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.nudExi);
            this.Controls.Add(this.nudPre);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.cmbIDProd);
            this.Controls.Add(this.cmbIDFab);
            this.Controls.Add(this.lblSta);
            this.Controls.Add(this.lblExi);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblIDes);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.lblIDFab);
            this.Name = "FrmActualizarProducto";
            this.Text = "FrmActualizarProducto";
            this.Load += new System.EventHandler(this.FrmActualizarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExi)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbIDFab;
        private System.Windows.Forms.ComboBox cmbIDProd;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.NumericUpDown nudPre;
        private System.Windows.Forms.NumericUpDown nudExi;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnActualizar;
    }
}