using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    [Serializable]
    class Medida
    {
        private string ImedidaNombre;
        private string ImedidaValor;

        public Medida(string EmedidaNombre, string EmedidaValor)
        {
            ImedidaNombre = EmedidaNombre;
            ImedidaValor = EmedidaValor;
        }

        public string EmedidaNombre
        {
            get
            {
                return ImedidaNombre;
            }
            set
            {
                ImedidaNombre = EmedidaNombre;
            }
        }

        public string EmedidaValor
        {
            get
            {
                return ImedidaValor;
            }
            set
            {
                ImedidaValor = EmedidaValor;
            }
        }
    }
}
