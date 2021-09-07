namespace BaseDeDatos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaBaja = new System.Windows.Forms.TextBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(74, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(168, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(255, 167);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(100, 30);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cedula:";
            // 
            // txtCedulaBaja
            // 
            this.txtCedulaBaja.Location = new System.Drawing.Point(74, 222);
            this.txtCedulaBaja.Name = "txtCedulaBaja";
            this.txtCedulaBaja.Size = new System.Drawing.Size(168, 20);
            this.txtCedulaBaja.TabIndex = 6;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(255, 267);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(100, 30);
            this.btnBaja.TabIndex = 7;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre a Modificar:";
            // 
            // txtNombreActual
            // 
            this.txtNombreActual.Location = new System.Drawing.Point(236, 335);
            this.txtNombreActual.Name = "txtNombreActual";
            this.txtNombreActual.Size = new System.Drawing.Size(135, 20);
            this.txtNombreActual.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nuevo Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nuevo Apellido:";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(107, 407);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNuevoNombre.TabIndex = 12;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(392, 407);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(135, 20);
            this.txtApellido2.TabIndex = 13;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(271, 499);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(100, 30);
            this.btnModifica.TabIndex = 14;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cedula:";
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(359, 32);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(168, 20);
            this.textCedula.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Correo:";
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(359, 76);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(168, 20);
            this.textCorreo.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha:";
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(74, 117);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(168, 20);
            this.textFecha.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Telefono:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(359, 121);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(168, 20);
            this.textTelefono.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 561);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.txtCedulaBaja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaBaja;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTelefono;
    }
}

