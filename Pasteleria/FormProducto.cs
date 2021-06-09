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
    public partial class FrmProducto : Form
    {
        private Form FrmInicio;
        private Form IfrmIngredientes;
        private Form IfrmPasos;
        private Principal SI;
        public FrmProducto(Form Inicio, Principal S, string Usuario)
        {
            SI = S;
            FrmInicio = Inicio;
            InitializeComponent();
            lblUsuario.Text = "Hola " + Usuario + "!";
            lbProductos.Items.AddRange(SI.GetProductos());
            cbTipos.DataSource = TiposRepositorio.GetTipos();
            cbTipos.DisplayMember = "EtipoNombre";
            cbTipos.ValueMember = "EtipoValor";
        }

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
            FrmInicio.Show();
        }

        private void btnCreaProducto_Click(object sender, EventArgs e)
        {
            if (tbProducto.Text.Trim() == "")
            {
                tbSalida.Text = "Error. Debe ingresar un Nombre de Producto para empezar.";
                tbProducto.Text = "";
                return;
            }

            if (SI.EsProductoCorrecto(tbProducto.Text.ToUpper()) == true)
            {
                tbSalida.Text = "Error. El producto " + tbProducto.Text.ToUpper() + " ya existe (duplicado). No se procesó.";
                tbProducto.Text = "";
                return;
            }

            tbSalida.Text = "Se Creó: " + SI.AltaProducto(tbProducto.Text.ToUpper(), cbTipos.SelectedValue.ToString());
            tbProducto.Text = "";
            lbProductos.Items.Clear();
            lbProductos.Items.AddRange(SI.GetProductos());

        }

        private void btnCrearIngredientes_Click(object sender, EventArgs e)
        {
            string ProductoTipo = "";
            foreach (var item in lbProductos.SelectedItems)
            {
                ProductoTipo += item.ToString();
            }

            if (ProductoTipo == "")
            {
                tbSalida.Text = "Error. Debe seleccionar un producto del cuadro";
                return;
            }

            IfrmIngredientes = new FrmIngredientes(this, SI, SI.GetProductos(ProductoTipo));
            IfrmIngredientes.Show(this);
            this.Hide();

        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            tbSalida.Text=SI.VerProductos();
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            string ProductoTipo = "";
            foreach (var item in lbProductos.SelectedItems)
            {
                ProductoTipo += item.ToString();
            }

            if (ProductoTipo == "")
            {
                tbSalida.Text = "Error. Debe seleccionar un producto del cuadro";
                return;
            }

            tbSalida.Text= "Se borró " + ProductoTipo + ".";
            SI.BorrarProducto(SI.GetProductos(ProductoTipo));
            lbProductos.Items.Clear();
            lbProductos.Items.AddRange(SI.GetProductos());

        }

        private void btnCrearPasos_Click(object sender, EventArgs e)
        {
            string ProductoTipo = "";
            foreach (var item in lbProductos.SelectedItems)
            {
                ProductoTipo += item.ToString();
            }

            if (ProductoTipo == "")
            {
                tbSalida.Text = "Error. Debe seleccionar un producto del cuadro";
                return;
            }

            IfrmPasos = new FrmPasos(this, SI, SI.GetProductos(ProductoTipo));
            IfrmPasos.Show(this);
            this.Hide();

        }
    }
}
