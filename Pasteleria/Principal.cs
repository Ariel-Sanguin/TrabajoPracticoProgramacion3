using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasteleria
{
    [Serializable]
    public class Principal
    {
        private string IsistemaUsuarioId;
        private string IsistemaUsuarioNombre;
        
        private new List<Usuario> ListaUsuarios = new List<Usuario>();
        private new List<Producto> ListaProductos = new List<Producto>();
        private new List<Ingrediente> ListaIngredientes = new List<Ingrediente>();
        private new List<Pasos> ListaPasos = new List<Pasos>();

        public void AltaUsuario(string EsistemaUsuarioId, string EsistemaUsuarioNombre)
        {
            IsistemaUsuarioId = EsistemaUsuarioId;
            IsistemaUsuarioNombre = EsistemaUsuarioNombre;
            ListaUsuarios.Add(new Usuario(IsistemaUsuarioId, IsistemaUsuarioNombre));
        }

        public void BorraUsuario(string EsistemaUsuarioId)
        {
            IsistemaUsuarioId = EsistemaUsuarioId;
            int Aborrar = 0, I = 0;
            foreach (Usuario U in ListaUsuarios)
            {
                if (IsistemaUsuarioId == U.EusuarioId)
                {
                    MessageBox.Show(U.EusuarioNombre + " (" + I.ToString() + ")");
                    Aborrar = I;
                }
                I++;
            }
            ListaUsuarios.RemoveAt(Aborrar);
        }

        public bool EsUsuarioCorrecto(string EsistemaUsuarioId)
        {
            foreach (Usuario u in ListaUsuarios)
            {
                if (u.FindId()== EsistemaUsuarioId)
                {
                    return true;
                }
            }
            return false;
        }

        public string AltaProducto(string Nom, string Tip)
        {
            ListaProductos.Add(new Producto(Nom, Tip));
            return ListaProductos.Last().ToString();
        }

        public void BorrarProducto(string Enombre)
        {
            int Aborrar = 0, I = 0;
            foreach (Producto P in ListaProductos)
            {
                if(P.EproductoNombre == Enombre)
                {
                    Aborrar = I;
                }
                I++;
            }
            ListaProductos.RemoveAt(Aborrar);
        }

        public string VerProductos()
        {
            string Retorno = "";
            foreach (Producto P in ListaProductos)
            {
                Retorno = P.ToString() + ";" + Retorno;
            }
            return Retorno;
        }
        
        public string[] GetProductos()
        {
            int I = 0;
            int C = CantidadProductos();
            string[] Retorno = new string[C];
            foreach (Producto P in ListaProductos)
            {
                Retorno[I] = P.EproductoNombre + " (" + P.EproductoTipo + ")";
                I++;
            }
            return Retorno;
        }

        public string GetProductos(String EProductoValor)
        {
            string IProductoValor;
            foreach (Producto P in ListaProductos)
            {
                IProductoValor = P.EproductoNombre + " (" + P.EproductoTipo +")";
                if (IProductoValor == EProductoValor)
                {
                    return P.EproductoNombre;
                }
            }
            return "";
        }

        public int CantidadProductos()
        {
            int Retorno = 0;
            foreach (Producto P in ListaProductos)
            {
                Retorno++;
            }
            return Retorno;
        }

        public bool EsProductoCorrecto(string Prod)
        {
            foreach (Producto P in ListaProductos)
            {
                if (P.EproductoNombre == Prod)
                {
                    return true;
                }
            }
            return false;
        }

        public string AltaIngrediente(string Prod, string Ing, int Med, string Um)
        {
            ListaIngredientes.Add(new Ingrediente(Prod, Ing, Med, Um));
            return ListaIngredientes.Last().ToString();
        }

        public string AltaPasos(string Prod, int Orden, string Descripcion)
        {
            ListaPasos.Add(new Pasos(Prod, Orden, Descripcion));
            return ListaPasos.Last().ToString();
        }

        public string VerIngredientes(string Prod)
        {
            string Retorno = "";
            foreach (Ingrediente I in ListaIngredientes)
            {
                if (Prod == I.EProducto) 
                {
                    Retorno = I.Enombre + "-" + I.Ecantidad + "-" + I.Eum + ";" + Retorno;
                }
                
            }
            return Retorno;
        }

        public void BorrarIngrediente(string Eproducto, string EnombreCantidadUm)
        {
            int Aborrar = 0, I = 0;
            string InombreCantidadUm;
            foreach (Ingrediente LI in ListaIngredientes)
            {
                InombreCantidadUm = LI.Enombre + " " + LI.Ecantidad + " " + LI.Eum;
                if (InombreCantidadUm == EnombreCantidadUm && Eproducto == LI.EProducto)
                {
                    Aborrar = I;
                }
                I++;
            }
            ListaIngredientes.RemoveAt(Aborrar);
        }

        public int CantidadIngredientes(string Prod)
        {
            int Retorno = 0;
            foreach (Ingrediente I in ListaIngredientes)
            {
                if (Prod == I.EProducto)
                {
                    Retorno++;
                }

            }
            return Retorno;
        }

        public string[] GetIngredientes(string Prod)
        {
            int C = CantidadIngredientes(Prod);
            int I = 0;
            string[] Retorno = new string[C];
            foreach (Ingrediente LI in ListaIngredientes)
            {
                if (Prod == LI.EProducto)
                {
                    Retorno[I] = LI.Enombre + " " + LI.Ecantidad + " " + LI.Eum;
                    I++;
                }

            }
            return Retorno;
        }


        public int CantidadPasos(string Prod)
        {
            int Retorno = 0;
            foreach (Pasos PA in ListaPasos)
            {
                if (Prod == PA.EProducto)
                {
                    Retorno++;
                }

            }
            return Retorno;
        }

        public string[] GetPasos(string Prod)
        {
            int C = CantidadPasos(Prod);
            int I = 0;
            string[] Retorno = new string[C];
            foreach (Pasos PA in ListaPasos.OrderBy(x => x.Eorden))
            {
                if (Prod == PA.EProducto)
                {
                    Retorno[I] = PA.Eorden.ToString() + ")" + PA.Edescripcion;
                    I++;
                }

            }
            return Retorno;
        }

        public int GetPasos(string Eproducto, string EordenDescripcion)
        {
            string IordenDescripcion;
            foreach (Pasos PA in ListaPasos)
            {
                IordenDescripcion = PA.Eorden.ToString() + ")" + PA.Edescripcion;
                if (IordenDescripcion == EordenDescripcion && Eproducto == PA.EProducto)
                {
                    return PA.Eorden;
                }
            }
            return 0;
        }

        public bool GetPasos(string Eproducto, int Eorden)
        {
            foreach (Pasos PA in ListaPasos)
            {
                if (Eorden == PA.Eorden && Eproducto == PA.EProducto)
                {
                    return true;
                }
            }
            return false;
        }

        public void BorrarPasos(string Eproducto, int Eorden)
        {
            int Aborrar = 0, I = 0;
            foreach (Pasos PA in ListaPasos)
            {
                if (Eorden == PA.Eorden && Eproducto == PA.EProducto)
                {
                    Aborrar = I;
                }
                I++;
            }
            ListaPasos.RemoveAt(Aborrar);
        }

        public bool EsIngredienteCorrecto(string Eproducto, string Eingrediente)
        {
            foreach (Ingrediente LI in ListaIngredientes)
            {
                if (LI.EProducto == Eproducto && LI.Enombre == Eingrediente)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
