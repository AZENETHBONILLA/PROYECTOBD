namespace Ventas_Azeneth
{
    partial class FrmAltaClientes
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
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblIDRep = new System.Windows.Forms.Label();
            this.lblLim = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.nudCred = new System.Windows.Forms.NumericUpDown();
            this.txtIDRep = new System.Windows.Forms.TextBox();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.txtIDClie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCred)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDClie
            // 
            this.lblIDClie.AutoSize = true;
            this.lblIDClie.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDClie.Location = new System.Drawing.Point(59, 35);
            this.lblIDClie.Name = "lblIDClie";
            this.lblIDClie.Size = new System.Drawing.Size(93, 19);
            this.lblIDClie.TabIndex = 0;
            this.lblIDClie.Text = "Numero de Cliente";
            this.lblIDClie.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F);
            this.lblEmp.Location = new System.Drawing.Point(59, 69);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(48, 19);
            this.lblEmp.TabIndex = 1;
            this.lblEmp.Text = "Empresa";
            // 
            // lblIDRep
            // 
            this.lblIDRep.AutoSize = true;
            this.lblIDRep.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F);
            this.lblIDRep.Location = new System.Drawing.Point(59, 107);
            this.lblIDRep.Name = "lblIDRep";
            this.lblIDRep.Size = new System.Drawing.Size(126, 19);
            this.lblIDRep.TabIndex = 2;
            this.lblIDRep.Text = "Numero de Representante";
            // 
            // lblLim
            // 
            this.lblLim.AutoSize = true;
            this.lblLim.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F);
            this.lblLim.Location = new System.Drawing.Point(59, 144);
            this.lblLim.Name = "lblLim";
            this.lblLim.Size = new System.Drawing.Size(86, 19);
            this.lblLim.TabIndex = 3;
            this.lblLim.Text = "Limite de Credito";
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(168, 69);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(134, 20);
            this.txtEmp.TabIndex = 5;
            this.txtEmp.TextChanged += new System.EventHandler(this.txtEmp_TextChanged);
            // 
            // nudCred
            // 
            this.nudCred.Location = new System.Drawing.Point(203, 146);
            this.nudCred.Name = "nudCred";
            this.nudCred.Size = new System.Drawing.Size(134, 20);
            this.nudCred.TabIndex = 7;
            // 
            // txtIDRep
            // 
            this.txtIDRep.Location = new System.Drawing.Point(203, 108);
            this.txtIDRep.Name = "txtIDRep";
            this.txtIDRep.Size = new System.Drawing.Size(134, 20);
            this.txtIDRep.TabIndex = 6;
            // 
            // btnProc
            // 
            this.btnProc.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F);
            this.btnProc.Location = new System.Drawing.Point(220, 183);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(107, 54);
            this.btnProc.TabIndex = 9;
            this.btnProc.Text = "Guardar con Procedimiento";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIns
            // 
            this.btnIns.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F);
            this.btnIns.Location = new System.Drawing.Point(77, 186);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(122, 33);
            this.btnIns.TabIndex = 8;
            this.btnIns.Text = "Guardar con insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // txtIDClie
            // 
            this.txtIDClie.Location = new System.Drawing.Point(168, 36);
            this.txtIDClie.Name = "txtIDClie";
            this.txtIDClie.Size = new System.Drawing.Size(134, 20);
            this.txtIDClie.TabIndex = 4;
            // 
            // FrmAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 249);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.nudCred);
            this.Controls.Add(this.txtIDRep);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.txtIDClie);
            this.Controls.Add(this.lblLim);
            this.Controls.Add(this.lblIDRep);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblIDClie);
            this.Name = "FrmAltaClientes";
            this.Text = "FrmAltaClientes";
            this.Load += new System.EventHandler(this.FrmAltaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDClie;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblIDRep;
        private System.Windows.Forms.Label lblLim;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.NumericUpDown nudCred;
        private System.Windows.Forms.TextBox txtIDRep;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.TextBox txtIDClie;
    }
}