namespace GenerateReceipt.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int expected = 3;

            //Actual
            int add = (1 + 2);

            //Assert
            Assert.Equal(expected, add);
        }

        [Theory]
        [InlineData(5, 0, 0)]
        public void Test2(int x, int y, int expected)
        {
            //Actual
            int division = x / y;

            //Assert
            Assert.Equal(expected, division);
        }
    }
}