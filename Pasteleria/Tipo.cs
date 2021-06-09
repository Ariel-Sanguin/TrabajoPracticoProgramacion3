using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    [Serializable]
    class Tipo
    {
        private string ItipoNombre;
        private string ItipoValor;

        public Tipo(string EtipoNombre, string EtipoValor)
        {
            ItipoNombre = EtipoNombre;
            ItipoValor = EtipoValor;
        }

        public string EtipoNombre
        {
            get
            {
                return ItipoNombre;
            }
            set
            {
                ItipoNombre = EtipoNombre;
            }
        }

        public string EtipoValor
        {
            get
            {
                return ItipoValor;
            }
            set
            {
                ItipoValor = EtipoValor;
            }
        }

    }
}
