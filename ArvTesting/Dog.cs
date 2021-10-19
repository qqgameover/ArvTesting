using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTesting
{
    class Dog : Animal
    {
        public new string Type = "Dog";
        public virtual void Bark()
        {
            Console.WriteLine("Woof woof");
        }

        public void PrintType()
        {
            Console.WriteLine(base.Type + " " + Type);
        }
    }
}
