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

			Console.WriteLine(tree.GetValue(3));

			tree.Remove(3);

			Console.WriteLine(tree.GetValue(3));
			Console.WriteLine(tree.GetValue(4));
		}
	}
}
