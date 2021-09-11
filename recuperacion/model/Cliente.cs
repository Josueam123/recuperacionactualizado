using System;
using recuperaciones;

namespace recuperacion
{
	class Cliente
	{
		// public int idCliente { get; set; }
		public string nombre { get; set; }
		public string apellido { get; set; }
		public string cedula { get; set; }

		public Cliente(){
			Console.WriteLine("Nombre del cliente: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Apellido del cliente: ");
			apellido = Console.ReadLine();
			Console.WriteLine("Cedula del cliente: ");
			cedula = Console.ReadLine();
			Console.WriteLine("");
		}

	}
}