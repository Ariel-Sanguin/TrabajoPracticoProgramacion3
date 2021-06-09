namespace Pasteleria
{
    partial class FrmInicio
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
            this.tbUsuario1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCerrar1 = new System.Windows.Forms.Button();
            this.btnAdmUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Bold ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Sistema de Pasteleria";
            // 
            // tbUsuario1
            // 
            this.tbUsuario1.Font = new System.Drawing.Font("Eras Demi ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario1.Location = new System.Drawing.Point(32, 170);
            this.tbUsuario1.Name = "tbUsuario1";
            this.tbUsuario1.Size = new System.Drawing.Size(371, 40);
            this.tbUsuario1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su nombre de usuario";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(429, 251);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(257, 82);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCerrar1
            // 
            this.BtnCerrar1.Font = new System.Drawing.Font("Eras Bold ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar1.Location = new System.Drawing.Point(706, 251);
            this.BtnCerrar1.Name = "BtnCerrar1";
            this.BtnCerrar1.Size = new System.Drawing.Size(257, 82);
            this.BtnCerrar1.TabIndex = 4;
            this.BtnCerrar1.Text = "Cerrar";
            this.BtnCerrar1.UseVisualStyleBackColor = true;
            this.BtnCerrar1.Click += new System.EventHandler(this.BtnCerrar1_Click);
            // 
            // btnAdmUsuario
            // 
            this.btnAdmUsuario.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmUsuario.Location = new System.Drawing.Point(155, 251);
            this.btnAdmUsuario.Name = "btnAdmUsuario";
            this.btnAdmUsuario.Size = new System.Drawing.Size(257, 82);
            this.btnAdmUsuario.TabIndex = 5;
            this.btnAdmUsuario.Text = "Administrar Usuarios";
            this.btnAdmUsuario.UseVisualStyleBackColor = true;
            this.btnAdmUsuario.Click += new System.EventHandler(this.btnAdmUsuario_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.btnAdmUsuario);
            this.Controls.Add(this.BtnCerrar1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsuario1);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicio";
            this.Text = "Pasteleria Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnCerrar1;
        private System.Windows.Forms.Button btnAdmUsuario;
    }
}

