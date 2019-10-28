using System;

namespace SolutionOlimpicGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			if (line != null)
			{
				var size = 0;
				int.TryParse(line, out size);

				var maxValue = 0;
				var countOne = 0;

				for (var index = 0; index < size; ++index)
				{
					var element = 0;
					int.TryParse(Console.ReadLine(), out element);
					if (element == 0)
					{
						if (maxValue < countOne)
						{
							maxValue = countOne;
						}
						countOne = 0;
					}
					else
					{
						++countOne;
					}
				}

				Console.Write(maxValue);
			}
		}
	}
}
