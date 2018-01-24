using System;
using Xunit;

namespace VegMart.Tests
{
    public class RegistrationTests
    {
        [Fact]
        public void PassingTest()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
