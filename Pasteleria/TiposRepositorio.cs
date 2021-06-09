using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
	[Serializable]
	class TiposRepositorio
    {
		static public Tipo[] GetTipos()
		{
			Tipo[] Ret = new Tipo[6];
			Ret[0] = new Tipo("Torta","TORTA");
			Ret[1] = new Tipo("Tarta","TARTA");
			Ret[2] = new Tipo("Budin","BUDIN");
			Ret[3] = new Tipo("Pan","PAN");
			Ret[4] = new Tipo("Factura","FACTURA");
			Ret[5] = new Tipo("Postre","POSTRE");

			return Ret;
		}

		static public bool EsTipoCorrecto(string EValor)
		{
			Tipo[] Verificar;
			Verificar = TiposRepositorio.GetTipos();
			foreach (Tipo V in Verificar)
			{
				if (V.EtipoValor == EValor)
				{
					return true;
				}
			}
			return false;
		}

		static public string GetTiposTodos()
		{
			string Retorno = "";
			Tipo[] Verificar;
			Verificar = TiposRepositorio.GetTipos();
			foreach (Tipo V in Verificar)
			{
				Retorno = V.EtipoValor + ";" + Retorno;
			}
			return Retorno;
		}
	}
}
