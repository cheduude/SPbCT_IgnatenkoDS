#include "pch.h"
#include <iostream>
using namespace std;
using namespace System;
using namespace System::IO;
#define SIZE 26
namespace lab17
{
	public ref class Program
	{
	public:
		static void Main()
		{
			for each (String ^ entry in Directory::GetDirectories("C:\\"))
			{
				DisplayFileSystemInfoAttributes(gcnew DirectoryInfo(entry));
			}
			for each (String ^ entry in Directory::GetFiles("C:\\"))
			{
				DisplayFileSystemInfoAttributes(gcnew FileInfo(entry));
			}
		}
		static void DisplayFileSystemInfoAttributes(FileSystemInfo^ fsi)
		{
			String^ entryType = "File";
			if ((fsi->Attributes & FileAttributes::Directory) == FileAttributes::Directory)
			{
				entryType = "Directory";
			}
			Console::WriteLine("{0} entry {1} was created on {2:D}", entryType, fsi->FullName, fsi->CreationTime);
		}
	};
};
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
	lab17::Program::Main();
}

