using GenerateReceipt.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateReceipt.Tests
{
    public class Calculator
    {
        

        [Theory]
        [InlineData(3.3,4.5,7.8)]
        public void Add_Test(double x, double y, double expected)
        {
            var _calculate = new Calculate();

            //Actual
            double actual = _calculate.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 0)]
        public void Division_Test(double x, double y)
        {
            var _calculate = new Calculate();

            //Actual

            //double actual = _calculate.Division(x, y);

            //Assert

            //Assert.Equal(expected, actual);
            //Assert.Throws<ArgumentException>(() => actual);
            
            //Whenever you use throws exception in test, don't use the actual cause
            // of data type conversion conflict, just pass on the expression or
            // method call after the lamba like below
            Assert.Throws<ArgumentException>(() => _calculate.Division(x, y));

        }
    }
}
