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
    public partial class FrmIngredientes : Form
    {
        private Form IfrmProducto;
        private Principal SI;

        public FrmIngredientes(Form FrmProducto, Principal S, string Sproducto)
        {
            InitializeComponent();
            SI = S;
            IfrmProducto = FrmProducto;
            lblProducto.Text = Sproducto.ToUpper();
            cbUm.DataSource = MedidasRepositorio.GetMedidas();
            cbUm.DisplayMember = "EmedidaNombre";
            cbUm.ValueMember = "EmedidaValor";
            lbIngredientes.Items.AddRange(SI.GetIngredientes(lblProducto.Text));
        }

        private void btnCerrar4_Click(object sender, EventArgs e)
        {
            this.Close();
            IfrmProducto.Show();

        }

        private void btnCrearIngredientes_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "";
            if (tbIngrediente.Text.Trim() == "")
            {
                tbResultado.Text = "Error. Debe ingresar un Ingrediente para empezar.";
                return;
            }

            if (SI.EsIngredienteCorrecto(lblProducto.Text.ToUpper(), tbIngrediente.Text.ToUpper()) == true)
            {
                tbResultado.Text = "Error. El ingrediente " + tbIngrediente.Text.ToUpper() + " ya existe (duplicado). No se procesó.";
                return;
            }

            int cant;
            Int32.TryParse(tbCantidad.Text, out cant);
            if (cant < 1)
            {
                tbResultado.Text = "Cantidad no valida. No se procesó nada.";
                return;
            }

            tbResultado.Text = "Se Creó: " + SI.AltaIngrediente(lblProducto.Text.ToUpper(), tbIngrediente.Text.ToUpper(), cant, cbUm.SelectedValue.ToString());
            lbIngredientes.Items.Clear();
            lbIngredientes.Items.AddRange(SI.GetIngredientes(lblProducto.Text));

        }

        private void btnVerIngredientes_Click(object sender, EventArgs e)
        {
            tbResultado.Text = SI.VerIngredientes(lblProducto.Text.ToUpper());

        }

        private void btnBorrarIngredientes_Click(object sender, EventArgs e)
        {
            string InombreCantidadUm = "";
            foreach (var item in lbIngredientes.SelectedItems)
            {
                InombreCantidadUm += item.ToString();
            }

            if (InombreCantidadUm == "")
            {
                tbResultado.Text = "Error. Debe seleccionar un Ingrediente del cuadro";
                return;
            }

            tbResultado.Text = "Se borró " + InombreCantidadUm + ".";
            SI.BorrarIngrediente(lblProducto.Text, InombreCantidadUm);
            lbIngredientes.Items.Clear();
            lbIngredientes.Items.AddRange(SI.GetIngredientes(lblProducto.Text));
        }
    }
}
