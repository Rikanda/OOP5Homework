using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // проверка
            Rational r1 = new Rational(3, 8);           
            Console.WriteLine("Первое число " + r1.ToString());
            float z = r1;
            Console.WriteLine("Преобразование во float "+z);
            Rational r2 = new Rational(7, 9);
            Console.WriteLine("Второе число " + r2.ToString());
            var r3 = r1 + r2;
            Console.WriteLine("Сумма первого и второго чисел " + r3.ToString());
            var r4 = r1 * r2;
            Console.WriteLine("Произведение первого и второго чисел " + r4.ToString());
            // сравнение двух чисел
            if(r1>r2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if(r1<r2)
            {
                Console.WriteLine("Первое число меньше второго");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

            if(r1==r2)
            {
                Console.WriteLine("Числа равны");
            }

            if (r1 != r2)
            {
                Console.WriteLine("Числа неравны");
            }

        }
    }
}
