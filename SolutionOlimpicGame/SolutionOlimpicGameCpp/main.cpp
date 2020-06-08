#include <iostream>
#include <locale>

#define SIZE 2

using namespace std;

struct VideoLibrary
{
	char filmName[1000];
	double cost;
	char director[1000];
};

int main()
{
	setlocale(LC_ALL, "Russian");

	VideoLibrary catalog[SIZE];

	for(int index = 0; index < SIZE; ++index)
	{
		VideoLibrary record;
		cout << "Введи название фильма: ";
		cin >> record.filmName;
		cout << "Введи стоимость: ";
		cin >> record.cost;
		cout << "Введи ФИО режиссера: ";
		cin >> record.director;

		catalog[index] = record;
	}

	for(int index = 0; index < SIZE; ++index)
	{
		VideoLibrary record = catalog[index];
		cout << "Запись №" << index + 1 << endl;
		cout << "Название фильма: " << record.filmName << endl;
		cout << "Cтоимость: " << fixed << record.cost << endl;
		cout << "ФИО режиссера: " << record.director << endl;
	}

	return 0;
}