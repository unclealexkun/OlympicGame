#include <iostream>
#include<clocale>

using namespace std;

//������
struct StraightLine
{
	//�����������
	double a;
	double b;
};

int main()
{
	setlocale(LC_ALL, "RUS");

	int count;

	cout << "����� ���������� ������: ";
	cin >> count;

	StraightLine straightLines[1000];

	for (int index = 0; index < count; ++index)
	{
		cout << "����� ���������� a: ";
		cin >> straightLines->a;
		cout << "����� ���������� b: ";
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

	cout << "���������� ������ ������������ Ox: " << count_paralells_ox << endl;
	cout << "���������� ������ ������������ Oy: " << count_paralells_oy << endl;

	return 0;
}