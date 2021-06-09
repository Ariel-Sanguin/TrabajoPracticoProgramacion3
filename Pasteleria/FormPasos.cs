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
    public partial class FrmPasos : Form
    {

        private Form IfrmProducto;
        private Principal SI;

        public FrmPasos(Form FrmProducto, Principal S, string Sproducto)
        {
            InitializeComponent();
            SI = S;
            IfrmProducto = FrmProducto;
            lblProducto2.Text = Sproducto.ToUpper();
            lbPasos.Items.AddRange(SI.GetPasos(lblProducto2.Text));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            IfrmProducto.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            if (tbDescripcion.Text.Trim() == "")
            {
                tbResultado.Text = "Error. Debe ingresar una descripcion para empezar.";
                return;
            }

            int cant;
            Int32.TryParse(tbOrden.Text, out cant);
            if (cant < 1)
            {
                tbResultado.Text = "Cantidad no valida. No se procesó nada.";
                return;
            }

            if (SI.GetPasos(lblProducto2.Text, cant))
            {
                tbResultado.Text = "Orden ya existe. No se procesó nada.";
                return;
            }
            SI.AltaPasos(lblProducto2.Text, cant, tbDescripcion.Text);
            tbResultado.Text = "Se Creó: " + cant + ":" + tbDescripcion.Text;
            lbPasos.Items.Clear();
            lbPasos.Items.AddRange(SI.GetPasos(lblProducto2.Text));
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string IordenDescripcion = "";
            foreach (var item in lbPasos.SelectedItems)
            {
                IordenDescripcion += item.ToString();
            }

            if (IordenDescripcion == "")
            {
                tbResultado.Text = "Error. Debe seleccionar un Paso del cuadro";
                return;
            }

            tbResultado.Text = "Se borró " + IordenDescripcion + ".";
            SI.BorrarPasos(lblProducto2.Text, SI.GetPasos(lblProducto2.Text, IordenDescripcion));
            lbPasos.Items.Clear();
            lbPasos.Items.AddRange(SI.GetPasos(lblProducto2.Text));
        }
    }
}
