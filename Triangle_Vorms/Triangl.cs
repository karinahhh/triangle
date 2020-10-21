using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Vorms
{
	class Triangl
	{
        //поля
        public double a;//первая сторона
        public double b;//вторая высота
        public double c;//третья сторона
        public double h;//высота

        //методы
        public Triangl(double A, double B, double C, double H)//конструктор
        {
            a = A;//создаем с заданными длинами сторон согласно заданию
            b = B;
            c = C;
            h = H; //заданая высота
        }

		public Triangl(double a, double b, double c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
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
            double p = a + b + c;//вычисление 
            return p;//возврат
        }

        public double Surface()//анологично периметру
        {/*
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;//полупериметр
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));//высота
            return s;
            */
            double p = Perimetr() / 2;
            double s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;

        }

        public double heightt() // нахождение площади
        {
            double p = Perimetr() / 2;
            h = 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a;//вычисление
            return h;//возврат
            
            
            
        }
        //свойства
        public double GetSetA //свойство позволяет установить/заменить значение стороны С
        {
            get { return a; }
            set { a = value; }
        }
        public double GetSetB {
            get { return b; }
            set { b = value; }
        }
        public double GetSetC {
            get { return c; }
            set { c = value; }
        }

        public double GetSetH {
            get { return h; }
            set {
                h = value;
            }
        }


        public bool ExistTriangl //свойсто устанавливает, существует треугольник с заданными сторонами или нет
        {
            get {
                if ((a + b > c) && (b + c > a) && (a + c > b))
				{
                    return false;
                }
                else
				{
                    return true;
                }
            }
            
        }
    }
}

