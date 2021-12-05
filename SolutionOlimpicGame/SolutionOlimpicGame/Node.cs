namespace SolutionOlimpicGame
{
	public class Node
	{
		#region Поля и свойства

		/// <summary>
		/// Ключ узла.
		/// </summary>
		public int Key { get; set; }

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
		public Node(int key)
		{
			this.Key = key;
			Left = null;
			Rigth = null;
			Height = 1;
		}

		#endregion
	}
}
