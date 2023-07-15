namespace Ventas_Azeneth
{
    partial class FrmEliminarCliente1
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
            this.lblLim = new System.Windows.Forms.Label();
            this.lblIDRep = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblIDClie = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.txtLim = new System.Windows.Forms.TextBox();
            this.txtNumRep = new System.Windows.Forms.TextBox();
            this.cmbIDClie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLim
            // 
            this.lblLim.AutoSize = true;
            this.lblLim.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.lblLim.Location = new System.Drawing.Point(66, 142);
            this.lblLim.Name = "lblLim";
            this.lblLim.Size = new System.Drawing.Size(105, 23);
            this.lblLim.TabIndex = 23;
            this.lblLim.Text = "Limite de Credito";
            // 
            // lblIDRep
            // 
            this.lblIDRep.AutoSize = true;
            this.lblIDRep.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.lblIDRep.Location = new System.Drawing.Point(66, 69);
            this.lblIDRep.Name = "lblIDRep";
            this.lblIDRep.Size = new System.Drawing.Size(152, 23);
            this.lblIDRep.TabIndex = 22;
            this.lblIDRep.Text = "Nombre de Representante";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.lblEmp.Location = new System.Drawing.Point(66, 104);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(57, 23);
            this.lblEmp.TabIndex = 21;
            this.lblEmp.Text = "Empresa";
            // 
            // lblIDClie
            // 
            this.lblIDClie.AutoSize = true;
            this.lblIDClie.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.lblIDClie.Location = new System.Drawing.Point(66, 31);
            this.lblIDClie.Name = "lblIDClie";
            this.lblIDClie.Size = new System.Drawing.Size(112, 23);
            this.lblIDClie.TabIndex = 20;
            this.lblIDClie.Text = "Numero de Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Eliminar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(243, 108);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(132, 20);
            this.txtEmp.TabIndex = 35;
            // 
            // txtLim
            // 
            this.txtLim.Location = new System.Drawing.Point(245, 146);
            this.txtLim.Name = "txtLim";
            this.txtLim.Size = new System.Drawing.Size(132, 20);
            this.txtLim.TabIndex = 36;
            // 
            // txtNumRep
            // 
            this.txtNumRep.Location = new System.Drawing.Point(243, 73);
            this.txtNumRep.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumRep.Name = "txtNumRep";
            this.txtNumRep.Size = new System.Drawing.Size(126, 20);
            this.txtNumRep.TabIndex = 39;
            // 
            // cmbIDClie
            // 
            this.cmbIDClie.Location = new System.Drawing.Point(245, 31);
            this.cmbIDClie.Name = "cmbIDClie";
            this.cmbIDClie.Size = new System.Drawing.Size(124, 20);
            this.cmbIDClie.TabIndex = 40;
            // 
            // FrmEliminarCliente1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 287);
            this.Controls.Add(this.cmbIDClie);
            this.Controls.Add(this.txtNumRep);
            this.Controls.Add(this.txtLim);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLim);
            this.Controls.Add(this.lblIDRep);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblIDClie);
            this.Name = "FrmEliminarCliente1";
            this.Text = "FrmEliminarCliente1";
            this.Load += new System.EventHandler(this.FrmEliminarCliente1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLim;
        private System.Windows.Forms.Label lblIDRep;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblIDClie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.TextBox txtLim;
        private System.Windows.Forms.TextBox txtNumRep;
        private System.Windows.Forms.TextBox cmbIDClie;
    }
}