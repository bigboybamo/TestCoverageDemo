using NUnit.Framework;
using TestCoverageDemo;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange
            int number = 2;
            int expected = 22;

            // Act
            int actual = Calculator.Add(number);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        public void Test2()
        {
            // Arrange
            int number = 3;
            int expected = 33;

            // Act
            int actual = Calculator.Add(number);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}