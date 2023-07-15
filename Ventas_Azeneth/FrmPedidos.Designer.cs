namespace Ventas_Azeneth
{
    partial class FrmPedidos
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
            this.dd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbventas = new System.Windows.Forms.ComboBox();
            this.txtnumcliente = new System.Windows.Forms.TextBox();
            this.lbloficina = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgdetalles = new System.Windows.Forms.DataGridView();
            this.idfab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFechapedido = new System.Windows.Forms.DateTimePicker();
            this.txtnumped = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.dd.Location = new System.Drawing.Point(73, 24);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(113, 23);
            this.dd.TabIndex = 0;
            this.dd.Text = "Numero de Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label2.Location = new System.Drawing.Point(73, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label3.Location = new System.Drawing.Point(73, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num. Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label4.Location = new System.Drawing.Point(73, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Representante de ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label5.Location = new System.Drawing.Point(73, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Oficina";
            // 
            // cmbventas
            // 
            this.cmbventas.FormattingEnabled = true;
            this.cmbventas.Location = new System.Drawing.Point(221, 122);
            this.cmbventas.Name = "cmbventas";
            this.cmbventas.Size = new System.Drawing.Size(224, 21);
            this.cmbventas.TabIndex = 8;
            this.cmbventas.SelectedIndexChanged += new System.EventHandler(this.cmbventas_SelectedIndexChanged);
            // 
            // txtnumcliente
            // 
            this.txtnumcliente.Location = new System.Drawing.Point(204, 92);
            this.txtnumcliente.Name = "txtnumcliente";
            this.txtnumcliente.Size = new System.Drawing.Size(201, 20);
            this.txtnumcliente.TabIndex = 9;
            this.txtnumcliente.TextChanged += new System.EventHandler(this.txtnumcliente_TextChanged);
            // 
            // lbloficina
            // 
            this.lbloficina.AutoSize = true;
            this.lbloficina.Location = new System.Drawing.Point(213, 158);
            this.lbloficina.Name = "lbloficina";
            this.lbloficina.Size = new System.Drawing.Size(0, 13);
            this.lbloficina.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.label8.Location = new System.Drawing.Point(324, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(386, 344);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.btnAgregar.Location = new System.Drawing.Point(283, 379);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 35);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Bodoni MT Condensed", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(399, 379);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgdetalles
            // 
            this.dgdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfab,
            this.Idproducto,
            this.Cantidad,
            this.Descripcion,
            this.Preciounitario,
            this.Importe});
            this.dgdetalles.Location = new System.Drawing.Point(23, 197);
            this.dgdetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgdetalles.Name = "dgdetalles";
            this.dgdetalles.RowHeadersWidth = 51;
            this.dgdetalles.RowTemplate.Height = 24;
            this.dgdetalles.Size = new System.Drawing.Size(528, 142);
            this.dgdetalles.TabIndex = 16;
            this.dgdetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdetalles_CellContentClick);
            // 
            // idfab
            // 
            this.idfab.HeaderText = "idfab";
            this.idfab.MinimumWidth = 6;
            this.idfab.Name = "idfab";
            this.idfab.Width = 125;
            // 
            // Idproducto
            // 
            this.Idproducto.HeaderText = "Idproducto";
            this.Idproducto.MinimumWidth = 6;
            this.Idproducto.Name = "Idproducto";
            this.Idproducto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Preciounitario
            // 
            this.Preciounitario.HeaderText = "Preciounitario";
            this.Preciounitario.MinimumWidth = 6;
            this.Preciounitario.Name = "Preciounitario";
            this.Preciounitario.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.Width = 125;
            // 
            // dtFechapedido
            // 
            this.dtFechapedido.Location = new System.Drawing.Point(204, 59);
            this.dtFechapedido.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechapedido.Name = "dtFechapedido";
            this.dtFechapedido.Size = new System.Drawing.Size(201, 20);
            this.dtFechapedido.TabIndex = 17;
            // 
            // txtnumped
            // 
            this.txtnumped.Location = new System.Drawing.Point(204, 27);
            this.txtnumped.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumped.Name = "txtnumped";
            this.txtnumped.Size = new System.Drawing.Size(201, 20);
            this.txtnumped.TabIndex = 18;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 428);
            this.Controls.Add(this.txtnumped);
            this.Controls.Add(this.dtFechapedido);
            this.Controls.Add(this.dgdetalles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbloficina);
            this.Controls.Add(this.txtnumcliente);
            this.Controls.Add(this.cmbventas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dd);
            this.Name = "FrmPedidos";
            this.Text = "FrmAltasPedidos";
            this.Load += new System.EventHandler(this.FrmAltasPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbventas;
        private System.Windows.Forms.TextBox txtnumcliente;
        private System.Windows.Forms.Label lbloficina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgdetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DateTimePicker dtFechapedido;
        private System.Windows.Forms.TextBox txtnumped;
    }
}