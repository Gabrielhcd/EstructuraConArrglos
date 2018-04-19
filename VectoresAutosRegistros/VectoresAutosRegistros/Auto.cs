using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresAutosRegistros
{
	class Auto
	{
		private string _Placa;
		private string _Marca;
		private string _Modelo;
		private int _Telefono;
		private int _Year;

		public string placa
		{
			get { return _Placa; }
		}
		public string marca
		{
			get { return _Marca; }
		}
		public string modelo
		{
			get { return _Modelo; }
		}
		public int telefono
		{
			get { return _Telefono; }
		}
		public int year
		{
			get { return _Year; }
		}

		public Auto(string placa, string marca, string modelo, int telefono, int year)
		{
			_Placa = placa;
			_Marca = marca;
			_Modelo = modelo;
			_Telefono = telefono;
			_Year = year;
		}

		public override string ToString()
		{
			string Show = "";
			return Show += _Placa
				+= _Marca
				+= _Modelo
				+= _Telefono
				+= _Year;
		}
	}
}
