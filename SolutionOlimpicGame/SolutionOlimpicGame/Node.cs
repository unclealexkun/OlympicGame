namespace SolutionOlimpicGame
{
	/// <summary>
	/// Узел.
	/// </summary>
	public class Node
	{
		#region Поля и свойства

		/// <summary>
		/// Ключ узла.
		/// </summary>
		public int Key { get; set; }

		/// <summary>
		/// Значение узла.
		/// </summary>
		public int Value { get; set; }

		/// <summary>
		/// Высота поддерева с корнем в данном узле.
		/// </summary>
		public int Height { get; set; }

		/// <summary>
		/// Указатель на левое поддерево.
		/// </summary>
		public Node Left { get; set; }

		/// <summary>
		/// Указатель на правое поддерево.
		/// </summary>
		public Node Rigth { get; set; }

		#endregion

		#region Конструктор

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="key">Ключ узла.</param>
		/// <param name="value">Значение.</param>
		public Node(int key, int value)
		{
			this.Key = key;
			this.Value = value;
			Left = null;
			Rigth = null;
			Height = 1;
		}

		#endregion
	}
}
