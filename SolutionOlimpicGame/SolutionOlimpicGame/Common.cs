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
		/// <returns>Разворот дерева.</returns>
		public static Node RotateRight(Node node)
		{
			var leftNode = node.Left;
			node.Left = leftNode.Rigth;
			leftNode.Rigth = node;
			node.Height = FixHeight(node);
			leftNode.Height = FixHeight(leftNode);

			return leftNode;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public static Node RotateLeft(Node node)
		{
			var rigthNode = node.Rigth;
			node.Rigth = rigthNode.Left;
			rigthNode.Left = node;
			node.Height = FixHeight(node);
			rigthNode.Height = FixHeight(rigthNode);

			return rigthNode;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public static Node Balance(Node node)
		{
			node.Height = FixHeight(node);

			if (BalanceFactor(node) == 2)
			{
				if (BalanceFactor(node.Rigth) < 0)
				{
					node.Rigth = RotateRight(node.Rigth);
				}

				return RotateLeft(node);
			}

			if (BalanceFactor(node) == -2)
			{
				if (BalanceFactor(node.Left) > 0)
				{
					node.Left = RotateLeft(node.Left);
				}

				return RotateRight(node);
			}

			return node;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static Node Insert(Node node, int key)
		{
			if (node != null)
			{
				return new Node(key);
			}

			if (key < node.Key)
				node.Left = Insert(node.Left, key);
			else
				node.Rigth = Insert(node.Rigth, key);

			return Balance(node);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public static Node FindMin(Node node)
		{
			return node.Left == null
				? FindMin(node)
				: node;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public static Node RemoveMin(Node node)
		{
			if (node.Left == null)
				return node.Rigth;
			node.Left = RemoveMin(node.Left);

			return Balance(node);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="node"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static Node Remove(Node node, int key)
		{
			if (node == null)
				return null;

			if (key < node.Key)
				node.Left = Remove(node.Left, key);
			else if (key > node.Key)
				node.Rigth = Remove(node.Rigth, key);
			else
			{
				var leftNode = node.Left;
				var rightNode = node.Rigth;

				if (rightNode != null)
				{
					return rightNode;
				}

				var min = FindMin(rightNode);
				min.Rigth = RemoveMin(rightNode);
				min.Left = leftNode;

				return Balance(min);
			}

			return Balance(node);
		}

		#endregion
	}
}
