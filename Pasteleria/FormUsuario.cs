using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasteleria
{
    public partial class FrmUsuario : Form
    {
        private Principal SI;
        public FrmUsuario(Principal S, string Usuario)
        {
            InitializeComponent();
            SI = S;
            tbUsuario3.Text = Usuario.ToLower();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (tbUsuario3.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un usuario para empezar.");
                return;
            }

            if (tbNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre para continuar.");
                return;
            }

            if (SI.EsUsuarioCorrecto(tbUsuario3.Text) == true)
            {
                MessageBox.Show("El usuario " + tbUsuario3.Text + " ya existe.");
                return;
            }

            SI.AltaUsuario(tbUsuario3.Text, tbNombre.Text);
            MessageBox.Show("Se creó el usuario " + tbUsuario3.Text.ToLower());
            this.Close();
        }

        private void btnCerrar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            if (tbUsuario3.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un usuario para borrar.");
                return;
            }

            if (SI.EsUsuarioCorrecto(tbUsuario3.Text) == true)
            {
                MessageBox.Show("El usuario " + tbUsuario3.Text + " se va a borrar.");
                SI.BorraUsuario(tbUsuario3.Text);
                this.Close();
            } else
            {
                MessageBox.Show("El usuario " + tbUsuario3.Text + " no existe.");
            }
        }
    }
}
