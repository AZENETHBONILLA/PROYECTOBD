namespace Ventas_Azeneth
{
    partial class FrmLimitedeCredito
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNC = new System.Windows.Forms.TextBox();
            this.txtLC = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label2.Location = new System.Drawing.Point(56, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Límite de Crédito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label3.Location = new System.Drawing.Point(56, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label4.Location = new System.Drawing.Point(57, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diferencia";
            // 
            // txtNC
            // 
            this.txtNC.Location = new System.Drawing.Point(203, 30);
            this.txtNC.Name = "txtNC";
            this.txtNC.Size = new System.Drawing.Size(169, 20);
            this.txtNC.TabIndex = 4;
            // 
            // txtLC
            // 
            this.txtLC.Location = new System.Drawing.Point(203, 74);
            this.txtLC.Name = "txtLC";
            this.txtLC.Size = new System.Drawing.Size(169, 20);
            this.txtLC.TabIndex = 5;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(203, 111);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(169, 20);
            this.txtT.TabIndex = 6;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(203, 147);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(169, 20);
            this.txtD.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.button1.Location = new System.Drawing.Point(50, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar el pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.button2.Location = new System.Drawing.Point(221, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 58);
            this.button2.TabIndex = 9;
            this.button2.Text = "Guardar procedimiento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmLimitedeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.txtLC);
            this.Controls.Add(this.txtNC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLimitedeCredito";
            this.Text = "FrmLimitedePago";
            this.Load += new System.EventHandler(this.FrmLimitedePago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNC;
        private System.Windows.Forms.TextBox txtLC;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}