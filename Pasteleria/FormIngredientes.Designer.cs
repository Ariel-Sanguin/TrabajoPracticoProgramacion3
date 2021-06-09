namespace Pasteleria
{
    partial class FrmIngredientes
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIngrediente = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnCrearIngredientes = new System.Windows.Forms.Button();
            this.btnVerIngredientes = new System.Windows.Forms.Button();
            this.btnCerrar4 = new System.Windows.Forms.Button();
            this.cbUm = new System.Windows.Forms.ComboBox();
            this.lbIngredientes = new System.Windows.Forms.ListBox();
            this.btnBorrarIngredientes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(13, 4);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(103, 33);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrediente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unidad de Medida";
            // 
            // tbIngrediente
            // 
            this.tbIngrediente.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIngrediente.Location = new System.Drawing.Point(281, 40);
            this.tbIngrediente.Name = "tbIngrediente";
            this.tbIngrediente.Size = new System.Drawing.Size(507, 40);
            this.tbIngrediente.TabIndex = 4;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(281, 86);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(507, 40);
            this.tbCantidad.TabIndex = 5;
            // 
            // tbResultado
            // 
            this.tbResultado.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(9, 352);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(779, 35);
            this.tbResultado.TabIndex = 7;
            // 
            // btnCrearIngredientes
            // 
            this.btnCrearIngredientes.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearIngredientes.Location = new System.Drawing.Point(408, 178);
            this.btnCrearIngredientes.Name = "btnCrearIngredientes";
            this.btnCrearIngredientes.Size = new System.Drawing.Size(380, 45);
            this.btnCrearIngredientes.TabIndex = 8;
            this.btnCrearIngredientes.Text = "Crear Ingrediente";
            this.btnCrearIngredientes.UseVisualStyleBackColor = true;
            this.btnCrearIngredientes.Click += new System.EventHandler(this.btnCrearIngredientes_Click);
            // 
            // btnVerIngredientes
            // 
            this.btnVerIngredientes.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerIngredientes.Location = new System.Drawing.Point(22, 229);
            this.btnVerIngredientes.Name = "btnVerIngredientes";
            this.btnVerIngredientes.Size = new System.Drawing.Size(380, 45);
            this.btnVerIngredientes.TabIndex = 9;
            this.btnVerIngredientes.Text = "Ver Ingredientes en Log";
            this.btnVerIngredientes.UseVisualStyleBackColor = true;
            this.btnVerIngredientes.Click += new System.EventHandler(this.btnVerIngredientes_Click);
            // 
            // btnCerrar4
            // 
            this.btnCerrar4.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar4.Location = new System.Drawing.Point(637, 393);
            this.btnCerrar4.Name = "btnCerrar4";
            this.btnCerrar4.Size = new System.Drawing.Size(151, 45);
            this.btnCerrar4.TabIndex = 10;
            this.btnCerrar4.Text = "Cerrar";
            this.btnCerrar4.UseVisualStyleBackColor = true;
            this.btnCerrar4.Click += new System.EventHandler(this.btnCerrar4_Click);
            // 
            // cbUm
            // 
            this.cbUm.Font = new System.Drawing.Font("Eras Demi ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUm.FormattingEnabled = true;
            this.cbUm.Location = new System.Drawing.Point(281, 132);
            this.cbUm.Name = "cbUm";
            this.cbUm.Size = new System.Drawing.Size(507, 40);
            this.cbUm.TabIndex = 12;
            // 
            // lbIngredientes
            // 
            this.lbIngredientes.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngredientes.FormattingEnabled = true;
            this.lbIngredientes.HorizontalScrollbar = true;
            this.lbIngredientes.ItemHeight = 28;
            this.lbIngredientes.Location = new System.Drawing.Point(794, 40);
            this.lbIngredientes.Name = "lbIngredientes";
            this.lbIngredientes.Size = new System.Drawing.Size(400, 396);
            this.lbIngredientes.TabIndex = 13;
            // 
            // btnBorrarIngredientes
            // 
            this.btnBorrarIngredientes.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarIngredientes.Location = new System.Drawing.Point(22, 179);
            this.btnBorrarIngredientes.Name = "btnBorrarIngredientes";
            this.btnBorrarIngredientes.Size = new System.Drawing.Size(380, 45);
            this.btnBorrarIngredientes.TabIndex = 14;
            this.btnBorrarIngredientes.Text = "Borrar Ingrediente";
            this.btnBorrarIngredientes.UseVisualStyleBackColor = true;
            this.btnBorrarIngredientes.Click += new System.EventHandler(this.btnBorrarIngredientes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Log";
            // 
            // FrmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBorrarIngredientes);
            this.Controls.Add(this.lbIngredientes);
            this.Controls.Add(this.cbUm);
            this.Controls.Add(this.btnCerrar4);
            this.Controls.Add(this.btnVerIngredientes);
            this.Controls.Add(this.btnCrearIngredientes);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbIngrediente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProducto);
            this.Name = "FrmIngredientes";
            this.Text = "Ingredientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIngrediente;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btnCrearIngredientes;
        private System.Windows.Forms.Button btnVerIngredientes;
        private System.Windows.Forms.Button btnCerrar4;
        private System.Windows.Forms.ComboBox cbUm;
        private System.Windows.Forms.ListBox lbIngredientes;
        private System.Windows.Forms.Button btnBorrarIngredientes;
        private System.Windows.Forms.Label label4;
    }
}