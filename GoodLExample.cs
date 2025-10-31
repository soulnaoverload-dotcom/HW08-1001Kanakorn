using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.L
{
    internal class GoodLExample
    {
        public class Animal {
            public virtual void Eat() {
                Console.WriteLine("Animal is eating");
            }
        }
        public class Bird : Animal {
            public virtual void LayEggs() {
                Console.WriteLine("Lay egg");
            }
        }
        public interface IFlayble {
            void Fly();
        }
        public class Hummingbird : Bird, IFlayble 
        {
            public void Fly() 
            {
                Console.WriteLine("Fly");
            }
        
        }
        public class Chicken : Bird {
            public override void Eat()
            {
                Console.WriteLine("Chicken is eating seed");
            }
        }
    }
}
