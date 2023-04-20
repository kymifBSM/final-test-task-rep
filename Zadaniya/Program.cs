using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadaniya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////task1/////////////////////////////////////////////

            /*int[,] A = new int[10, 10];

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    A[i, j] = rnd.Next(-10, 10);
                }
            }

            int sumPos = 0;
            int multNeg = 1;
            int nulCount = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (A[i, j] > 0)
                    {
                        sumPos += A[i, j];
                    }
                    else if (A[i, j] < 0)
                    {
                        multNeg *= A[i, j];
                    }
                    else
                    {
                        nulCount++;
                    }
                }
            }

            Console.WriteLine("Сумма положительных: " + sumPos);
            Console.WriteLine("Произведение отрицательных: " + multNeg);
            Console.WriteLine("Количество нулей: " + nulCount);


            
            //////////////////////////////////////task2/////////////////////////////////////////////
            int x = 1312414214;
            int count = CountNums(x);

            Console.WriteLine("Количество цифр в числе: " + count);

            
            ////////////////////////////////////task3/////////////////////////////////////////////
            int[] arr = new int[10];

            Console.WriteLine("Введите начало массива: ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец массива: ");
            int b = Int32.Parse(Console.ReadLine());

            ZapolnenieArray(arr, a, b);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            ///////////////////////////////task4/////////////////////////////////////////////////

            /*Console.WriteLine("Введите первое число: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if(num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("Да, одно из этих чисел является делителем другого");
            }
            else
            {
                Console.WriteLine("Нет, ни одно из чисел не является делителем другого");
            }*/
            //////////////////////////task5/////////////////////////////////////////////////

            Console.WriteLine("Введите угол поворта часовой стрелки (0<=y<=360 )");

            double y = double.Parse(Console.ReadLine());

            int hours = (int)y / 30;
            int minutes = (int)(y % 30 * 2);

            Console.WriteLine("Полных часов: " + hours);
            Console.WriteLine("Полных минут: " + minutes);

            Console.ReadKey();
        }
        
        /*public static int CountNums(int x) //////ФУНКЦИЯ ДЛЯ ЗАДАНИЯ 2//////////
        {
            int count = 0;
            
            if (x == 0)
            {
                return 1;
            }
            if (x < 0)
            {
                x = -x;
            }
            while (x > 0)
            {
                count++;
                x /= 10;
            }

            return count;
        }*/

        /*public static void ZapolnenieArray(int[] arr, int a, int b) ////////////ФУНКЦИЯ ДЛЯ ЗАДАНИЯ 3///////////////
        {

            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(a, b+1);
            }
        }*/

    }
}
