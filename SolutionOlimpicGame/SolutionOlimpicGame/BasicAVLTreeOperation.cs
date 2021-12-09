using System;
using System.Collections.Generic;

namespace SolutionOlimpicGame
{
	/// <summary>
	/// Базовые операции над деревом.
	/// </summary>
	public static class BasicAVLTreeOperation
	{
		#region Вложенный метод

		/// <summary>
		/// Информация о узле.
		/// </summary>
		private class NodeInfo
		{
			/// <summary>
			/// Узел.
			/// </summary>
			public Node Node { get; set; }

			/// <summary>
			/// Сообщение.
			/// </summary>
			public string Text { get; set; }

			/// <summary>
			/// Начальная позиция.
			/// </summary>
			public int StartPosition { get; set; }

			/// <summary>
			/// Размер.
			/// </summary>
			public int Size { get { return Text.Length; } }

			/// <summary>
			/// Конечная позиция.
			/// </summary>
			public int EndPosition { get { return StartPosition + Size; } set { StartPosition = value - Size; } }

			/// <summary>
			/// Родительский узел.
			/// </summary>
			public NodeInfo Parent { get; set; }

			/// <summary>
			/// Левый узел.
			/// </summary>
			public NodeInfo Left { get; set; } 

			/// <summary>
			/// Правый узел.
			/// </summary>
			public NodeInfo Right { get; set; }
		}

		#endregion

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
		/// Правый разворот поддерева.
		/// </summary>
		/// <param name="node">Узел</param>
		/// <returns>Разворот поддерева.</returns>
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
		/// Левый разворот поддерева.
		/// </summary>
		/// <param name="node">Узел</param>
		/// <returns>Разворот поддерева.</returns>
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
		/// Балансировка поддерева.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <returns>Скорректированное поддерево.</returns>
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
		/// Вставка ключей.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <param name="key">Ключ.</param>
		/// <param name="value">Значение.</param>
		/// <returns>Узел со вставленным значением.</returns>
		public static Node Insert(Node node, int key, int value)
		{
			if (node == null)
			{
				return new Node(key, value);
			}

			if (key < node.Key)
				node.Left = Insert(node.Left, key, value);
			else
				node.Rigth = Insert(node.Rigth, key, value);

			return Balance(node);
		}

		/// <summary>
		/// Находим узел с минимальным ключом в поддереве.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <returns>Узла с минимальным ключом в поддереве.</returns>
		public static Node FindMin(Node node)
		{
			return node.Left == null
				? FindMin(node)
				: node;
		}

		/// <summary>
		/// Удаление узла с минимальным ключом из поддерева.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <returns>Узлел без минимального ключа в поддереве.</returns>
		public static Node RemoveMin(Node node)
		{
			if (node.Left == null)
				return node.Rigth;
			node.Left = RemoveMin(node.Left);

			return Balance(node);
		}

		/// <summary>
		/// Удаление ключа из поддерева.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <param name="key">Ключ.</param>
		/// <returns>Узел без ключа.</returns>
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

		/// <summary>
		/// Получить узел со значением.
		/// </summary>
		/// <param name="node">Узел.</param>
		/// <param name="key">Ключ.</param>
		/// <returns>Узел со значением.</returns>
		public static Node GetNodeValue(Node node, int key, out int? value)
		{
			if (node == null)
			{
				value = null;
				return null;
			}

			if (key < node.Key)
				node.Left = GetNodeValue(node.Left, key, out value);
			else if (key > node.Key)
				node.Rigth = GetNodeValue(node.Rigth, key, out value);
			else 
			{
				value = node.Value;
				return node;
			}

			return node;
		}


		public static void Print(Node node, string textFormat = "0", int spacing = 1, int topMargin = 2, int leftMargin = 2)
		{
			if (node == null) return;

			int nodeTop = Console.CursorTop + topMargin;
			var last = new List<NodeInfo>();
			var next = node;

			for (int level = 0; next != null; level++)
			{
				var item = new NodeInfo()
				{
					Node = next,
					Text = $"({next.Key.ToString(textFormat)}; {next.Value.ToString(textFormat)})",
				};

				if (level < last.Count)
				{
					item.StartPosition = last[level].EndPosition + spacing;
					last[level] = item;
				}
				else
				{
					item.StartPosition = leftMargin;
					last.Add(item);
				}

				if (level > 0)
				{
					item.Parent = last[level - 1];

					if (next == item.Parent.Node.Left)
					{
						item.Parent.Left = item;
						item.EndPosition = Math.Max(item.EndPosition, item.Parent.StartPosition - 1);
					}
					else
					{
						item.Parent.Right = item;
						item.StartPosition = Math.Max(item.StartPosition, item.Parent.EndPosition + 1);
					}
				}

				next = next.Left ?? next.Rigth;

				for (; next == null; item = item.Parent)
				{
					var top = nodeTop + 2 * level;
					Print(item.Text, top, item.StartPosition);

					if (item.Left != null)
					{
						Print("/", top + 1, item.Left.EndPosition);
						Print("_", top, item.Left.EndPosition + 1, item.StartPosition);
					}

					if (item.Right != null)
					{
						Print("_", top, item.EndPosition, item.Right.StartPosition - 1);
						Print("\\", top + 1, item.Right.StartPosition - 1);
					}

					if (--level < 0)
						break;

					if (item == item.Parent.Left)
					{
						item.Parent.StartPosition = item.EndPosition + 1;
						next = item.Parent.Node.Rigth;
					}
					else
					{
						if (item.Parent.Left == null)
							item.Parent.EndPosition = item.StartPosition - 1;
						else
							item.Parent.StartPosition += (item.StartPosition - 1 - item.Parent.EndPosition) / 2;
					}
				}
			}

			Console.SetCursorPosition(0, nodeTop + 2 * last.Count - 1);
		}

		private static void Print(string input, int top, int left, int right = -1)
		{
			Console.SetCursorPosition(left, top);
			if (right < 0) 
				right = left + input.Length;
			while (Console.CursorLeft < right) 
				Console.Write(input);
		}

		#endregion
	}
}
