using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFixtureTest
{
    public class HumanFactory
    {
        public IHuman _human;

        public void CreateHuman(IHuman human)
        {
            if (human == null)
            {
                throw new NullReferenceException("Human cannot be null");
            }
            if (human.Age < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be less than 0");
            }

            if (String.IsNullOrEmpty(human.Name))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            _human = human;
        }

        public IHuman GetInstance()
        {
            return _human;
        }
    }
}
