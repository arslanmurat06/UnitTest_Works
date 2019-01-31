using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFixtureTest
{

    public interface IHuman
    {
        string Name { get; set; }
        int Age { get; set; }
        void Speak();
        void Eat();
        string GiveMeSound();
    }
}
