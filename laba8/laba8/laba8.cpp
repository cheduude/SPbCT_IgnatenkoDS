//Игнатенко Д.С.
#include <iostream>
#define USE_MATH_DEFINES
#include <locale.h>
#include <math.h>
#define SIZE 26
using namespace std;
void main()
{
    setlocale(LC_ALL, "rus");
    time_t ltime;
    wchar_t buf[SIZE];
    errno_t err;
    time(&ltime);
    err = _wctime_s(buf, SIZE, &ltime);
    cout << "ФИО:\nСпирков Дмитрий Егорович, Тулинцева Елизавета Денисовна\n\nТекущие дата и время: \n";
    wprintf_s(buf);

    double x = 1.4, a = 0.5, b = 3.1, z, w;
    cout << "Введите переменную x: ";
    cin >> x;
    cout << endl;
    cout << "Переменная a: " << a;
    cout << "\nПеременная b: " << b<<endl;
    z = sqrt(a * x * sin(2 * x) + exp(-2 * x) * (x + b));
    w = exp(3 * abs(sin(b * x))) - pow(x, 3) / a;
    cout << "\nРезультат вычислений"<<endl;
    cout << "\nz= " << z;
    cout << "\nw= " << w<< endl;
}

