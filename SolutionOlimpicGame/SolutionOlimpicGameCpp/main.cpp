#include <iostream>
#include<clocale>

using namespace std;

//Прямая
struct StraightLine
{
	//Коэффиценты
	double a;
	double b;
};

int main()
{
	setlocale(LC_ALL, "RUS");

	int count;

	cout << "Введи количество прямых: ";
	cin >> count;

	StraightLine straightLines[1000];

	for (int index = 0; index < count; ++index)
	{
		cout << "Введи коэффицент a: ";
		cin >> straightLines->a;
		cout << "Введи коэффицент b: ";
		cin >> straightLines->b;
	}

	int count_paralells_ox;
	int count_paralells_oy;

	for (int index = 0; index < count; ++index)
	{
		if (straightLines->a == 0)
		{
			count_paralells_ox++;
		}
		if (straightLines->b == 0)
		{
			count_paralells_oy++;
		}
	}

	cout << "Количество прямых паралелльных Ox: " << count_paralells_ox << endl;
	cout << "Количество прямых паралелльных Oy: " << count_paralells_oy << endl;

	return 0;
}