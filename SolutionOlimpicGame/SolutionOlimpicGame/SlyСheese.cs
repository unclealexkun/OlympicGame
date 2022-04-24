using System;
using System.Collections.Generic;

namespace SolutionOlimpicGame
{
	/// <summary>
	/// Класс расчёта стратегий инвистиций.
	/// </summary>
	public class SlyСheese
	{
		#region Поля и Cвойства

		/// <summary>
		/// Lazy-реализация Singleton.
		/// </summary>
		private static readonly Lazy<SlyСheese> lazy = new Lazy<SlyСheese>(() => new SlyСheese());

		#endregion

		#region Методы

		/// <summary>
		/// Получить instance.
		/// </summary>
		/// <returns>Singleton класс.</returns>
		public static SlyСheese GetInstance()
		{
			return lazy.Value;
		}

		public List<InvestProject> GetInvestStrategy(List<InvestProject> investProjects)
		{
			return investProjects;
		}

		#endregion


		#region Конструктор

		private SlyСheese()
		{ }

		#endregion
	}
}
