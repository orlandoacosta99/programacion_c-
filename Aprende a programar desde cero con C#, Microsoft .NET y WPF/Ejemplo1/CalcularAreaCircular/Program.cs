using System;

namespace CalcularAreaCircular
{
	class Program
	{
		static void Main(string[] args)
		{
			const double Pi = 3.1416;
			string userData;
			double radius;
			double circleArea;

			Console.WriteLine("Proporcionba el radio");
			userData = Console.ReadLine();
			if (double.TryParse(userData, out radius))
			{
				circleArea = Pi * Math.Pow(radius, 2);
				Console.WriteLine($"El área de tu circulo es: {circleArea}");

			}
			else
			{
				Console.WriteLine("El dato es invalido");
			}
			Console.ReadLine();
		}
	}


}
