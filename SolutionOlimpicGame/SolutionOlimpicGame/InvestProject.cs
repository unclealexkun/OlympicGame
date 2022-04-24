namespace SolutionOlimpicGame
{
	/// <summary>
	/// Инвистиционный проект.
	/// </summary>
	public class InvestProject
	{
		/// <summary>
		/// Идентификатор проекта.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Cтоимость вложений.
		/// </summary>
		public decimal Cost { get; set; }

		/// <summary>
		/// Период без дохода в месяцах.
		/// </summary>
		public int PeriodWithoutIncome { get; set; }

		/// <summary>
		/// Доход инвестора в месяц после периода без дохода.
		/// </summary>
		public decimal InvestorIncome { get; set; }
	}
}
