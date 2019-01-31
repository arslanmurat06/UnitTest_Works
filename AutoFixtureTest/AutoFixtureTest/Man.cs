using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFixtureTest
{
    public class Man : IHuman
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            Console.WriteLine("Hello I m Man");
        }

        public string GiveMeSound()
        {
            return "aaaaaa";
        }

        public void Eat()
        {
            Console.WriteLine("Nam Nam Nam");
        }
    }
}
