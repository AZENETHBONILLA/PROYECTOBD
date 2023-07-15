namespace Ventas_Azeneth
{
    partial class FrmActualizarClientes
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
            this.lblIDClie = new System.Windows.Forms.Label();
            this.nudCred = new System.Windows.Forms.NumericUpDown();
            this.lblLim = new System.Windows.Forms.Label();
            this.lblIDRep = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNumClie = new System.Windows.Forms.ComboBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCred)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDClie
            // 
            this.lblIDClie.AutoSize = true;
            this.lblIDClie.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.lblIDClie.Location = new System.Drawing.Point(50, 53);
            this.lblIDClie.Name = "lblIDClie";
            this.lblIDClie.Size = new System.Drawing.Size(112, 23);
            this.lblIDClie.TabIndex = 1;
            this.lblIDClie.Text = "Nombre de Cliente";
            // 
            // nudCred
            // 
            this.nudCred.Location = new System.Drawing.Point(207, 131);
            this.nudCred.Name = "nudCred";
            this.nudCred.Size = new System.Drawing.Size(220, 20);
            this.nudCred.TabIndex = 14;
            // 
            // lblLim
            // 
            this.lblLim.AutoSize = true;
            this.lblLim.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.lblLim.Location = new System.Drawing.Point(50, 126);
            this.lblLim.Name = "lblLim";
            this.lblLim.Size = new System.Drawing.Size(105, 23);
            this.lblLim.TabIndex = 10;
            this.lblLim.Text = "Limite de Credito";
            // 
            // lblIDRep
            // 
            this.lblIDRep.AutoSize = true;
            this.lblIDRep.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.lblIDRep.Location = new System.Drawing.Point(49, 87);
            this.lblIDRep.Name = "lblIDRep";
            this.lblIDRep.Size = new System.Drawing.Size(152, 23);
            this.lblIDRep.TabIndex = 9;
            this.lblIDRep.Text = "Nombre de Representante";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(171, 239);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(147, 34);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.lblStatus.Location = new System.Drawing.Point(51, 174);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 23);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Estado de Cliente";
            // 
            // lblSta
            // 
            this.lblSta.AutoSize = true;
            this.lblSta.Location = new System.Drawing.Point(262, 181);
            this.lblSta.Name = "lblSta";
            this.lblSta.Size = new System.Drawing.Size(0, 13);
            this.lblSta.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Actualizar Clientes";
            // 
            // cmbNumClie
            // 
            this.cmbNumClie.FormattingEnabled = true;
            this.cmbNumClie.Location = new System.Drawing.Point(207, 53);
            this.cmbNumClie.Name = "cmbNumClie";
            this.cmbNumClie.Size = new System.Drawing.Size(220, 21);
            this.cmbNumClie.TabIndex = 23;
            this.cmbNumClie.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(208, 88);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(219, 21);
            this.cmbNombre.TabIndex = 24;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // FrmActualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 285);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.cmbNumClie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSta);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.nudCred);
            this.Controls.Add(this.lblLim);
            this.Controls.Add(this.lblIDRep);
            this.Controls.Add(this.lblIDClie);
            this.Name = "FrmActualizarClientes";
            this.Text = "FrmActualizarClientes";
            this.Load += new System.EventHandler(this.FrmActualizarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDClie;
        private System.Windows.Forms.NumericUpDown nudCred;
        private System.Windows.Forms.Label lblLim;
        private System.Windows.Forms.Label lblIDRep;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNumClie;
        private System.Windows.Forms.ComboBox cmbNombre;
    }
}