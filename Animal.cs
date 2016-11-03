using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{     
    public enum GenderType
    {
        Male,
        Female
    }

    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Contructing animal");
        }
        //public Animal(GenderType gender)

        //{
        //    if (gender == GenderType.Female)
        //    {
        //        Console.WriteLine("Female");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Male");
        //    }
        //}
    }

}
