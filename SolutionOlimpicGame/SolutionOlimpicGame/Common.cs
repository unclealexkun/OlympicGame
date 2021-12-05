namespace SolutionOlimpicGame
{
	public static class Common
	{
		#region Методы

		/// <summary>
		/// Получить высоту поддерева.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <returns>Высота поддерева.</returns>
		public static int GetHeight(Node node)
		{
			return node == null
				? 0
				: node.Height;
		}

		/// <summary>
		/// Вычисляем баланс фактор.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <returns>Баланс фактор.</returns>
		public static int BalanceFactor(Node node)
		{
			return GetHeight(node.Rigth) - GetHeight(node.Left);
		}

		/// <summary>
		/// Восстанавливаем корректной высоты поддерева.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <returns>Исправленное значение высоты поддерева.</returns>
		public static int FixHeight(Node node)
		{
			var heightLeft = GetHeight(node.Left);
			var heightRight = GetHeight(node.Rigth);
			return (heightLeft > heightRight
				? heightLeft
				: heightRight) + 1;
		}

		/// <summary>
		/// Правый разворот дерева.
		/// </summary>
		/// <param name="node">Узел</param>
		/// <returns></returns>
		public static Node RotateRight(Node node)
		{
			
		}

		#endregion
	}
}
