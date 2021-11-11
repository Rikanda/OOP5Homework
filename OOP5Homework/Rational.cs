using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5Homework
{
    class Rational
    {
        public int A { get; set; } // числитель

        public int B // знаменатель
        {
            get
            {
                return this.B; 
            }
            set
            {if (value > 0)
                { 
                    this.B = value; 
                }
            else
                {
                    Console.WriteLine("Такое значение знаменателя указать нельзя! Знаменателем могут быть только положительные целые числа.");
                }

            }
        }

        public string C { get; } // результат

        public Rational (int _a, int _b)
        {
            this.A = _a;
            this.B = _b;
            this.C = "A" + "/" + "B";
        }
    }
}
