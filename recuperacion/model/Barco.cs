using System;

namespace recuperaciones
{
	class Barco 
	{
		public string matricula { get; set; }
		public double metros { get; set; }
		public int anioFab { get; set; }

		// private double modulo { get; set; }
		private int yate = 3;

		public Barco(string matricula, double metros, int anioFab)
		{
			this.matricula = matricula;
			this.metros = metros;
			this.anioFab = anioFab;
		}

		public Barco(){

		}

		// public Barco Modulo(double modulo){
		// 	this.modulo = modulo;
		// 	return this;
		// }
		public double getModulo()
		{
			int tipo = 0;
			double res = 0.2 * metros;
			Console.WriteLine("Seleccione el tipo de barco");
			Console.WriteLine("1.- Velero\n2.- Deportivo a motor\n3.- Yate");
			tipo = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("");

			switch (tipo)
			{ 
				case 1:
					Console.Write("Numero de mastiles: ");
					int mastiles = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("");

					res = res * mastiles;
					break;
				case 2:
					Console.Write("Potencia en CV: ");
					double potenciaDeportivo = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("");

					res = res * potenciaDeportivo;
					break;
				case 3:
					Console.Write("Potencia en CV: ");
					double potenciaYate = Convert.ToDouble(Console.ReadLine());
					Console.Write("Numero de camarotes: ");
					int camarotes = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("");
					
					res = res * (potenciaYate + camarotes);
					break;
				case 4:
					Console.WriteLine("Opcion no válida");
					break;
			}
			return res;
		}
	}
}