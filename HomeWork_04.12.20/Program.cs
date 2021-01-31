using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardDat
{   
    class Program
    {
        static void Main(string[] args)
        {   // Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа 
            // должна сосчитать количество введенных пользователем пробелов.
            Console.WriteLine("Введите любой символ: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');
            Console.WriteLine("Количество пробелов: " + spaceCount);


            // Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов 
            // верхнего регистра на величину 32.Используя эту информацию, написать программу, которая считывает
            // с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
            Console.WriteLine("Преобразование строчных и заглавных букв  ");
            int spaceValue = 0;
            ConsoleKeyInfo symbol;
            do
            {
                Console.WriteLine("Введите символ для преобразования регистра");
                Console.WriteLine("Для выхода нажмите ESC");
                symbol = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Введенный символ " + symbol.KeyChar);
                if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
                {
                    if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                    {
                        Console.WriteLine("Преобразуемый символ " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                    }
                    else
                    {
                        Console.WriteLine("Преобразуемый символ " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                    }
                }
                if (Convert.ToInt32(symbol.KeyChar) == 27) // код клавиши Esc
                {
                    break;
                }
            } while (true);

            // Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, 
            // если было введено число 345, то программа должна вывести число 543.
            Console.WriteLine(" Введите число больше нуля");
            try
            {
                Console.WriteLine("Enter N");
                string N = Console.ReadLine();
                if (Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Условие не выполнено N> 0");
                    return;
                }
                Console.Clear();
                Console.WriteLine("Полученный номер");
                for (int i = N.Length - 1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Выход из программы");
                Console.BackgroundColor = ConsoleColor.Black;
                Environment.Exit(0);
            }
            Console.WriteLine();
        }
    }
}
