using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasteleria
{
	[Serializable]
	class MedidasRepositorio
    {
		static public Medida[] GetMedidas()
		{
			Medida[] Ret = new Medida[6];
			Ret[0] = new Medida("KG","KG");
			Ret[1] = new Medida("MG", "MG");
			Ret[2] = new Medida("LT","LT");
			Ret[3] = new Medida("CM Cúbicos", "CM3");
			Ret[4] = new Medida("GR", "GR");
			Ret[5] = new Medida("Unidad", "UN");
			return Ret;
		}

		static public bool GetEsMedidaCorrecta(string EvalorUM)
		{
			Medida[] Verificar;
			Verificar = MedidasRepositorio.GetMedidas();
			foreach (Medida V in Verificar)
			{
				if (V.EmedidaValor == EvalorUM)
				{
					return true;
				}
			}
			return false;
		}

		static public string GetMedidasTodas()
		{
			string Retorno = "";
			Medida[] Verificar;
			Verificar = MedidasRepositorio.GetMedidas();
			foreach (Medida V in Verificar)
			{
				Retorno = V.EmedidaNombre + "-" + V.EmedidaValor + ";" + Retorno;
			}
			return Retorno;
		}
	}
}
