namespace tienda_dvd
{
    partial class Clientes
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
            this.grbNavegacionClientes = new System.Windows.Forms.GroupBox();
            this.lblRegistrosClientes = new System.Windows.Forms.Label();
            this.btnUltimoClientes = new System.Windows.Forms.Button();
            this.btnPrimeroClientes = new System.Windows.Forms.Button();
            this.btnSiguienteClientes = new System.Windows.Forms.Button();
            this.btnAnteriorClientes = new System.Windows.Forms.Button();
            this.grbEdicionClientes = new System.Windows.Forms.GroupBox();
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.grbDatosClientes = new System.Windows.Forms.GroupBox();
            this.txtTelefonoClientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreoClientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccionClientes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreClientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBuscarClientes = new System.Windows.Forms.Label();
            this.txtBuscarClientes = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDatosClientes = new System.Windows.Forms.DataGridView();
            this.grbNavegacionClientes.SuspendLayout();
            this.grbEdicionClientes.SuspendLayout();
            this.grbDatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNavegacionClientes
            // 
            this.grbNavegacionClientes.BackColor = System.Drawing.Color.White;
            this.grbNavegacionClientes.Controls.Add(this.lblRegistrosClientes);
            this.grbNavegacionClientes.Controls.Add(this.btnUltimoClientes);
            this.grbNavegacionClientes.Controls.Add(this.btnPrimeroClientes);
            this.grbNavegacionClientes.Controls.Add(this.btnSiguienteClientes);
            this.grbNavegacionClientes.Controls.Add(this.btnAnteriorClientes);
            this.grbNavegacionClientes.Location = new System.Drawing.Point(503, 353);
            this.grbNavegacionClientes.Name = "grbNavegacionClientes";
            this.grbNavegacionClientes.Size = new System.Drawing.Size(303, 65);
            this.grbNavegacionClientes.TabIndex = 58;
            this.grbNavegacionClientes.TabStop = false;
            this.grbNavegacionClientes.Text = "Navegacion";
            // 
            // lblRegistrosClientes
            // 
            this.lblRegistrosClientes.AutoSize = true;
            this.lblRegistrosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrosClientes.Location = new System.Drawing.Point(123, 29);
            this.lblRegistrosClientes.Name = "lblRegistrosClientes";
            this.lblRegistrosClientes.Size = new System.Drawing.Size(63, 24);
            this.lblRegistrosClientes.TabIndex = 48;
            this.lblRegistrosClientes.Text = "x de n";
            // 
            // btnUltimoClientes
            // 
            this.btnUltimoClientes.BackColor = System.Drawing.SystemColors.Window;
            this.btnUltimoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUltimoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoClientes.Location = new System.Drawing.Point(249, 14);
            this.btnUltimoClientes.Name = "btnUltimoClientes";
            this.btnUltimoClientes.Size = new System.Drawing.Size(35, 45);
            this.btnUltimoClientes.TabIndex = 47;
            this.btnUltimoClientes.Text = ">|";
            this.btnUltimoClientes.UseVisualStyleBackColor = false;
            this.btnUltimoClientes.Click += new System.EventHandler(this.btnUltimoClientes_Click);
            // 
            // btnPrimeroClientes
            // 
            this.btnPrimeroClientes.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrimeroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrimeroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroClientes.Location = new System.Drawing.Point(15, 14);
            this.btnPrimeroClientes.Name = "btnPrimeroClientes";
            this.btnPrimeroClientes.Size = new System.Drawing.Size(35, 45);
            this.btnPrimeroClientes.TabIndex = 46;
            this.btnPrimeroClientes.Text = "|<";
            this.btnPrimeroClientes.UseVisualStyleBackColor = false;
            this.btnPrimeroClientes.Click += new System.EventHandler(this.btnPrimeroClientes_Click);
            // 
            // btnSiguienteClientes
            // 
            this.btnSiguienteClientes.BackColor = System.Drawing.SystemColors.Window;
            this.btnSiguienteClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguienteClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteClientes.Location = new System.Drawing.Point(206, 13);
            this.btnSiguienteClientes.Name = "btnSiguienteClientes";
            this.btnSiguienteClientes.Size = new System.Drawing.Size(37, 45);
            this.btnSiguienteClientes.TabIndex = 42;
            this.btnSiguienteClientes.Text = "⮕ ";
            this.btnSiguienteClientes.UseVisualStyleBackColor = false;
            this.btnSiguienteClientes.Click += new System.EventHandler(this.btnSiguienteClientes_Click);
            // 
            // btnAnteriorClientes
            // 
            this.btnAnteriorClientes.BackColor = System.Drawing.SystemColors.Window;
            this.btnAnteriorClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnteriorClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorClientes.Location = new System.Drawing.Point(56, 14);
            this.btnAnteriorClientes.Name = "btnAnteriorClientes";
            this.btnAnteriorClientes.Size = new System.Drawing.Size(39, 45);
            this.btnAnteriorClientes.TabIndex = 41;
            this.btnAnteriorClientes.Text = "⬅";
            this.btnAnteriorClientes.UseVisualStyleBackColor = false;
            this.btnAnteriorClientes.Click += new System.EventHandler(this.btnAnteriorClientes_Click);
            // 
            // grbEdicionClientes
            // 
            this.grbEdicionClientes.BackColor = System.Drawing.Color.White;
            this.grbEdicionClientes.Controls.Add(this.btnEliminarClientes);
            this.grbEdicionClientes.Controls.Add(this.btnModificarCliente);
            this.grbEdicionClientes.Controls.Add(this.btnNuevoCliente);
            this.grbEdicionClientes.Location = new System.Drawing.Point(12, 350);
            this.grbEdicionClientes.Name = "grbEdicionClientes";
            this.grbEdicionClientes.Size = new System.Drawing.Size(359, 57);
            this.grbEdicionClientes.TabIndex = 57;
            this.grbEdicionClientes.TabStop = false;
            this.grbEdicionClientes.Text = "Edicion";
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClientes.Location = new System.Drawing.Point(221, 12);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(91, 33);
            this.btnEliminarClientes.TabIndex = 37;
            this.btnEliminarClientes.Text = "Eliminar ";
            this.btnEliminarClientes.UseVisualStyleBackColor = false;
            this.btnEliminarClientes.Click += new System.EventHandler(this.btnEliminarClientes_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(124, 12);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(91, 33);
            this.btnModificarCliente.TabIndex = 36;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(27, 12);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(91, 33);
            this.btnNuevoCliente.TabIndex = 35;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.Controls.Add(this.txtTelefonoClientes);
            this.grbDatosClientes.Controls.Add(this.label4);
            this.grbDatosClientes.Controls.Add(this.txtCorreoClientes);
            this.grbDatosClientes.Controls.Add(this.label3);
            this.grbDatosClientes.Controls.Add(this.txtDireccionClientes);
            this.grbDatosClientes.Controls.Add(this.label2);
            this.grbDatosClientes.Controls.Add(this.txtNombreClientes);
            this.grbDatosClientes.Controls.Add(this.label1);
            this.grbDatosClientes.Enabled = false;
            this.grbDatosClientes.Location = new System.Drawing.Point(12, 102);
            this.grbDatosClientes.Name = "grbDatosClientes";
            this.grbDatosClientes.Size = new System.Drawing.Size(374, 234);
            this.grbDatosClientes.TabIndex = 56;
            this.grbDatosClientes.TabStop = false;
            this.grbDatosClientes.Text = "Datos clientes";
            // 
            // txtTelefonoClientes
            // 
            this.txtTelefonoClientes.Location = new System.Drawing.Point(114, 178);
            this.txtTelefonoClientes.Name = "txtTelefonoClientes";
            this.txtTelefonoClientes.Size = new System.Drawing.Size(249, 20);
            this.txtTelefonoClientes.TabIndex = 33;
            this.txtTelefonoClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Telefono:";
            // 
            // txtCorreoClientes
            // 
            this.txtCorreoClientes.Location = new System.Drawing.Point(114, 118);
            this.txtCorreoClientes.Name = "txtCorreoClientes";
            this.txtCorreoClientes.Size = new System.Drawing.Size(249, 20);
            this.txtCorreoClientes.TabIndex = 31;
            this.txtCorreoClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Correo:";
            // 
            // txtDireccionClientes
            // 
            this.txtDireccionClientes.Location = new System.Drawing.Point(112, 69);
            this.txtDireccionClientes.Name = "txtDireccionClientes";
            this.txtDireccionClientes.Size = new System.Drawing.Size(249, 20);
            this.txtDireccionClientes.TabIndex = 29;
            this.txtDireccionClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Direccion:";
            // 
            // txtNombreClientes
            // 
            this.txtNombreClientes.Location = new System.Drawing.Point(112, 17);
            this.txtNombreClientes.Name = "txtNombreClientes";
            this.txtNombreClientes.Size = new System.Drawing.Size(249, 20);
            this.txtNombreClientes.TabIndex = 27;
            this.txtNombreClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 38);
            this.label6.TabIndex = 60;
            this.label6.Text = "Gestion de Clientes";
            // 
            // lblBuscarClientes
            // 
            this.lblBuscarClientes.AutoSize = true;
            this.lblBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarClientes.Location = new System.Drawing.Point(419, 66);
            this.lblBuscarClientes.Name = "lblBuscarClientes";
            this.lblBuscarClientes.Size = new System.Drawing.Size(70, 20);
            this.lblBuscarClientes.TabIndex = 34;
            this.lblBuscarClientes.Text = "Buscar:";
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.Location = new System.Drawing.Point(503, 66);
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Size = new System.Drawing.Size(442, 20);
            this.txtBuscarClientes.TabIndex = 34;
            this.txtBuscarClientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarClientes_KeyUp);
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "CORREO";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "IDCLIEN";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // grdDatosClientes
            // 
            this.grdDatosClientes.AllowUserToAddRows = false;
            this.grdDatosClientes.AllowUserToDeleteRows = false;
            this.grdDatosClientes.BackgroundColor = System.Drawing.Color.MistyRose;
            this.grdDatosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombre,
            this.direccion,
            this.telefono,
            this.correo});
            this.grdDatosClientes.Location = new System.Drawing.Point(423, 102);
            this.grdDatosClientes.Name = "grdDatosClientes";
            this.grdDatosClientes.ReadOnly = true;
            this.grdDatosClientes.Size = new System.Drawing.Size(522, 217);
            this.grdDatosClientes.TabIndex = 59;
            this.grdDatosClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosClientes_CellClick);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 430);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBuscarClientes);
            this.Controls.Add(this.txtBuscarClientes);
            this.Controls.Add(this.grdDatosClientes);
            this.Controls.Add(this.grbNavegacionClientes);
            this.Controls.Add(this.grbEdicionClientes);
            this.Controls.Add(this.grbDatosClientes);
            this.Name = "Clientes";
            this.Text = "Formulario Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.grbNavegacionClientes.ResumeLayout(false);
            this.grbNavegacionClientes.PerformLayout();
            this.grbEdicionClientes.ResumeLayout(false);
            this.grbDatosClientes.ResumeLayout(false);
            this.grbDatosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacionClientes;
        private System.Windows.Forms.Label lblRegistrosClientes;
        private System.Windows.Forms.Button btnUltimoClientes;
        private System.Windows.Forms.Button btnPrimeroClientes;
        private System.Windows.Forms.Button btnSiguienteClientes;
        private System.Windows.Forms.Button btnAnteriorClientes;
        private System.Windows.Forms.GroupBox grbEdicionClientes;
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.GroupBox grbDatosClientes;
        private System.Windows.Forms.TextBox txtTelefonoClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreoClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccionClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBuscarClientes;
        private System.Windows.Forms.TextBox txtBuscarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridView grdDatosClientes;
    }
}

