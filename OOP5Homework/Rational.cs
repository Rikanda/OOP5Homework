using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5Homework
{
    public class Rational
    {
        public int A { get; set; } // числитель

        public int B { get; set; } // знаменатель
        
        public Rational(int _a, int _b)
        {
            this.A = _a;
            this.B = _b;
        }
        public static bool operator ==(Rational r1, Rational r2) // равенство двух дробей
        {
            return (r1.A == r2.A && r1.B == r2.B);
        }
        public static bool operator !=(Rational r1, Rational r2) // неравенство двух дробей
        {
            return (r1.A != r2.A || r1.B != r2.B);
        }
        public static Rational operator +(Rational r1, Rational r2) // сложение двух дробей
        {
            int a = r1.A * r2.B + r2.A * r1.B;
            int b = r1.B * r2.B;
            // наибольший общий делитель для a и b
            int o = ob(a, b);
            return new Rational(a/o,b/o);
        }
        public static Rational operator -(Rational r1, Rational r2) // разность двух дробей
        {
            int a = r1.A * r2.B - r2.A * r1.B;
            int b = r1.B * r2.B;
            // наибольший общий делитель для a и b
            int o = ob(a, b);
            return new Rational(a / o, b / o);
        }
        public static Rational operator ++(Rational r) // инкремент +1
        {
            return new Rational(r.A + r.B, r.B);
        }
        public static Rational operator --(Rational r) // декремент -1
        {
            return new Rational(r.A - r.B, r.B);
        }
        public static bool operator >(Rational r1, Rational r2) // сравнение >
        {
            return (((r1.A * r2.B - r2.A * r1.B) / r1.B * r2.B) > 0);
        }
        public static bool operator <(Rational r1, Rational r2) // сравнение <
        {
            return (((r1.A * r2.B - r2.A * r1.B) / r1.B * r2.B) < 0);
        }
        public static bool operator >=(Rational r1, Rational r2) // сравнение >=
        {
            return (((r1.A * r2.B - r2.A * r1.B) / r1.B * r2.B) >= 0);
        }
        public static bool operator <=(Rational r1, Rational r2) // сравнение <=
        {
            return (((r1.A * r2.B - r2.A * r1.B) / r1.B * r2.B) <= 0);
        }

        public static implicit operator float(Rational r) // преобразование дроби во float
        {
            float x = r.A;
            float y = r.B;
            return x/y;
        }

        public static implicit operator int(Rational r) // преобразование дроби в int
        {
            int c = r.A / r.B;
            return c;
        }

        public static implicit operator Rational(int i) // преобразование int в дробь 
        {
            Rational r = new Rational(i, 1);
            return r;
        }

        public static implicit operator Rational(float f) // преобразование float в дробь
        {
            int count = 0; // счетчик
            // определяем количество знаков после запятой
            decimal z = (decimal)f;
            int y = Convert.ToInt32(z);
            var m = z - y;
            while (m != 0)
            {
                f = f * 10;
                z = (decimal)f;
                y = Convert.ToInt32(z);
                m = z - y;
                count++;
            }
            // определение числителя и знаменателя
            int a = Convert.ToInt32(z);
            int b = Convert.ToInt32(Math.Pow(10, count));
            // наибольший общий делитель для a и b
            int o = ob(a,b);
            return new Rational(a/o, b/o);
        }

        public static int ob (int a, int b) // наибольший общий делитель
        {
            int _ob = 1;
            for (int i = 2; i < Math.Max(a, b); i++)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    _ob = i;
                }
            }
            return _ob;
        }

        // переопределение методов
        public new string ToString() // расширяем функциональность метода на дроби, поэтому new а не override
        {
            return $"{this.A}/{this.B}";
        }

        public override bool Equals(object obj) // переопределение метода Equals
        {
            if (obj == null)
                return false;
            Rational r = obj as Rational;
            if (r as Rational == null) // возвращает null если объект нельзя привести к типу Rational
                return false;

            return r.A == this.A && r.B == this.B;
        }

        //операторы умножения, деления, остатка
        public static Rational operator *(Rational r1, Rational r2)
        {
            float x = r1;
            float y = r2;
            float z = x * y;
            Rational rez = z;
            return rez;
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            float x = r1;
            float y = r2;
            float z = x / y;
            Rational rez = z;
            return rez;
        }
        public static Rational operator %(Rational r1, Rational r2)
        {
            float x = r1;
            float y = r2;
            float z = x % y;
            Rational rez = z;
            return rez;
        }



    }
}
