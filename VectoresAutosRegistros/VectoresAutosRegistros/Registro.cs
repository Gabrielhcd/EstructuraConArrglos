using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresAutosRegistros
{
	class Registro
	{
		private Auto[] _vecRegistros = new Auto[15];
		private int autos = 0;

		public void Agregar(Auto carrito)
		{
			_vecRegistros[autos] = carrito;
			autos++;
		}
		public string Buscar(string placa)
		{
			string Search = "";
			for(int i=0; i <= _vecRegistros.Length; i++)
			{
				if (placa==_vecRegistros[i].placa)
				{
					Search = _vecRegistros[i].ToString();
				}
				else
				{
					Search = "No exist el registro";
				}
			}
			return Search;
		}
		public void Eliminar(int posicion)
		{
			for(int i = posicion; i < _vecRegistros.Length; i++)
			{
				_vecRegistros[i] = _vecRegistros[i + 1];
			}
		}
		public void Insertar(int posicion, Auto objeto)
		{
			Auto temp;
			for(int i = posicion; i <= _vecRegistros.Length; i++)
			{
				temp = _vecRegistros[i];
				_vecRegistros[i] = objeto;
				_vecRegistros[i + 1] = temp;
			}
		}
		public string Listar()
		{
			string show = "";
			for(int i = 0; i <= _vecRegistros.Length; i++)
			{
				show = _vecRegistros[i].ToString();
			}
			return show;
		}
	}
}
