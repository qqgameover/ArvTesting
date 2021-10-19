using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTesting
{
    class BabyDog : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Im weeping");
        }

        public override void Bark()
        {
            Console.WriteLine("waf waf");
        }
    }
}
