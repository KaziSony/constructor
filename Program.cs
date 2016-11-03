using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant(GenderType.Female);
            Console.ReadKey();
        }
    }
}
