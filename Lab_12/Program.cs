using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class Program
	{
        
        
			public static void Main()
		{
			
			{
				Console.Write("Введите радиус окружности: ");
				double Radius = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите координату Х точки: ");
				double X = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Console.Write("Введите координату Y точки: ");
				double Y = Math.Abs(Convert.ToDouble(Console.ReadLine()));
				Circle.GetСircumference(Radius);
				Circle.GetSquare(Radius);
				Circle.GetPosition(Radius, X, Y);
			}
			
		}

		static class Circle
		{
			public static void GetСircumference(double Radius)
			{
				double Сircumference = Math.PI * 2 * Radius;
				Console.WriteLine("Длина окружности равна {0:f2}", Сircumference);
				Console.ReadKey();
			}
			public static void GetSquare(double Radius)
			{
				double Square = Math.PI * Math.Pow(Radius, 2.0);
				Console.WriteLine("Площадь круга равна {0:f2}", Square);
				Console.ReadKey();
			}
			public static void GetPosition(double Radius, double X, double Y)
			{
				if (X <= Radius && Y <= Radius)
				{
					Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с радиусом {2}", X, Y, Radius);
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит кругу с радиусом {2}", X, Y, Radius);
					Console.ReadKey();
				}
			}
		}
	} }
