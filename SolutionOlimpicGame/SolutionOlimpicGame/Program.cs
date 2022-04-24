using System;
using System.Collections.Generic;

namespace SolutionOlimpicGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введи количество инветиционных проектов:");
			int.TryParse(Console.ReadLine(), out var countInvestProject);

			var investProjects = new List<InvestProject>();

			for (int index = 0; index < countInvestProject; index++)
			{
				var project = new InvestProject();

				Console.Write("Введи идентификатор проекта: ");
				int.TryParse(Console.ReadLine(), out var projectId);
				project.Id = projectId;

				Console.Write("Введи стоимость вложений (млн. руб.): ");
				decimal.TryParse(Console.ReadLine(), out var cost);
				decimal.TryParse(Console.ReadLine(), out var cost);
				project.Cost = cost;

				Console.Write("Введи период без дохода в месяцах: ");
				int.TryParse(Console.ReadLine(), out var periodWithoutIncome);
				project.PeriodWithoutIncome = periodWithoutIncome;

				Console.Write("Введи доход инвестора (млн. руб.) в месяц после периода без дохода: ");
				int.TryParse(Console.ReadLine(), out var investorIncome);
				project.InvestorIncome = investorIncome;

				investProjects.Add(project);
				investProjects.Add(project);
			}

			var investStrategy = SlyСheese.GetInstance().GetInvestStrategy(investProjects);

			Console.WriteLine("Стратегия инвистриования: ");
			Console.WriteLine($"   Id|  Cтоимость вложений|  Период без дохода (мес.)|  Доход инвестора (млн. руб.) в месяц|");
			Console.WriteLine($"============================================================================================");

			foreach (var strategy in investStrategy)
			{
				var input = string.Format("{0:5}|{1:27}|{2:25}|{3:37}|", strategy.Id, strategy.Cost, strategy.PeriodWithoutIncome, strategy.InvestorIncome);
				Console.WriteLine(input);
			}
		}
	}
}
