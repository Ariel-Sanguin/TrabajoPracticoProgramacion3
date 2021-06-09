using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
    [Serializable]
    class Usuario
    {
        private string IusuarioId;
        private string IusuarioNombre;

        public Usuario(string EusuarioId, string EusuarioNombre)
        {
            IusuarioId = EusuarioId.ToLower();
            IusuarioNombre = EusuarioNombre.ToUpper();
        }

        public string EusuarioId
        {
            get
            {
                return IusuarioId;
            }
            set
            {
                IusuarioId = EusuarioId;
            }
        }

        public string EusuarioNombre
        {
            get
            {
                return IusuarioNombre;
            }
            set
            {
                IusuarioNombre = EusuarioNombre;
            }
        }

        public override string ToString()
        {
            return IusuarioId + "-" + IusuarioNombre;
        }

        public string FindId ()
        {
            return IusuarioId;
        }
    }
}
