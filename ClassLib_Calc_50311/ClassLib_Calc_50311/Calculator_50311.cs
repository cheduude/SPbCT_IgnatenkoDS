using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Calc_50311
{
    public class Calculator
    {
        public static string Sum(short first_num, short second_num)
        {
            string str_ret = "Результат вычисления суммы: ";

            if (first_num + second_num > SByte.MaxValue)
                str_ret += "\nОшибка #101: Результат более " + SByte.MaxValue.ToString() +
                    " не вмещается в тип sbyte";
            else if (first_num + second_num < SByte.MinValue)
                str_ret += "\nОшибка #102: Результат менее " + SByte.MinValue.ToString() +
                    " не вмещается в тип sbyte";
            else
                str_ret += (first_num + second_num).ToString();

            return str_ret;
        }

        public static string zvd(sbyte first_num, sbyte second_num)
        {
            string str_ret = "Результат вычисления умножения: ";
                str_ret = (first_num * second_num).ToString();
            return str_ret;
        }

        public static string div(sbyte first_num, sbyte second_num)
        {
            string str_ret = (first_num >>= second_num).ToString();
            return str_ret;
        }
        public static string and(sbyte first_num, sbyte second_num)
        {
            string str_ret = (first_num&second_num).ToString();
            return str_ret;
        }
        public static string zum(sbyte first_num, sbyte second_num)
        {
            string str_ret = (first_num *= second_num).ToString();
            return str_ret;
        }
    }
}

