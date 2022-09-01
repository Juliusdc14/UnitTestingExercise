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
            

            //Arrange
            // create a Calculator object
            var test = new UnitTestMethods();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            

            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]//Add test data <-------
        [InlineData(5, 4, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            

            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 4)]//Add test data <-------
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }

    internal class UnitTestMethods
    {
        public UnitTestMethods()
        {
        }

        internal object Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        internal object Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        internal object Multiply(int num1, int num2)
        {
            
            return num1 * num2;
        }

        internal object Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }
    }
}
