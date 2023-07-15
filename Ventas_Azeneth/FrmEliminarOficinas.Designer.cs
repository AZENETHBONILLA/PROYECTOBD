namespace Ventas_Azeneth
{
    partial class FrmEliminarOficinas
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.txtNum_Rep_Dir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar Oficinas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave de Oficina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave de Representante de Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(206, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Eliminar Oficina";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(250, 47);
            this.txtOficina.Margin = new System.Windows.Forms.Padding(2);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(233, 20);
            this.txtOficina.TabIndex = 15;
            // 
            // txtNum_Rep_Dir
            // 
            this.txtNum_Rep_Dir.Location = new System.Drawing.Point(250, 83);
            this.txtNum_Rep_Dir.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum_Rep_Dir.Name = "txtNum_Rep_Dir";
            this.txtNum_Rep_Dir.Size = new System.Drawing.Size(233, 20);
            this.txtNum_Rep_Dir.TabIndex = 17;
            // 
            // FrmEliminarOficinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 187);
            this.Controls.Add(this.txtNum_Rep_Dir);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmEliminarOficinas";
            this.Text = "FrmEliminarOficinas";
            this.Load += new System.EventHandler(this.FrmEliminarOficinas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.TextBox txtNum_Rep_Dir;
    }
}