using System;
using System.Collections.Generic;
using System.Linq;

namespace recuperacion
{
	class Program
	{
		static List<Alquiler> alquileres = new List<Alquiler>();
		static void Main(string[] args)
		{
			string matricula;
			double metros;
			int anioFab, posAmarre;
			DateTime fInicial, fFinal;

			int op = 0;

			//alquileres.Add(new Alquiler("josue",
										//50.5,
										//2001,
										//DateTime.Parse("2021-08-01"),
										//DateTime.Parse("2021-09-01"),
										//
										//));
			//alquileres.Add(new Alquiler("aguirre",
                                        //60.5,
                                        //2002,
                                        //DateTime.Parse("2021-08-01"),
                                        //DateTime.Parse("2021-09-01"),
                                        //02
                                        //));
			//alquileres.Add(new Alquiler("mendoza",
										//70.5,
										//2003,
										//DateTime.Parse("2021-08-10"),
										//DateTime.Parse("2021-09-01"),
										//02
										//));

			do
			{
				Console.WriteLine("SELECCIONE UNA OPCION DEL MENU");
				Console.WriteLine("1.- Agregar un registro de alquiler\n" +
				"2.- Consultar un alquiler\n" +
							"3.- Consultar todos los alquileres de un dia especifico\n" +
							"4.- Consultar los alquileres cuyo valor sera mayor a $50\n" +
							"5.- Salir");
				op = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("");

				switch (op)
				{
					case 1:
						Console.WriteLine("Matricula: ");
						matricula = Console.ReadLine();
						Console.WriteLine("Metros: ");
						metros = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("Anio de fabricacion: ");
						anioFab = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Fecha inicial: (yyyy-MM-dd)");
						fInicial = DateTime.Parse(Console.ReadLine());
						Console.WriteLine("Fecha final: (yyyy-MM-dd)");
						fFinal = DateTime.Parse(Console.ReadLine());
						Console.WriteLine("Posicion de amarre: ");
						posAmarre = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("");

						alquileres.Add(new Alquiler(matricula, metros, anioFab, fInicial, fFinal, posAmarre));
						break;
					case 2:
						alquilerEspecifico();
						break;
					case 3:
						registroUnDia();
						break;
					case 4:
						mayorCincuenta();
						break;
					case 5:
						break;
				}
			} while (op != 5);


			Console.ReadKey();
		}


		public static void alquilerEspecifico()
		{
			string cedula;
			Console.WriteLine("Ingrese la cedula del cliente");
			cedula = Console.ReadLine();
			Console.WriteLine("");
			IEnumerable<Alquiler> alquileresID = alquileres.Where(alquiler => alquiler.cliente.cedula.Equals(cedula)).Select(alquiler => alquiler);
			if (alquileresID.Count() > 0)
			{
				Console.WriteLine("Alquiler encontrado.\n");
				foreach (Alquiler alquiler in alquileresID)
				{
					Console.WriteLine("Fecha incial: {0}", alquiler.fechaInicial.ToString("yyyy-MM-dd"));
					Console.WriteLine("Fecha final: {0}", alquiler.fechaFinal.ToString("yyyy-MM-dd"));
					Console.WriteLine("Puesto de amarre: {0}", alquiler.posAmarre);
				}
				Console.WriteLine("");
			}
			else
			{
				Console.WriteLine("NO ENCONTRADO\n");
			}

		}
		public static void registroUnDia()
		{
			DateTime fecha;
			Console.WriteLine("Ingrese la fecha: (yyyy-MM-dd)");
			fecha = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("");
			IEnumerable<Alquiler> alquileresFecha = alquileres.Where(alquiler => alquiler.fechaInicial.Equals(fecha)).Select(alquiler => alquiler);
			if (alquileresFecha.Count() > 0)
			{
				Console.WriteLine("Alquiler encontrado.\n");
				foreach (Alquiler alquiler in alquileresFecha)
				{
					Console.WriteLine("Fecha incial: {0}", alquiler.fechaInicial.ToString("yyyy-MM-dd"));
					Console.WriteLine("Fecha final: {0}", alquiler.fechaFinal.ToString("yyyy-MM-dd"));
					Console.WriteLine("Puesto de amarre: {0}", alquiler.posAmarre);
					Console.WriteLine("");
				}
				Console.WriteLine("");
			}
			else
			{
				Console.WriteLine("NO ENCONTRADO\n");
			}

		}
		public static void mayorCincuenta()
		{
			IEnumerable<Alquiler> alquileresMayor = alquileres.Where(alquiler => alquiler.calcularAlquiler() > 50).Select(alquiler => alquiler);

			if (alquileresMayor.Count() > 0)
			{
				Console.WriteLine("Alquiler encontrado.\n");
				foreach (Alquiler alquiler in alquileresMayor)
				{
					Console.WriteLine("Fecha incial: {0}", alquiler.fechaInicial.ToString("yyyy-MM-dd"));
					Console.WriteLine("Fecha final: {0}", alquiler.fechaFinal.ToString("yyyy-MM-dd"));
					Console.WriteLine("Puesto de amarre: {0}", alquiler.posAmarre);
					Console.WriteLine("Total: {0}", alquiler.calcularAlquiler());
					Console.WriteLine("");
				}
				Console.WriteLine("");
			}
			else
			{
				Console.WriteLine("NO ENCONTRADO\n");

				Console.WriteLine("");
			}

		}

	}
}
