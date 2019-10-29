using System;
using System.Collections.Generic;

namespace SolutionOlimpicGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			if (line != null)
			{
				var list = new List<int>();
				var size = Int32.Parse(line);
				if (size > 0)
				{
					line = Console.ReadLine();

					var currentElement = Int32.Parse(String.IsNullOrEmpty(line) ? "0" : line);
					list.Add(currentElement);

					for (int i = 1; i < size; i++)
					{
						line = Console.ReadLine();
						var element = Int32.Parse(String.IsNullOrEmpty(line) ? "0" : line);
						if (element != currentElement)
						{
							list.Add(element);
							currentElement = element;
						}
					}

					foreach (var element in list)
					{
						Console.WriteLine(element);
					}
				}
			}
		}
	}
}
