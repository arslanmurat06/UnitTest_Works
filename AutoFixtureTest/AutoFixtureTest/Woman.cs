using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFixtureTest
{
    public class Woman : IHuman
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Speak()
        {
            Console.WriteLine("Hello I'm a woman");
        }

        public string GiveMeSound()
        {
            return "iiiiiii";
        }

        public void Eat()
        {
            Console.WriteLine("Nim Nim Nim");
        }
    }
}
