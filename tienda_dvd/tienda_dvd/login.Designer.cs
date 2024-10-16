namespace tienda_dvd
{
    partial class login
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
            this.txtContraseñaLogi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioLogi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContraseñaLogi
            // 
            this.txtContraseñaLogi.Location = new System.Drawing.Point(292, 170);
            this.txtContraseñaLogi.Name = "txtContraseñaLogi";
            this.txtContraseñaLogi.Size = new System.Drawing.Size(249, 20);
            this.txtContraseñaLogi.TabIndex = 33;
            this.txtContraseñaLogi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Direccion:";
            // 
            // txtUsuarioLogi
            // 
            this.txtUsuarioLogi.Location = new System.Drawing.Point(292, 118);
            this.txtUsuarioLogi.Name = "txtUsuarioLogi";
            this.txtUsuarioLogi.Size = new System.Drawing.Size(249, 20);
            this.txtUsuarioLogi.TabIndex = 31;
            this.txtUsuarioLogi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre:";
            // 
            // btnLogi
            // 
            this.btnLogi.Location = new System.Drawing.Point(351, 235);
            this.btnLogi.Name = "btnLogi";
            this.btnLogi.Size = new System.Drawing.Size(75, 23);
            this.btnLogi.TabIndex = 34;
            this.btnLogi.Text = "ingresar";
            this.btnLogi.UseVisualStyleBackColor = true;
            this.btnLogi.Click += new System.EventHandler(this.btnLogi_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogi);
            this.Controls.Add(this.txtContraseñaLogi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuarioLogi);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaLogi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioLogi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogi;
    }
}