using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PTB2
    {
        private double a117;
        private double b117;
        private double c117;

        protected double A117 { get => a117; set => a117 = value; }
        protected double B117 { get => b117; set => b117 = value; }
        protected double C117 { get => c117; set => c117 = value; }

        public PTB2() { }

        public PTB2(double a117, double b117, double c117)
        {
            A117 = a117;
            B117 = b117;
            C117 = c117;
        }

        public double delta()
        {
            return B117 * B117 - (4 * A117 * C117);
        }

        public void giaiPT()
        {
            double dt117 = delta();
            if (dt117 < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (dt117 == 0)
            {
                double x117 = -B117 / (2 * A117);
                Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + x117);
            } else
            {
                double x1117 = (-B117 + Math.Sqrt(dt117)) / (2 * A117);
                double x2117 = (-B117 - Math.Sqrt(dt117)) / (2 * A117);
                Console.WriteLine("Phuong trinh co 2 nghiem x1 = {0} x2 = {1}", x1117, x2117);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 3 tham so cho phuong trinh bac 2");
            Console.Write("a: ");
            double a117 = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b117 = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c117 = double.Parse(Console.ReadLine());

            PTB2 ptb2 = new PTB2(a117, b117, c117);
            ptb2.giaiPT();

            Console.ReadLine();
        }
    }
}
