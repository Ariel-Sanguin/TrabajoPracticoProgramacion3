using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    [Serializable]
    class Ingrediente
    {
        private string IingredienteProducto;
        private string IingredienteNombre;
        private int IingredienteCantidad;
        private string IingredienteUm;

        public Ingrediente(string EProducto, string Enombre, int Ecantidad, string Eum)
        {
            IingredienteProducto = EProducto;
            IingredienteNombre = Enombre;
            IingredienteCantidad = Ecantidad;
            IingredienteUm = Eum;
        }

        public string EProducto
        {
            get
            {
                return IingredienteProducto;
            }
            set
            {
                IingredienteProducto = EProducto;
            }
        }

        public string Enombre
        {
            get
            {
                return IingredienteNombre;
            }
            set
            {
                IingredienteNombre = Enombre;
            }
        }

        public int Ecantidad
        {
            get
            {
                return IingredienteCantidad;
            }
            set
            {
                IingredienteCantidad = Ecantidad;
            }
        }

        public string Eum
        {
            get
            {
                return IingredienteUm;
            }
            set
            {
                IingredienteUm = Eum;
            }
        }

        public override string ToString()
        {
            return IingredienteProducto + "-" + IingredienteNombre + "-" + IingredienteCantidad + "-" + IingredienteUm;
        }
    }
}
