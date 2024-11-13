
namespace proyecto_grupo_4
{
    partial class FormCajero
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.cbxtipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarTransaccion = new System.Windows.Forms.Button();
            this.dgtransaccion = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConexxion = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.debito = new System.Windows.Forms.Label();
            this.txtdebito = new System.Windows.Forms.TextBox();
            this.txtIDtransaccion = new System.Windows.Forms.TextBox();
            this.btnleer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de transaccion";
            // 
            // txtabono
            // 
            this.txtabono.Location = new System.Drawing.Point(163, 141);
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(100, 20);
            this.txtabono.TabIndex = 4;
            // 
            // cbxtipo
            // 
            this.cbxtipo.FormattingEnabled = true;
            this.cbxtipo.Items.AddRange(new object[] {
            "Abono",
            "Cargo"});
            this.cbxtipo.Location = new System.Drawing.Point(163, 89);
            this.cbxtipo.Name = "cbxtipo";
            this.cbxtipo.Size = new System.Drawing.Size(121, 21);
            this.cbxtipo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "abono";
            // 
            // btnAgregarTransaccion
            // 
            this.btnAgregarTransaccion.Location = new System.Drawing.Point(426, 79);
            this.btnAgregarTransaccion.Name = "btnAgregarTransaccion";
            this.btnAgregarTransaccion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTransaccion.TabIndex = 9;
            this.btnAgregarTransaccion.Text = "Agregar transaccion";
            this.btnAgregarTransaccion.UseVisualStyleBackColor = true;
            this.btnAgregarTransaccion.Click += new System.EventHandler(this.btnAgregarTransaccion_Click);
            // 
            // dgtransaccion
            // 
            this.dgtransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtransaccion.Location = new System.Drawing.Point(23, 223);
            this.dgtransaccion.Name = "dgtransaccion";
            this.dgtransaccion.Size = new System.Drawing.Size(622, 150);
            this.dgtransaccion.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(426, 138);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConexxion
            // 
            this.btnConexxion.Location = new System.Drawing.Point(426, 25);
            this.btnConexxion.Name = "btnConexxion";
            this.btnConexxion.Size = new System.Drawing.Size(75, 23);
            this.btnConexxion.TabIndex = 19;
            this.btnConexxion.Text = "Conexxion";
            this.btnConexxion.UseVisualStyleBackColor = true;
            this.btnConexxion.Click += new System.EventHandler(this.btnConexxion_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(154, 35);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 20;
            // 
            // debito
            // 
            this.debito.AutoSize = true;
            this.debito.Location = new System.Drawing.Point(47, 187);
            this.debito.Name = "debito";
            this.debito.Size = new System.Drawing.Size(47, 13);
            this.debito.TabIndex = 21;
            this.debito.Text = "DEBITO";
            // 
            // txtdebito
            // 
            this.txtdebito.Location = new System.Drawing.Point(163, 187);
            this.txtdebito.Name = "txtdebito";
            this.txtdebito.Size = new System.Drawing.Size(100, 20);
            this.txtdebito.TabIndex = 22;
            // 
            // txtIDtransaccion
            // 
            this.txtIDtransaccion.Location = new System.Drawing.Point(426, 197);
            this.txtIDtransaccion.Name = "txtIDtransaccion";
            this.txtIDtransaccion.Size = new System.Drawing.Size(100, 20);
            this.txtIDtransaccion.TabIndex = 23;
            this.txtIDtransaccion.Visible = false;
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(533, 25);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(75, 23);
            this.btnleer.TabIndex = 24;
            this.btnleer.Text = "leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // FormCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.txtIDtransaccion);
            this.Controls.Add(this.txtdebito);
            this.Controls.Add(this.debito);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.btnConexxion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgtransaccion);
            this.Controls.Add(this.btnAgregarTransaccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxtipo);
            this.Controls.Add(this.txtabono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormCajero";
            this.Text = "InterfazCajero";
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtabono;
        private System.Windows.Forms.ComboBox cbxtipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarTransaccion;
        private System.Windows.Forms.DataGridView dgtransaccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConexxion;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label debito;
        private System.Windows.Forms.TextBox txtdebito;
        private System.Windows.Forms.TextBox txtIDtransaccion;
        private System.Windows.Forms.Button btnleer;
    }
}