namespace database
{
    partial class Form1
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
            this.grbDatosAlumnos = new System.Windows.Forms.GroupBox();
            this.bdDUI = new System.Windows.Forms.Label();
            this.txtDUIalumno = new System.Windows.Forms.TextBox();
            this.bdTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.bdDireccionAlumnno = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.bdNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.BlCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbNavegacionAlumno1 = new System.Windows.Forms.GroupBox();
            this.grbDatosAlumnos.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosAlumnos
            // 
            this.grbDatosAlumnos.Controls.Add(this.bdDUI);
            this.grbDatosAlumnos.Controls.Add(this.txtDUIalumno);
            this.grbDatosAlumnos.Controls.Add(this.bdTelefonoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.bdDireccionAlumnno);
            this.grbDatosAlumnos.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumnos.Controls.Add(this.bdNombreAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumnos.Controls.Add(this.BlCodigoAlumno);
            this.grbDatosAlumnos.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumnos.Location = new System.Drawing.Point(31, 28);
            this.grbDatosAlumnos.Name = "grbDatosAlumnos";
            this.grbDatosAlumnos.Size = new System.Drawing.Size(493, 314);
            this.grbDatosAlumnos.TabIndex = 0;
            this.grbDatosAlumnos.TabStop = false;
            this.grbDatosAlumnos.Text = "DatosAlumnos";
            // 
            // bdDUI
            // 
            this.bdDUI.AutoSize = true;
            this.bdDUI.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDUI.Location = new System.Drawing.Point(12, 178);
            this.bdDUI.Name = "bdDUI";
            this.bdDUI.Size = new System.Drawing.Size(53, 21);
            this.bdDUI.TabIndex = 10;
            this.bdDUI.Text = "DUI:";
            // 
            // txtDUIalumno
            // 
            this.txtDUIalumno.Location = new System.Drawing.Point(71, 181);
            this.txtDUIalumno.Name = "txtDUIalumno";
            this.txtDUIalumno.Size = new System.Drawing.Size(183, 20);
            this.txtDUIalumno.TabIndex = 9;
            // 
            // bdTelefonoAlumno
            // 
            this.bdTelefonoAlumno.AutoSize = true;
            this.bdTelefonoAlumno.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdTelefonoAlumno.Location = new System.Drawing.Point(12, 140);
            this.bdTelefonoAlumno.Name = "bdTelefonoAlumno";
            this.bdTelefonoAlumno.Size = new System.Drawing.Size(92, 21);
            this.bdTelefonoAlumno.TabIndex = 8;
            this.bdTelefonoAlumno.Text = "Telefono:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(113, 143);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(183, 20);
            this.txtTelefonoAlumno.TabIndex = 7;
            // 
            // bdDireccionAlumnno
            // 
            this.bdDireccionAlumnno.AutoSize = true;
            this.bdDireccionAlumnno.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdDireccionAlumnno.Location = new System.Drawing.Point(12, 100);
            this.bdDireccionAlumnno.Name = "bdDireccionAlumnno";
            this.bdDireccionAlumnno.Size = new System.Drawing.Size(100, 21);
            this.bdDireccionAlumnno.TabIndex = 6;
            this.bdDireccionAlumnno.Text = "Direccion:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(130, 103);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(183, 20);
            this.txtDireccionAlumno.TabIndex = 5;
            this.txtDireccionAlumno.TextChanged += new System.EventHandler(this.txtDireccionAlumno_TextChanged);
            // 
            // bdNombreAlumno
            // 
            this.bdNombreAlumno.AutoSize = true;
            this.bdNombreAlumno.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdNombreAlumno.Location = new System.Drawing.Point(12, 64);
            this.bdNombreAlumno.Name = "bdNombreAlumno";
            this.bdNombreAlumno.Size = new System.Drawing.Size(76, 21);
            this.bdNombreAlumno.TabIndex = 4;
            this.bdNombreAlumno.Text = "Nombre";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(90, 64);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(183, 20);
            this.txtNombreAlumno.TabIndex = 3;
            // 
            // BlCodigoAlumno
            // 
            this.BlCodigoAlumno.AutoSize = true;
            this.BlCodigoAlumno.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlCodigoAlumno.Location = new System.Drawing.Point(12, 26);
            this.BlCodigoAlumno.Name = "BlCodigoAlumno";
            this.BlCodigoAlumno.Size = new System.Drawing.Size(72, 21);
            this.BlCodigoAlumno.TabIndex = 2;
            this.BlCodigoAlumno.Text = "Codigo:";
            this.BlCodigoAlumno.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(90, 26);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(183, 20);
            this.txtCodigoAlumno.TabIndex = 1;
            this.txtCodigoAlumno.TextChanged += new System.EventHandler(this.txtCodigoAlumno_TextChanged);
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.button3);
            this.grbNavegacionAlumno.Controls.Add(this.button4);
            this.grbNavegacionAlumno.Controls.Add(this.button2);
            this.grbNavegacionAlumno.Controls.Add(this.button1);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(47, 362);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(200, 67);
            this.grbNavegacionAlumno.TabIndex = 1;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(153, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = ">|";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(114, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(52, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "|<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionAlumno1
            // 
            this.grbNavegacionAlumno1.Location = new System.Drawing.Point(279, 362);
            this.grbNavegacionAlumno1.Name = "grbNavegacionAlumno1";
            this.grbNavegacionAlumno1.Size = new System.Drawing.Size(235, 67);
            this.grbNavegacionAlumno1.TabIndex = 2;
            this.grbNavegacionAlumno1.TabStop = false;
            this.grbNavegacionAlumno1.Text = "Navegacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbNavegacionAlumno1);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbDatosAlumnos.ResumeLayout(false);
            this.grbDatosAlumnos.PerformLayout();
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosAlumnos;
        private System.Windows.Forms.Label BlCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label bdNombreAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label bdTelefonoAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.Label bdDireccionAlumnno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label bdDUI;
        private System.Windows.Forms.TextBox txtDUIalumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

