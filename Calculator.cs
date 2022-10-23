using GenerateReceipt.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestingProj
{
    [TestClass]
    public class Calculator
    {
        private readonly Calculate _calculator;

        public Calculator()
        {
            _calculator = new Calculate();
        }

        [TestMethod]
        public void Add_Check()
        {
            //Arrange
            double expected = 10;

            //Actual
            double result = _calculator.Add(5, 5);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(5, 5)]
        public void Multiply_Check(double val1, double val2)
        {
            double expected = val1 * val2;
            //Actual
            double result = _calculator.Multiply(val1, val2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(12, 0)]
        public void Division_Check(double val1, double val2)
        {
            //double expected = val1 * val2;

            // Assert
            Assert.ThrowsException<ArgumentException>(() => _calculator.Division(val1, val2));
        }

    }
}
