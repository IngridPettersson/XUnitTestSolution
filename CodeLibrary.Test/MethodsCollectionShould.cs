using System;
using Xunit;
using MyExcellentApplication;

namespace CodeLibrary.Test // Det h�r �r en n�stlad namnrymd.
{
    public class MethodsCollectionShould
    {
        [Fact]
        public void TestAdd()
        {
            // Arrange - h�r skrivs kod som kr�vs f�r att utf�ra en handling
            MethodsCollection methods = new MethodsCollection();

            // Act - tex anropar en metod
            int result = methods.Add(1, 2);

            // Assert - h�r ska vi evaluera resultatet av v�r Act. Assert �r en klass som inneh�ller massor med statiska metoder.
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 6, 11)]
        public void TestAdd2(int a, int b, int expected)
        {
            // Arrange
            MethodsCollection methods = new MethodsCollection();

            // Act
            int result = methods.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestLifeIsGood()
        {
            AnyOldClass any = new AnyOldClass();
            bool x = any.LifeIsGood();
            Assert.True(x);
        }
    }

}
