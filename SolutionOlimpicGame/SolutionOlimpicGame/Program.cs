using System;
using System.Linq;

namespace SolutionOlimpicGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			if (line != null)
			{
				string j = line;

				line = Console.ReadLine();

				if (line != null)
				{
					string s = line;

					Console.Write(s.Select(x => j.IndexOf(x) != -1).Count(y => y));
				}
			}
		}
	}
}
