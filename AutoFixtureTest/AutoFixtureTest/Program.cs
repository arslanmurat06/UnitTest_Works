using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFixtureTest
{

    class Program
    {
        static void Main(string[] args)
        {

            HumanFactory factory = new HumanFactory();

            factory.CreateHuman(new Man()
            {
                Age = 32,
                Name = "Jack"
            });


            var erkek = factory.GetInstance();

            factory.CreateHuman(new Woman()
            {
                Age = 30,
                Name = "Helen"
            });

            var bayan = factory.GetInstance();

            erkek.Speak();

            bayan.Speak();

            Console.ReadLine();
        }
    }
}
