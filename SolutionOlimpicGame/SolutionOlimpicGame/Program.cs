using System;

namespace SolutionOlimpicGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var tree = new AVLTree();
			tree.Add(1, 5);
			tree.Add(2, 2);
			tree.Add(3, 1);
			tree.Add(4, 3);
			tree.Add(6, 1);
			tree.Add(7, 3);
			tree.Add(9, 1);
			tree.Add(5, 3);
			tree.Add(11, 1);
			tree.Add(15, 3);

			Console.WriteLine("Вывод дерева:");
			tree.Print();

			var key = 3;
			Console.WriteLine($"Значение в дереве по ключу {key}: {tree.GetValue(key)}");

			key = 7;
			Console.WriteLine($"Удаляем узел по ключу {key}") ;
			tree.Remove(key);

			Console.WriteLine("Вывод дерева:");
			tree.Print();

			key = 7;
			Console.WriteLine($"Значение в дереве по ключу {key}: {tree.GetValue(key)}");
			key = 4;
			Console.WriteLine($"Значение в дереве по ключу {key}: {tree.GetValue(key)}");

			key = 7;
			var value = 17;
			Console.WriteLine($"Добавляем по ключу {key} значение {value}") ;
			tree.Add(key, value);

			Console.WriteLine("Вывод дерева:");
			tree.Print();

			Console.WriteLine();
			Console.WriteLine("Для завершения нажми любую клавишу...");
			Console.ReadKey();
		}
	}
}
