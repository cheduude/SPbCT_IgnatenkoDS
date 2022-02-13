using System;
using calc = ClassLib_Calc_50311.Calculator;

namespace Program_50311
{
    class Program
    {
        static void Main()
        {
            int num = 50311;
            // исходные данные для вычислений
            string[] op_sign_simple = { "^", "*", "|", "&", "-", "/", "<<", "~", ">>", "!" };
            string[] op_sign_overload = { "^=", "*=", "|=", "&=", "-=", "/=", "<<=", "~=", ">>=", "!=" };
            string[] op_description = {"передаваемых значений - не более 100",
                                        "передаваемых значений - не менее 50",
                                        "первого параметра значением - не более 90",
                                        "первого параметра значением - не менее 40",
                                        "второго параметра значением - не более 80",
                                        "второго параметра значением - не менее 30",
                                        "результата вычисления - не более 300",
                                        "результата вычисления - не менее -4000",
                                        "результата вычисления - не более 150 по модулю",
                                        "результата вычисления - не менее 50 по модулю"};
            // операции, которые нужно реализовать для своего варианта
            for (int i = 0; i < 4; i += 2)
            {
                int n_simple = (((num / 100) + num % 100) % 9 + i);
                int n_overload = (n_simple + 7) % 9;
                Console.WriteLine("Операция " + i + ": {0} (разрешить числа {1})",
                    op_sign_simple[n_simple], op_description[n_overload]);
                Console.WriteLine("Операция " + i + 1 + ": {0} (разрешить числа {1})",
                    op_sign_overload[n_overload], op_description[n_simple]);
            }
            string str_out = "";
            Console.WriteLine("\n###Работа функции Sum() для значений в интервале [-127; 128]");
            Console.WriteLine("\n###Выполнение функции суммирования без ошибок: Sum(100, 25);");
            str_out = ClassLib_Calc_50311.Calculator.Sum(100, 25); // calc.Sum(100,25);
            Console.WriteLine(str_out);

            Console.WriteLine("\n###Выполнение функции суммирования с ошибкой #101: Sum(100, 120);");
            str_out = ClassLib_Calc_50311.Calculator.Sum(100, 120); // calc.Sum(100,120);
            Console.WriteLine(str_out);

            Console.WriteLine("\n###Выполнение функции суммирования с ошибкой #102: Sum(-100, -120);");
            str_out = ClassLib_Calc_50311.Calculator.Sum(-100, -120); // calc.Sum(-100,-120);
            Console.WriteLine(str_out);

        }
    }
}