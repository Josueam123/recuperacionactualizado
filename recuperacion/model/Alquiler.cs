using System;
using recuperaciones;

namespace recuperacion
{
	class Alquiler : Barco
	{
		public Cliente cliente { get; set; }
		public DateTime fechaInicial { get; set; }
		public DateTime fechaFinal { get; set; }
		public int posAmarre { get; set; }

		public Alquiler(string matricula, double metros, int anioFab, DateTime fInicial,
		DateTime fFinal, int posAmarre)
		: base(matricula, metros, anioFab)
		{
			this.fechaInicial = fInicial;
			this.fechaFinal = fFinal;
			this.posAmarre = posAmarre;
			this.cliente = new Cliente();
		}
		public double calcularAlquiler()
		{
			TimeSpan diff = fechaFinal - fechaInicial;
			int dias = diff.Days;
			Barco barco = new Barco();
			double res = barco.getModulo() * 1.8;
			return res;
		}

	}

}