namespace Pasteleria
{
    partial class FrmUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario3 = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnCerrar3 = new System.Windows.Forms.Button();
            this.btnBorrarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario Id";
            // 
            // tbUsuario3
            // 
            this.tbUsuario3.Font = new System.Drawing.Font("Eras Demi ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario3.Location = new System.Drawing.Point(193, 13);
            this.tbUsuario3.Name = "tbUsuario3";
            this.tbUsuario3.Size = new System.Drawing.Size(362, 40);
            this.tbUsuario3.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Eras Demi ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(193, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(362, 40);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(579, 13);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(244, 53);
            this.btnCrearUsuario.TabIndex = 4;
            this.btnCrearUsuario.Text = "Crear";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnCerrar3
            // 
            this.btnCerrar3.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar3.Location = new System.Drawing.Point(579, 131);
            this.btnCerrar3.Name = "btnCerrar3";
            this.btnCerrar3.Size = new System.Drawing.Size(244, 53);
            this.btnCerrar3.TabIndex = 5;
            this.btnCerrar3.Text = "Cerrar";
            this.btnCerrar3.UseVisualStyleBackColor = true;
            this.btnCerrar3.Click += new System.EventHandler(this.btnCerrar3_Click);
            // 
            // btnBorrarUsuario
            // 
            this.btnBorrarUsuario.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUsuario.Location = new System.Drawing.Point(579, 72);
            this.btnBorrarUsuario.Name = "btnBorrarUsuario";
            this.btnBorrarUsuario.Size = new System.Drawing.Size(244, 53);
            this.btnBorrarUsuario.TabIndex = 6;
            this.btnBorrarUsuario.Text = "Borrar";
            this.btnBorrarUsuario.UseVisualStyleBackColor = true;
            this.btnBorrarUsuario.Click += new System.EventHandler(this.btnBorrarUsuario_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 197);
            this.Controls.Add(this.btnBorrarUsuario);
            this.Controls.Add(this.btnCerrar3);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbUsuario3);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuario";
            this.Text = "Alta de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnCerrar3;
        private System.Windows.Forms.Button btnBorrarUsuario;
    }
}