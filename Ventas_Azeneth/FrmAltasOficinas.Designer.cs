namespace Ventas_Azeneth
{
    partial class FrmAltasOficinas
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOficina = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.numObjetivo = new System.Windows.Forms.NumericUpDown();
            this.numVentas = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numObjetivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 16F);
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave de oficina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 16F);
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave de representante de dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT Condensed", 16F);
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT Condensed", 16F);
            this.label4.Location = new System.Drawing.Point(22, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Region";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT Condensed", 16F);
            this.label5.Location = new System.Drawing.Point(22, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Objetivo de ventas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bodoni MT Condensed", 16F);
            this.label6.Location = new System.Drawing.Point(22, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ventas Actuales";
            // 
            // txtOficina
            // 
            this.txtOficina.Location = new System.Drawing.Point(154, 43);
            this.txtOficina.Name = "txtOficina";
            this.txtOficina.Size = new System.Drawing.Size(206, 20);
            this.txtOficina.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(260, 79);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(100, 114);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(174, 20);
            this.txtCiudad.TabIndex = 8;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(100, 150);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(174, 20);
            this.txtRegion.TabIndex = 9;
            // 
            // numObjetivo
            // 
            this.numObjetivo.Location = new System.Drawing.Point(154, 190);
            this.numObjetivo.Name = "numObjetivo";
            this.numObjetivo.Size = new System.Drawing.Size(206, 20);
            this.numObjetivo.TabIndex = 10;
            // 
            // numVentas
            // 
            this.numVentas.Location = new System.Drawing.Point(154, 225);
            this.numVentas.Name = "numVentas";
            this.numVentas.Size = new System.Drawing.Size(206, 20);
            this.numVentas.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F);
            this.button1.Location = new System.Drawing.Point(63, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar por insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F);
            this.button2.Location = new System.Drawing.Point(197, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "Guardar por procedimiento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAltasOficinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numVentas);
            this.Controls.Add(this.numObjetivo);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtOficina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltasOficinas";
            this.Text = "FrmAltasOficinas";
            this.Load += new System.EventHandler(this.FrmAltasOficinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numObjetivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOficina;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.NumericUpDown numObjetivo;
        private System.Windows.Forms.NumericUpDown numVentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}