using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoFixtureTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;

namespace AutoFixtureTest.Tests
{
    [TestClass()]
    public class HumanFactoryTest
    {
        Fixture fixture;
        HumanFactory mockHumanFactory;

        [TestInitialize]
        public void Init()
        {
           fixture = new Fixture();

            //If I give IHuman interface give the Man Class
           fixture.Register<IHuman>(() => new Man());
            //create HumanFactory mock class
           mockHumanFactory = fixture.Build<HumanFactory>().Create();
        }
     
        //Create a mock human with given parameters
        public IHuman GetMockHuman(string name, int age)
        {
            return fixture.Build<Man>().With(p => p.Name, name)
                                                   .With(p => p.Age, age)
                                                   .Create();
        }

        [TestMethod()]
        public void Create_Human_Test()
        {
            var mockHuman = GetMockHuman("Jack",32);

            mockHumanFactory.CreateHuman(mockHuman);
            var actualHuman = mockHumanFactory.GetInstance();

            Assert.AreEqual(actualHuman.Name,"Jack");

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Create_Human_With_Minus_Age()
        {
            var mockHuman = GetMockHuman("", -4);

            mockHumanFactory.CreateHuman(mockHuman);
            var actualHuman = mockHumanFactory.GetInstance();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_Human_With_Empty_Name()
        {
            var mockHuman = GetMockHuman("",32);

            mockHumanFactory.CreateHuman(mockHuman);
            var actualHuman = mockHumanFactory.GetInstance();
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Get_Null_Human()
        {
            IHuman mockHuman = null;

            mockHumanFactory.CreateHuman(mockHuman);
            var actualHuman = mockHumanFactory.GetInstance();
        }

    }
}