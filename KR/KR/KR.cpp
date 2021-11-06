#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string>
#include <fstream>
using namespace std;
int main(int ac, char* av[])
{
	setlocale(LC_ALL, ".1251");
	char* nameFile;
	char* c;
	int size;
	if (ac > 1) nameFile = av[1];
	else {
		printf("Не задано имя файла");
		return 1;
	}
	FILE* ptrFile = fopen(nameFile, "r");

	if (ptrFile == NULL) perror("Ошибка открытия файла");
	else
		c = fgets(nameFile, 126, ptrFile);
	size = strlen(nameFile);
	for (int i = 0; i < size; i++) {
		cout << nameFile[i] << " ";
	}

	fclose(ptrFile);

	return 0;
}