using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    abstract class Animal
    {
        virtual public void eat()
        {

        }
        virtual public void makeSound()
        {

        }
    }
    class Cat : Animal
    {
        public override void eat()
        {
            base.eat();
        }
        public override void makeSound()
        {
            base.makeSound();
        }
        public void run()
        {
            Console.WriteLine("Cat: run");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("Bird: fly");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat117 = new Cat();
            cat117.run();
            Bird bird117 = new Bird();
            bird117.fly();

            Console.ReadLine();
        }
    }
}
