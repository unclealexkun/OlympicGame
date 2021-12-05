namespace SolutionOlimpicGame
{
	public interface IAVLTree
	{
		/// <summary>
		/// Вывод дерева.
		/// </summary>
		/// <returns>Дерево в формате строки.</returns>
		string Print();

		/// <summary>
		/// Получить значение по ключу.
		/// </summary>
		/// <param name="key">Ключ.</param>
		/// <returns>Значение по хранящему ключу.</returns>
		int GetValue(int key);

		/// <summary>
		/// Добавить элемент в дерево.
		/// </summary>
		/// <param name="key">Ключ.</param>
		/// <param name="value">Значение.</param>
		void Add(int key, int value);

		/// <summary>
		/// Удалить элемент из дерева.
		/// </summary>
		/// <param name="key">Ключ.</param>
		void Remove(int key);
	}
}
