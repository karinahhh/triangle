using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        //поля
        public double a;//первая сторона
        public double b;//вторая высота
        public double c;//третья сторона
        public double h;//высота

        //методы
        public Triangle(double A, double B, double C, double H)//конструктор
        {
            a = A;//создаем с заданными длинами сторон согласно заданию
            b = B;
            c = C;
            h = H; //заданая высота
        }

        public string outputA()//выводим сторону а, метод возвращает строковое значение
        {
            return Convert.ToString(a);//ссылка на внутреннее поле объекта класса
        }

        public string outputB()
        {
            return Convert.ToString(b);//выводим сторону b
        }
        public string outputC()
        {
            return Convert.ToString(c);// выводим сторону c
        }

        public string outputH()
        {
            return Convert.ToString(h);//выводим высоту
        }

        public double Perimetr()//сумма всех сторон типа double 
        {
            double p = 0;
            p = a + b + c;//вычисление 
            return p;//возврат
        }

        public double Surface()//анологично периметру
        {
            double h = 0;
            double p = 0;
            p = (a + b + c) / 2;//полупериметр
            h = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));//высота
            return h;
        }

        public double Area() // нахождение площади
        {
            double S = 0;
            S = 1 / 2 * b * h;//вычисление
            return S;//возврат
        }
        //свойства
        public double GetSetA //свойство позволяет установить/заменить значение стороны С
        {
            get 
            { return a; }
            set 
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }

        public double GetSetH
        {
            get
            { return h; }
            set
            {
                h = value; }
        }
        public bool ExistTriangle //свойсто устанавливает, существует треугольник с заданными сторонами или нет
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b)) //сумма 2 сторон должна быть больше третьей стороны
                    return false;
                else return true;
            }
        }
    }
}

