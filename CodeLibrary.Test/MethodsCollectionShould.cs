using System;
using Xunit;
using MyExcellentApplication;

namespace CodeLibrary.Test // Det här är en nästlad namnrymd.
{
    public class MethodsCollectionShould
    {
        [Fact]
        public void TestAdd()
        {
            // Arrange - här skrivs kod som krävs för att utföra en handling
            MethodsCollection methods = new MethodsCollection();

            // Act - tex anropar en metod
            int result = methods.Add(1, 2);

            // Assert - här ska vi evaluera resultatet av vår Act. Assert är en klass som innehåller massor med statiska metoder.
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
