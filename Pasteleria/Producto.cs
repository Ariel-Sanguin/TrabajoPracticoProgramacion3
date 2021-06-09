using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    [Serializable]
    class Producto
    {
        private string IproductoNombre;
        private string IproductoTipo;

        public Producto(string EproductoNombre, String EproductoTipo)
        {
            IproductoNombre = EproductoNombre;
            IproductoTipo = EproductoTipo;
        }

        public string EproductoNombre
        {
            get
            {
                return IproductoNombre;
            }
            set
            {
                IproductoNombre = EproductoNombre;
            }
        }

        public string EproductoTipo
        {
            get
            {
                return IproductoTipo;
            }
            set
            {
                IproductoTipo = EproductoTipo;
            }
        }

        public override string ToString()
        {
            return IproductoNombre + "-" + IproductoTipo;
        }
    }
}
