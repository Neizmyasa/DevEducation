﻿using System;

public class Variable
{
	public Variable()
	{
		static void Main(string[] args)
        {
			//Пользователь вводит 2 числа(A и B).Выведите в консоль решение (5 * A + B*B)/(B - A)
			Console.WriteLine("Введите первое целое число");
			int A = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите второе целое число");
			int B = Convert.ToInt32(Console.ReadLine());

			int result = (5 * A + B * B) / (B - A);

			Console.WriteLine($"{result}");
			
			//Пользователь вводит 2 значения(A и B).Поменяйте содержимое переменных A и B местами.
			//Пользователь вводит 2 числа(A и B).Выведите в консоль результат деления A на B и остаток от деления.
			//Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A* X+B = C.
			//Пользователь вводит 4 числа(X1, Y1, X2, Y2), описывающие координаты 2 - х точек на координатной плоскости.
			//	Выведите уравнение прямой в формате Y = AX + B, проходящей через эти точки.


		}
	}
}
