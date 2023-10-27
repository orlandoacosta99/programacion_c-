using System.Drawing;

namespace Area_de_Triangulo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string userBase;
			string userAltura;
			double sideBase;
			double sideAltura;
			double squareArea;
			Console.WriteLine("Hola, encontraremos el area de un triangulo");
			Console.WriteLine("Ingresa la base del cuadrado: ");			
			userBase = Console.ReadLine();
			Console.WriteLine("Ingresa la altura del cuadrado: ");
			userAltura = Console.ReadLine();


			if (double.TryParse(userBase, out sideBase) && double.TryParse(userAltura, out sideAltura))
			{
				squareArea = sideBase * sideAltura/2;

				Console.WriteLine($"El área del triangulo es: {squareArea}");
			}
			else
			{
				Console.WriteLine("Los datos proporcionados son incorrectos.");
			}
			Console.ReadKey();

		}
	}
}