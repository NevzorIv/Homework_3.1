using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            const int CONST_INT = 10;
            Console.WriteLine("Задание 1.1:");
            MainStage_1(CONST_INT);
            Console.WriteLine("\n\n");
            Console.WriteLine("Задание 1.2:");
            MainStage_2(CONST_INT);
            Console.WriteLine("\n\n");
            Console.WriteLine("Задание 1.3:");
            int porog = 0;
            MainStage_3(porog);
            Console.WriteLine("\n\n");
            Console.WriteLine("Задание 1.4:");
            Random rnd = new Random();
            int porog_ot = 0;
            int porog_to = 0;
            int kol = 0;
            MainStage_4(rnd, porog_ot, porog_to, kol);
            Console.ReadKey();
        }
        static void MainStage_1(int constInt) // Задание 1.1
        {
            Console.Write("Вывод целых цифр от 0 до 9: ");
            for (int i = 0; i < constInt; i++)
            {
                Console.Write(i);
                Thread.Sleep(100);
                Console.Write(" ");
            }
        }
        static void MainStage_2(int constInt) // Задание 1.2
        {
            Console.Write("Вывод целых цифр от 10 до 1: ");
            for (int i = 10; i <= constInt && i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(100);
                Console.Write(" ");
            }
        }
        static void MainStage_3(int porog) // Задание 1.3
        {
            Console.WriteLine("Вывод целых положительных чисел кратных 3-м и 5-и до" +
                " числа, которое укажет пользователь:");
            int i = 0;
            while (true)
            {
                Console.Write("Укажите положительное целое число больше нуля: ");
                porog = Convert.ToInt32(Console.ReadLine());
                Console.Write("");
                if (porog > 0 && porog > i)
                {
                    Console.Write("Вывод чисел кратных 3-м и 5-и: ");
                    for (i = 0; i < porog; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            Console.Write(i);
                            Thread.Sleep(100);
                            Console.Write(" ");
                        }
                        continue;
                    }
                    return;
                }
                Console.WriteLine("Указано неверное число");
            }
        }
        static void MainStage_4(Random rnd, int porog_ot, int porog_to, int kol) // Задание 1.4
        {
            Console.WriteLine("Вывод случайных целых чисел по диапазону пользователя:");
            while (true)
            {
                Console.WriteLine("Укажите пороговые значения:");
                Console.Write("от: ");
                porog_ot = Convert.ToInt32(Console.ReadLine());
                Console.Write("до: ");
                porog_to = Convert.ToInt32(Console.ReadLine());
                if (porog_ot < porog_to)
                {
                    while (true)
                    {
                        Console.Write("Укажите количество чисел, которые следует вывести: ");
                        kol = Convert.ToInt32(Console.ReadLine());
                        if (kol > 0)
                        {
                            Console.Write("Вывод случайных целых чисел: ");
                            for (int i = 0; i < kol; i++)
                            {
                                int myInt = rnd.Next(porog_ot, porog_to);
                                Console.Write(myInt);
                                Console.Write(" ");
                                Thread.Sleep(100);
                            }
                            return;
                        }
                        Console.WriteLine("Количество чисел для вывода указано не верно");
                    }
                }
                if (porog_ot > porog_to)
                {
                    while (true)
                    {
                        Console.Write("Укажите количество чисел, которые следует вывести: ");
                        kol = Convert.ToInt32(Console.ReadLine());
                        if (kol > 0)
                        {
                            Console.Write("Вывод случайных целых чисел: ");
                            for (int i = 0; i < kol; i++)
                            {
                                int myInt = rnd.Next(porog_to, porog_ot);
                                Console.Write(myInt);
                                Console.Write(" ");
                                Thread.Sleep(100);
                            }
                            return;
                        }
                        Console.WriteLine("Количество чисел для вывода указано не верно");
                    }
                }
                Console.WriteLine("Диапазон указан не верно");
            }
        }
    }
}
