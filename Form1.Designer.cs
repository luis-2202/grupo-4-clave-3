﻿
namespace proyecto_grupo_4
{
    partial class Form1Credenciales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraeña = new System.Windows.Forms.TextBox();
            this.btnIniciarsecion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(299, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraeña
            // 
            this.txtContraeña.Location = new System.Drawing.Point(299, 134);
            this.txtContraeña.Name = "txtContraeña";
            this.txtContraeña.PasswordChar = '*';
            this.txtContraeña.Size = new System.Drawing.Size(100, 20);
            this.txtContraeña.TabIndex = 3;
            // 
            // btnIniciarsecion
            // 
            this.btnIniciarsecion.Location = new System.Drawing.Point(209, 230);
            this.btnIniciarsecion.Name = "btnIniciarsecion";
            this.btnIniciarsecion.Size = new System.Drawing.Size(121, 23);
            this.btnIniciarsecion.TabIndex = 4;
            this.btnIniciarsecion.Text = "iniciar secion";
            this.btnIniciarsecion.UseVisualStyleBackColor = true;
            this.btnIniciarsecion.Click += new System.EventHandler(this.btnIniciarsecion_Click);
            // 
            // Form1Credenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarsecion);
            this.Controls.Add(this.txtContraeña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1Credenciales";
            this.Text = "COOPERATIVA ACOEMPRENDEDORES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraeña;
        private System.Windows.Forms.Button btnIniciarsecion;
    }
}

