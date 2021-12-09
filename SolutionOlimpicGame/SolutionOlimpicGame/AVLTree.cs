﻿namespace SolutionOlimpicGame
{
	/// <summary>
	/// AVL дерево.
	/// </summary>
	public class AVLTree : IAVLTree
	{
		#region Поля и свойства

		/// <summary>
		/// Узел.
		/// </summary>
		private Node node;

		#endregion

		#region IAVLTree

		public void Print()
		{
			BasicAVLTreeOperation.Print(this.node);
		}

		public int? GetValue(int key)
		{
			BasicAVLTreeOperation.GetNodeValue(this.node, key, out var result);
			return result;
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
