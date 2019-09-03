using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator.Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator.Calculator();
        }

        [Test]
        public void Add_AddOneToOne_return2()
        {
            const int EXPECTED_RETURNVALUE = 2;
            //Using AAA pattern

            //Arrange in setup

            //Act
            double returnValue = uut.Add(1, 1);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }

        public void Substract_Sub2From5_return3()
        {
            const int EXPECTED_RETURNVALUE = 3;
            //Using AAA pattern

            //Arrange in setup

            //Act
            double returnValue = uut.Subtract(5, 2);
            //Assert
            Assert.That(returnValue, Is.EqualTo(EXPECTED_RETURNVALUE));
        }
    }
}