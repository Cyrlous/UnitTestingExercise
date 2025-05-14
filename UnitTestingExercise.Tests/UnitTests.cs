using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculator = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = calculator.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6,7,-1)] //Add test data <-------
        [InlineData(7,1,6)]
        [InlineData(5,2,3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            

            //Arrange
            var calculator = new Calculator();
            
            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4,5, 20)]//Add test data <-------
        [InlineData(5,5,25)]
        [InlineData(-5,2,-10)]
        [InlineData(-6,-6,36)]
        [InlineData(0,-7,0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8,4,2)]//Add test data <-------
        [InlineData(-50,5,-10)]
        [InlineData(-5,-2,2.5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
