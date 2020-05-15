#include<cstdlib>
#include<cstdio>
#include<iostream>
#include<clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "RUS");

    const int n = 10;
    int* a = new int[n] {1, 2, 3, 4, 6, 5, 7, 8, 9, 10};

    int index = 0;
    int sum = 0;
    int count = 0;
    int show_index = index;

    int alfa = 0;
    printf_s("Введи значение alfa: ");
    scanf_s("%d", &alfa);

    //Ищем индекс со значением 5
    for (int* i = a; i != a + n; i++)
    {
        printf_s("%3d", *i);

        if (*i == 5)
        {
            show_index = index;
        }

        if (*i > alfa) 
        {
            sum += *i;
            count++;
        }

        index++;
    }

    //Выводим индекс и среднее значение массива (avg)
    printf_s("\n");
    printf_s("index = %3d\n", show_index);
    printf_s("avg = %7.2f\n", (float)sum / count);

    //Для замена значений
    int buffer_a = 0;
    int buffer_b = 0;
    int countChange = 0;

    for (int* i = a; i != a + n; i++)
    {
	    if (countChange == 0)
	    {
            buffer_a = *i; // берём первый элемент из массива
	    }

        if (countChange == show_index)
        {
            buffer_b = *i; // берём условный элемент из массива
            *i = buffer_a;
        }
        countChange++;
    }
    int *i = a;
    *i = buffer_b;

    for (int* i = a; i != a + n; i++)
    {
        printf_s("%3d", *i);
    }

    printf_s("\n");

    //system("pause");

    return 0;
}