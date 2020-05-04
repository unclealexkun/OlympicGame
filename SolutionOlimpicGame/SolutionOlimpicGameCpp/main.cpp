#include<cstdlib>
#include<cstdio>
#include<iostream>
#include<clocale>

using namespace std;

int main()
{
    setlocale(LC_ALL, "RUS");

    const int n = 10;
    int* a = new int[n] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

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

    //Замена значений
    int* buffer_a;
    int* buffer_b;
    int* pointer = a;
    buffer_a = pointer;
    pointer += show_index;
    buffer_b = pointer;
    pointer = buffer_a;
    pointer -= show_index;
    pointer = buffer_b;

    for (int* i = a; i != a + n; i++)
    {
        printf_s("%3d", *i);

    }

    printf_s("\n");

    //system("pause");

    return 0;
}