namespace tienda_dvd
{
    partial class Proveedores
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
            this.grbNavegacionProveedor = new System.Windows.Forms.GroupBox();
            this.lblRegistrosProveedor = new System.Windows.Forms.Label();
            this.btnUltimoProveedor = new System.Windows.Forms.Button();
            this.btnPrimeroProveedor = new System.Windows.Forms.Button();
            this.btnSiguienteProveedor = new System.Windows.Forms.Button();
            this.btnAnteriorProveedor = new System.Windows.Forms.Button();
            this.grbEdicionProveedor = new System.Windows.Forms.GroupBox();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.grbDatosProveedor = new System.Windows.Forms.GroupBox();
            this.cbxEstatusProveedor = new System.Windows.Forms.ComboBox();
            this.cbxMonedaProveedor = new System.Windows.Forms.ComboBox();
            this.cbxTipoProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProveedores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDatosProveedores = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscarProveedor = new System.Windows.Forms.Label();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbNavegacionProveedor.SuspendLayout();
            this.grbEdicionProveedor.SuspendLayout();
            this.grbDatosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNavegacionProveedor
            // 
            this.grbNavegacionProveedor.BackColor = System.Drawing.Color.White;
            this.grbNavegacionProveedor.Controls.Add(this.lblRegistrosProveedor);
            this.grbNavegacionProveedor.Controls.Add(this.btnUltimoProveedor);
            this.grbNavegacionProveedor.Controls.Add(this.btnPrimeroProveedor);
            this.grbNavegacionProveedor.Controls.Add(this.btnSiguienteProveedor);
            this.grbNavegacionProveedor.Controls.Add(this.btnAnteriorProveedor);
            this.grbNavegacionProveedor.Location = new System.Drawing.Point(506, 355);
            this.grbNavegacionProveedor.Name = "grbNavegacionProveedor";
            this.grbNavegacionProveedor.Size = new System.Drawing.Size(317, 65);
            this.grbNavegacionProveedor.TabIndex = 61;
            this.grbNavegacionProveedor.TabStop = false;
            this.grbNavegacionProveedor.Text = "Navegacion";
            // 
            // lblRegistrosProveedor
            // 
            this.lblRegistrosProveedor.AutoSize = true;
            this.lblRegistrosProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosProveedor.Location = new System.Drawing.Point(123, 29);
            this.lblRegistrosProveedor.Name = "lblRegistrosProveedor";
            this.lblRegistrosProveedor.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosProveedor.TabIndex = 48;
            this.lblRegistrosProveedor.Text = "x de n";
            // 
            // btnUltimoProveedor
            // 
            this.btnUltimoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoProveedor.Location = new System.Drawing.Point(249, 14);
            this.btnUltimoProveedor.Name = "btnUltimoProveedor";
            this.btnUltimoProveedor.Size = new System.Drawing.Size(35, 45);
            this.btnUltimoProveedor.TabIndex = 47;
            this.btnUltimoProveedor.Text = ">|";
            this.btnUltimoProveedor.UseVisualStyleBackColor = true;
            this.btnUltimoProveedor.Click += new System.EventHandler(this.btnUltimoProveedor_Click);
            // 
            // btnPrimeroProveedor
            // 
            this.btnPrimeroProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroProveedor.Location = new System.Drawing.Point(15, 14);
            this.btnPrimeroProveedor.Name = "btnPrimeroProveedor";
            this.btnPrimeroProveedor.Size = new System.Drawing.Size(35, 45);
            this.btnPrimeroProveedor.TabIndex = 46;
            this.btnPrimeroProveedor.Text = "|<";
            this.btnPrimeroProveedor.UseVisualStyleBackColor = true;
            this.btnPrimeroProveedor.Click += new System.EventHandler(this.btnPrimeroProveedor_Click);
            // 
            // btnSiguienteProveedor
            // 
            this.btnSiguienteProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteProveedor.Location = new System.Drawing.Point(206, 13);
            this.btnSiguienteProveedor.Name = "btnSiguienteProveedor";
            this.btnSiguienteProveedor.Size = new System.Drawing.Size(37, 45);
            this.btnSiguienteProveedor.TabIndex = 42;
            this.btnSiguienteProveedor.Text = "⮕ ";
            this.btnSiguienteProveedor.UseVisualStyleBackColor = true;
            this.btnSiguienteProveedor.Click += new System.EventHandler(this.btnSiguienteProveedor_Click);
            // 
            // btnAnteriorProveedor
            // 
            this.btnAnteriorProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorProveedor.Location = new System.Drawing.Point(56, 14);
            this.btnAnteriorProveedor.Name = "btnAnteriorProveedor";
            this.btnAnteriorProveedor.Size = new System.Drawing.Size(39, 45);
            this.btnAnteriorProveedor.TabIndex = 41;
            this.btnAnteriorProveedor.Text = "⬅";
            this.btnAnteriorProveedor.UseVisualStyleBackColor = true;
            this.btnAnteriorProveedor.Click += new System.EventHandler(this.btnAnteriorProveedor_Click);
            // 
            // grbEdicionProveedor
            // 
            this.grbEdicionProveedor.BackColor = System.Drawing.Color.White;
            this.grbEdicionProveedor.Controls.Add(this.btnEliminarProveedor);
            this.grbEdicionProveedor.Controls.Add(this.btnModificarProveedor);
            this.grbEdicionProveedor.Controls.Add(this.btnNuevoProveedor);
            this.grbEdicionProveedor.Location = new System.Drawing.Point(31, 355);
            this.grbEdicionProveedor.Name = "grbEdicionProveedor";
            this.grbEdicionProveedor.Size = new System.Drawing.Size(359, 57);
            this.grbEdicionProveedor.TabIndex = 60;
            this.grbEdicionProveedor.TabStop = false;
            this.grbEdicionProveedor.Text = "Edicion";
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(221, 12);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(91, 33);
            this.btnEliminarProveedor.TabIndex = 37;
            this.btnEliminarProveedor.Text = "Eliminar ";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedor.Location = new System.Drawing.Point(124, 12);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(91, 33);
            this.btnModificarProveedor.TabIndex = 36;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.Location = new System.Drawing.Point(27, 12);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(91, 33);
            this.btnNuevoProveedor.TabIndex = 35;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // grbDatosProveedor
            // 
            this.grbDatosProveedor.BackColor = System.Drawing.Color.White;
            this.grbDatosProveedor.Controls.Add(this.cbxEstatusProveedor);
            this.grbDatosProveedor.Controls.Add(this.cbxMonedaProveedor);
            this.grbDatosProveedor.Controls.Add(this.cbxTipoProveedor);
            this.grbDatosProveedor.Controls.Add(this.label5);
            this.grbDatosProveedor.Controls.Add(this.txtTelefonoProveedor);
            this.grbDatosProveedor.Controls.Add(this.label4);
            this.grbDatosProveedor.Controls.Add(this.label3);
            this.grbDatosProveedor.Controls.Add(this.label2);
            this.grbDatosProveedor.Controls.Add(this.txtNombreProveedores);
            this.grbDatosProveedor.Controls.Add(this.label1);
            this.grbDatosProveedor.Enabled = false;
            this.grbDatosProveedor.Location = new System.Drawing.Point(27, 67);
            this.grbDatosProveedor.Name = "grbDatosProveedor";
            this.grbDatosProveedor.Size = new System.Drawing.Size(396, 251);
            this.grbDatosProveedor.TabIndex = 59;
            this.grbDatosProveedor.TabStop = false;
            this.grbDatosProveedor.Text = "Datos Proveedores";
            // 
            // cbxEstatusProveedor
            // 
            this.cbxEstatusProveedor.FormattingEnabled = true;
            this.cbxEstatusProveedor.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstatusProveedor.Location = new System.Drawing.Point(101, 187);
            this.cbxEstatusProveedor.Name = "cbxEstatusProveedor";
            this.cbxEstatusProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxEstatusProveedor.TabIndex = 37;
            // 
            // cbxMonedaProveedor
            // 
            this.cbxMonedaProveedor.FormattingEnabled = true;
            this.cbxMonedaProveedor.Items.AddRange(new object[] {
            " (USD) - $",
            " (EUR) - €",
            "(JPY) - ¥",
            " (GBP) - £"});
            this.cbxMonedaProveedor.Location = new System.Drawing.Point(101, 140);
            this.cbxMonedaProveedor.Name = "cbxMonedaProveedor";
            this.cbxMonedaProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxMonedaProveedor.TabIndex = 36;
            // 
            // cbxTipoProveedor
            // 
            this.cbxTipoProveedor.FormattingEnabled = true;
            this.cbxTipoProveedor.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.cbxTipoProveedor.Location = new System.Drawing.Point(114, 54);
            this.cbxTipoProveedor.Name = "cbxTipoProveedor";
            this.cbxTipoProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoProveedor.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Estatus:";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(114, 98);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(249, 20);
            this.txtTelefonoProveedor.TabIndex = 33;
            this.txtTelefonoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Moneda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tipo:";
            // 
            // txtNombreProveedores
            // 
            this.txtNombreProveedores.Location = new System.Drawing.Point(112, 17);
            this.txtNombreProveedores.Name = "txtNombreProveedores";
            this.txtNombreProveedores.Size = new System.Drawing.Size(278, 20);
            this.txtNombreProveedores.TabIndex = 27;
            this.txtNombreProveedores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            // 
            // grdDatosProveedores
            // 
            this.grdDatosProveedores.AllowUserToAddRows = false;
            this.grdDatosProveedores.AllowUserToDeleteRows = false;
            this.grdDatosProveedores.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grdDatosProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.nombre,
            this.tipo,
            this.telefono,
            this.moneda,
            this.Estatus});
            this.grdDatosProveedores.Location = new System.Drawing.Point(440, 105);
            this.grdDatosProveedores.Name = "grdDatosProveedores";
            this.grdDatosProveedores.ReadOnly = true;
            this.grdDatosProveedores.Size = new System.Drawing.Size(529, 213);
            this.grdDatosProveedores.TabIndex = 62;
            this.grdDatosProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosProveedores_CellClick);
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "idProveedor";
            this.IdProveedor.HeaderText = "IDpro";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "moneda";
            this.moneda.HeaderText = "MONEDA";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "Estatus";
            this.Estatus.HeaderText = "ESTATUS";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // lblBuscarProveedor
            // 
            this.lblBuscarProveedor.AutoSize = true;
            this.lblBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProveedor.Location = new System.Drawing.Point(458, 77);
            this.lblBuscarProveedor.Name = "lblBuscarProveedor";
            this.lblBuscarProveedor.Size = new System.Drawing.Size(70, 20);
            this.lblBuscarProveedor.TabIndex = 63;
            this.lblBuscarProveedor.Text = "Buscar:";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(534, 79);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(398, 20);
            this.txtBuscarProveedor.TabIndex = 64;
            this.txtBuscarProveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProveedor_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(345, 38);
            this.label6.TabIndex = 38;
            this.label6.Text = "Gestion de Proveedores";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBuscarProveedor);
            this.Controls.Add(this.txtBuscarProveedor);
            this.Controls.Add(this.grdDatosProveedores);
            this.Controls.Add(this.grbNavegacionProveedor);
            this.Controls.Add(this.grbEdicionProveedor);
            this.Controls.Add(this.grbDatosProveedor);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.grbNavegacionProveedor.ResumeLayout(false);
            this.grbNavegacionProveedor.PerformLayout();
            this.grbEdicionProveedor.ResumeLayout(false);
            this.grbDatosProveedor.ResumeLayout(false);
            this.grbDatosProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacionProveedor;
        private System.Windows.Forms.Label lblRegistrosProveedor;
        private System.Windows.Forms.Button btnUltimoProveedor;
        private System.Windows.Forms.Button btnPrimeroProveedor;
        private System.Windows.Forms.Button btnSiguienteProveedor;
        private System.Windows.Forms.Button btnAnteriorProveedor;
        private System.Windows.Forms.GroupBox grbEdicionProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.GroupBox grbDatosProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEstatusProveedor;
        private System.Windows.Forms.ComboBox cbxMonedaProveedor;
        private System.Windows.Forms.DataGridView grdDatosProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.Label lblBuscarProveedor;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label label6;
    }
}