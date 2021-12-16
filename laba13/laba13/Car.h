#pragma once
#include <string>
#include <iostream>

using namespace std;

class Car
{
public:
	Car(void);
	// Деструктор
	virtual ~Car(void);
	// Констрктор спараметрами
	Car(string, int, int);
	// Конструктор копирования 
	Car(const Car&);
	//селекторы
	string Getmark() { return mark; }
	int Getcyl() { return cyl; }
	int Getpower() { return power; }
	// Модификаторы
	void Setmark(string);
	void Setcyl(int);
	void Setpower(int);
	// Перегрузка операции присваивания
	Car& operator=(const Car&);
	// Глобальные операторы-функции ввода-вывода
	friend istream& operator>>(istream& in, Car& c);
	friend ostream&
		operator<<(ostream& out, const Car& c); 
public:
	string mark;
	int cyl;
	int power;
};



