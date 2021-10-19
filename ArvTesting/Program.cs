using System;

namespace ArvTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var babyDog = new BabyDog();
            babyDog.Eat();
            babyDog.Bark();
            babyDog.Weep();
            babyDog.PrintType();
        }
    }
}
