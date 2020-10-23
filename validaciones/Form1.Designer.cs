namespace validaciones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreIn = new System.Windows.Forms.TextBox();
            this.codigoIn = new System.Windows.Forms.TextBox();
            this.correoIn = new System.Windows.Forms.TextBox();
            this.btnValidacion = new System.Windows.Forms.Button();
            this.salida = new System.Windows.Forms.Label();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordIn = new System.Windows.Forms.TextBox();
            this.btnValPass = new System.Windows.Forms.Button();
            this.lblValidacionPass = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // nombreIn
            // 
            this.nombreIn.Location = new System.Drawing.Point(129, 57);
            this.nombreIn.Name = "nombreIn";
            this.nombreIn.Size = new System.Drawing.Size(291, 20);
            this.nombreIn.TabIndex = 3;
            // 
            // codigoIn
            // 
            this.codigoIn.Location = new System.Drawing.Point(129, 118);
            this.codigoIn.Name = "codigoIn";
            this.codigoIn.Size = new System.Drawing.Size(141, 20);
            this.codigoIn.TabIndex = 4;
            // 
            // correoIn
            // 
            this.correoIn.Location = new System.Drawing.Point(129, 188);
            this.correoIn.Name = "correoIn";
            this.correoIn.Size = new System.Drawing.Size(291, 20);
            this.correoIn.TabIndex = 5;
            // 
            // btnValidacion
            // 
            this.btnValidacion.Location = new System.Drawing.Point(174, 250);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(96, 23);
            this.btnValidacion.TabIndex = 6;
            this.btnValidacion.Text = "Validar Datos";
            this.btnValidacion.UseVisualStyleBackColor = true;
            this.btnValidacion.Click += new System.EventHandler(this.btnValidacion_Click_1);
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salida.Location = new System.Drawing.Point(147, 315);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(19, 13);
            this.salida.TabIndex = 7;
            this.salida.Text = "----";
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // passwordIn
            // 
            this.passwordIn.Location = new System.Drawing.Point(515, 145);
            this.passwordIn.Name = "passwordIn";
            this.passwordIn.PasswordChar = '*';
            this.passwordIn.Size = new System.Drawing.Size(211, 20);
            this.passwordIn.TabIndex = 8;
            // 
            // btnValPass
            // 
            this.btnValPass.Location = new System.Drawing.Point(563, 250);
            this.btnValPass.Name = "btnValPass";
            this.btnValPass.Size = new System.Drawing.Size(111, 23);
            this.btnValPass.TabIndex = 9;
            this.btnValPass.Text = "Validar Clave";
            this.btnValPass.UseVisualStyleBackColor = true;
            this.btnValPass.Click += new System.EventHandler(this.btnValPass_Click);
            // 
            // lblValidacionPass
            // 
            this.lblValidacionPass.AutoSize = true;
            this.lblValidacionPass.Location = new System.Drawing.Point(560, 315);
            this.lblValidacionPass.Name = "lblValidacionPass";
            this.lblValidacionPass.Size = new System.Drawing.Size(16, 13);
            this.lblValidacionPass.TabIndex = 10;
            this.lblValidacionPass.Text = "---";
            this.lblValidacionPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(397, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Location = new System.Drawing.Point(736, 28);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(35, 35);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 370);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblValidacionPass);
            this.Controls.Add(this.btnValPass);
            this.Controls.Add(this.passwordIn);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.btnValidacion);
            this.Controls.Add(this.correoIn);
            this.Controls.Add(this.codigoIn);
            this.Controls.Add(this.nombreIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreIn;
        private System.Windows.Forms.TextBox codigoIn;
        private System.Windows.Forms.TextBox correoIn;
        private System.Windows.Forms.Button btnValidacion;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.ErrorProvider errorM;
        private System.Windows.Forms.Button btnValPass;
        private System.Windows.Forms.TextBox passwordIn;
        private System.Windows.Forms.Label lblValidacionPass;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnsalir;
    }
}

