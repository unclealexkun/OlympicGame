namespace SolutionOlimpicGame
{
	public class AVLTree : IAVLTree
	{
		#region Поля и свойства

		/// <summary>
		/// Узел.
		/// </summary>
		private Node node;

		#endregion

		#region IAVLTree

		public string Print()
		{
			return string.Empty;
		}

		public int GetValue(int key)
		{
			var result = BasicAVLTreeOperation.GetNodeValue(this.node, key);
			return result.Value;
		}

		public void Add(int key, int value)
		{
			this.node = BasicAVLTreeOperation.Insert(this.node, key, value);
		}

		public void Remove(int key)
		{
			this.node = BasicAVLTreeOperation.Remove(this.node, key);
		}

		#endregion

		#region Конструктор

		/// <summary>
		/// Конструктор.
		/// </summary>
		public AVLTree()
		{
			this.node = null;
		}

		#endregion
	}
}
