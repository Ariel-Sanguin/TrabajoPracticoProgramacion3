using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    [Serializable]
    class Pasos
    {
        private string IpasosProducto;
        private int IpasosOrden;
        private string IpasosDescripcion;

        public Pasos (string Eproducto, int Eorden, string Edescripcion)
        {
            IpasosProducto = Eproducto;
            IpasosOrden = Eorden;
            IpasosDescripcion = Edescripcion;
        }

        public string EProducto
        {
            get
            {
                return IpasosProducto;
            }
            set
            {
                IpasosProducto = EProducto;
            }
        }

        public int Eorden
        {
            get
            {
                return IpasosOrden;
            }
            set
            {
                IpasosOrden = Eorden;
            }
        }
        
        public string Edescripcion
        {
            get
            {
                return IpasosDescripcion;
            }
            set
            {
                IpasosDescripcion = Edescripcion;
            }
        }

        public override string ToString()
        {
            return IpasosOrden.ToString() + ")" + IpasosOrden;
        }

    }
}
