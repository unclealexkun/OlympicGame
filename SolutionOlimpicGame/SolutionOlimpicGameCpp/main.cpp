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
		cout << "����� �������� ������: ";
		cin >> record.filmName;
		cout << "����� ���������: ";
		cin >> record.cost;
		cout << "����� ��� ���������: ";
		cin >> record.director;

		catalog[index] = record;
	}

	for(int index = 0; index < SIZE; ++index)
	{
		VideoLibrary record = catalog[index];
		cout << "������ �" << index + 1 << endl;
		cout << "�������� ������: " << record.filmName << endl;
		cout << "C��������: " << fixed << record.cost << endl;
		cout << "��� ���������: " << record.director << endl;
	}

	return 0;
}