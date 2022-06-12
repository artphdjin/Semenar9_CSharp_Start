using System;

namespace Semenar9_CSharp_Start
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Задача 64: Задайте значения M и N.Напишите программу, которая выведет все
            натуральные числа в промежутке от M до N.
            *
            M = 6; N = 2. -> "6, 5, 4, 3, 2"
            M = 1; N = 5. -> "1, 2, 3, 4, 5"
            M = 4; N = 8. -> "4, 6, 7, 8"
            *
            Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму
            натуральных элементов в промежутке от M до N.
            M = 1; N = 15-> 120
            M = 4; N = 8. -> 30
            *
            Задача 68: Напишите программу вычисления функции Аккермана с помощью
            рекурсии.Даны два неотрицательных числа m и n.
            m = 2, n = 3->A(m, n) = 29
            */
            
            
            // Задача 64: 

            Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все " +
            "натуральные числа в промежутке от M до N.");

            Console.WriteLine("Введите натуральное число M:");

            bool numberCheck = int.TryParse(Console.ReadLine(), out int task64_start);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task64_start);
            }

            // считано число M

            Console.WriteLine("Введите натуральное число N:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task64_end);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task64_end);
            }

            // считано число N


            if (task64_end < task64_start)
                for (int i = task64_start; i >= task64_end; i--)
                {
                    {
                        if (i < task64_start) Console.Write(", ");
                        Console.Write(i);
                    }
                }
            else
                for (int i = task64_start; i <= task64_end; i++)
                {
                    {
                        if (i > task64_start) Console.Write(", ");
                        Console.Write(i);
                    }
                }

            Console.WriteLine("\n");

            
            // Задача 66: 

            Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму " +
            "натуральных элементов в промежутке от M до N.");

            Console.WriteLine("Введите натуральное число M:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task66_start);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task66_start);
            }

            // считано число M

            Console.WriteLine("Введите натуральное число N:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task66_end);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task66_end);
            }

            // считано число N

            int task66_sum = 0;


            if (task66_end < task66_start)
                for (int i = task66_start; i >= task66_end; i--)
                    task66_sum += i;
            else
                for (int i = task66_start; i <= task66_end; i++)
                    task66_sum += i;

            Console.WriteLine(task66_sum);

            Console.WriteLine("\n");
            

            // Задача 64: 

            Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью " +
            "рекурсии. Даны два неотрицательных числа m и n.");

            Console.WriteLine("Введите число m:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task68_m);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task68_m);
            }

            // считано число M

            Console.WriteLine("Введите число n:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task68_n);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task68_n);
            }

            // считано число N

            Console.WriteLine(A(task68_m, task68_n));

            static int A(int m, int n)
            {
                if (m == 0) return n + 1;
                if (m != 0 && n == 0) return A(m - 1, 1);
                if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
                return A(m, n);
            }

            Console.WriteLine("\n");

            // Функция Аккермана

        }
    }
}
