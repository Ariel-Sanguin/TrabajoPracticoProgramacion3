namespace Pasteleria
{
    partial class FrmProducto
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
            this.btnCerrar2 = new System.Windows.Forms.Button();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreaProducto = new System.Windows.Forms.Button();
            this.tbSalida = new System.Windows.Forms.TextBox();
            this.btnCrearIngredientes = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.btnCrearPasos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar2
            // 
            this.btnCerrar2.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar2.Location = new System.Drawing.Point(649, 390);
            this.btnCerrar2.Name = "btnCerrar2";
            this.btnCerrar2.Size = new System.Drawing.Size(139, 52);
            this.btnCerrar2.TabIndex = 0;
            this.btnCerrar2.Text = "Cerrar";
            this.btnCerrar2.UseVisualStyleBackColor = true;
            this.btnCerrar2.Click += new System.EventHandler(this.btnCerrar2_Click);
            // 
            // tbProducto
            // 
            this.tbProducto.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProducto.Location = new System.Drawing.Point(380, 54);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(408, 40);
            this.tbProducto.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(3, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(103, 33);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Producto";
            // 
            // btnCreaProducto
            // 
            this.btnCreaProducto.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaProducto.Location = new System.Drawing.Point(380, 146);
            this.btnCreaProducto.Name = "btnCreaProducto";
            this.btnCreaProducto.Size = new System.Drawing.Size(408, 50);
            this.btnCreaProducto.TabIndex = 6;
            this.btnCreaProducto.Text = "Crear Nuevo Producto";
            this.btnCreaProducto.UseVisualStyleBackColor = true;
            this.btnCreaProducto.Click += new System.EventHandler(this.btnCreaProducto_Click);
            // 
            // tbSalida
            // 
            this.tbSalida.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalida.Location = new System.Drawing.Point(18, 349);
            this.tbSalida.Name = "tbSalida";
            this.tbSalida.Size = new System.Drawing.Size(770, 35);
            this.tbSalida.TabIndex = 7;
            // 
            // btnCrearIngredientes
            // 
            this.btnCrearIngredientes.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearIngredientes.Location = new System.Drawing.Point(380, 203);
            this.btnCrearIngredientes.Name = "btnCrearIngredientes";
            this.btnCrearIngredientes.Size = new System.Drawing.Size(408, 50);
            this.btnCrearIngredientes.TabIndex = 8;
            this.btnCrearIngredientes.Text = "Agregar Ingredientes";
            this.btnCrearIngredientes.UseVisualStyleBackColor = true;
            this.btnCrearIngredientes.Click += new System.EventHandler(this.btnCrearIngredientes_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProductos.Location = new System.Drawing.Point(18, 293);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(356, 50);
            this.btnVerProductos.TabIndex = 9;
            this.btnVerProductos.Text = "Ver Productos en Log";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // lbProductos
            // 
            this.lbProductos.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.HorizontalScrollbar = true;
            this.lbProductos.ItemHeight = 28;
            this.lbProductos.Location = new System.Drawing.Point(806, 54);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(381, 368);
            this.lbProductos.TabIndex = 10;
            // 
            // cbTipos
            // 
            this.cbTipos.Font = new System.Drawing.Font("Eras Demi ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(380, 101);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(408, 40);
            this.cbTipos.TabIndex = 11;
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarProducto.Location = new System.Drawing.Point(18, 147);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(356, 50);
            this.btnBorrarProducto.TabIndex = 12;
            this.btnBorrarProducto.Text = "Borrar Producto";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // btnCrearPasos
            // 
            this.btnCrearPasos.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPasos.Location = new System.Drawing.Point(18, 203);
            this.btnCrearPasos.Name = "btnCrearPasos";
            this.btnCrearPasos.Size = new System.Drawing.Size(356, 50);
            this.btnCrearPasos.TabIndex = 13;
            this.btnCrearPasos.Text = "Agregar Pasos";
            this.btnCrearPasos.UseVisualStyleBackColor = true;
            this.btnCrearPasos.Click += new System.EventHandler(this.btnCrearPasos_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.btnCrearPasos);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.cbTipos);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.btnCrearIngredientes);
            this.Controls.Add(this.tbSalida);
            this.Controls.Add(this.btnCreaProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.btnCerrar2);
            this.Name = "FrmProducto";
            this.Text = "Pasteleria Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar2;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreaProducto;
        private System.Windows.Forms.TextBox tbSalida;
        private System.Windows.Forms.Button btnCrearIngredientes;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.ComboBox cbTipos;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.Button btnCrearPasos;
    }
}