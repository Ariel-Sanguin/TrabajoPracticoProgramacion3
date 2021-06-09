using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasteleria
{
    public partial class FrmInicio : Form
    {
        private FrmProducto IfrmProducto;
        private FrmUsuario IfrmUsuario;
        private Principal SI;

        public FrmInicio(Principal S)
        {
            InitializeComponent();
            SI = S;
            SI.AltaUsuario("ariel", "Ariel Sanguin");
            SI.AltaUsuario("bruno", "Bruno Sanchez");
            //IfrmProducto = new FrmProducto(this);
        }

        private void BtnCerrar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (tbUsuario1.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un usuario para empezar");
                return;
            }

            if (SI.EsUsuarioCorrecto(tbUsuario1.Text.ToLower()) == false)
            {
                MessageBox.Show("Debe ingresar un usuario válido");
                return;
            }
            
            IfrmProducto = new FrmProducto(this, SI, tbUsuario1.Text.ToLower());
            IfrmProducto.Show(this);
            this.Hide();
        }

        private void btnAdmUsuario_Click(object sender, EventArgs e)
        {
            if (tbUsuario1.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un usuario para empezar.");
                return;
            }

            IfrmUsuario = new FrmUsuario(SI, tbUsuario1.Text);
            IfrmUsuario.ShowDialog(this);

        }
    }
}
