#include <iostream>
#include "Car.h"
#include "Lorry.h"
#include <time.h>
#define SIZE 26
using namespace std;

void f1(Car& c)
{
	c.Setmark("Opel"); cout << c;
}

Car f2()
{
	Lorry l("TOYOTA", 1, 2, 3);
	return l;
}

int main()
{
	setlocale(LC_ALL, "rus");
	time_t ltime;
	wchar_t buf[SIZE];
	errno_t err;
	time(&ltime);
	err = _wctime_s(buf, SIZE, &ltime);
	cout << "ФИО:\nСпирков Дмитрий Егорович, Тулинцева Елизавета Денисовна\n\nТекущие дата и время: \n";
	wprintf_s(buf);
	Car a;
	cin >> a;
	cout << a;
	Car b("Cadilac", 4, 115);
	cout << b;
	a = b;
	cout << a;
	a = f2();
	cout << a;
	Lorry c; 
	cin >> c;
	cout << c; 
	system("pause");
}



