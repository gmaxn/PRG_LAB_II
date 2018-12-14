using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometría;
using PruebaGeometría;

namespace E18
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Punto A = new Punto(-5, 4);
    //        Punto C = new Punto(-1, -2);

    //        Rectangulo R = new Rectangulo(A, C);

    //        Console.WriteLine("Area: " + R.Area);
    //        Console.WriteLine("Perimetro: " + R.Perimetro);
    //    }
    //}
}
namespace PruebaGeometría
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto A = new Punto(-5, 4);
            Punto C = new Punto(-1, -2);

            Rectangulo R = new Rectangulo(A, C);

            Console.WriteLine("Area: " + R.Area);
            Console.WriteLine("Perimetro: " + R.Perimetro);
        }
    }
}
namespace Geometría
{
    public class Punto
    {
        private int x;
        private int y;

        public int GetX
        {
            get { return this.x; }
        }
        public int GetY
        {
            get { return this.y; }
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
    public class Rectangulo
    {
        float area = 0;
        float perimetro = 0;
        Punto vertice1; //(x, y)
        Punto vertice2;
        Punto vertice3; //(x, y)
        Punto vertice4;

        public float Area
        {
            get
            {
                if (this.area == 0)
                {
                    area = Math.Abs(this.vertice1.GetX - this.vertice3.GetX)* Math.Abs(this.vertice1.GetY - this.vertice3.GetY);
                }
                return this.area;
            }
        }
        public float Perimetro
        {
            get
            {
                if (this.perimetro == 0)
                {
                    perimetro = ((Math.Abs(this.vertice1.GetX - this.vertice3.GetX) + Math.Abs(this.vertice1.GetY - this.vertice3.GetY))*2);
                }
                return this.perimetro;
            }
        }
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice3.GetX, vertice1.GetY);
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX, vertice3.GetY);
        }    
    }
}
