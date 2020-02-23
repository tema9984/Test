using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSqr
{
    class trig
    {
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }
        public trig(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Стороны должны быть больше 0");
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double SurTr()// Подсчет площади для произвольного треугольника
        {

            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return S;
        }
        public double SurTr(double a, double b)// Подсчет площади для прямоугольного треугольника 
        {

            return a * b / 2;
        }
        public string Proverka()//Проверка на прямой угол
        {
            switch (Pr())
            {
                case 0:
                    return "Треугольник не прямоугольный. S=" + SurTr();
                case 1:
                    return "Катеты A и B. S=" + SurTr(a, b);
                case 2:
                    return "Катеты B и C. S=" + SurTr(b, c);
                case 3:
                    return "Катеты C и A. S=" + SurTr(c, a);
            }
            throw new Exception("Error");


        }
        int Pr()
        {
            if (a * a + b * b == c * c)
                return 1;
            else if (b * b + c * c == a * a) return 2;
            else if (c * c + a * a == b * b) return 3;
            else return 0;
        }

    }

    
    
}
