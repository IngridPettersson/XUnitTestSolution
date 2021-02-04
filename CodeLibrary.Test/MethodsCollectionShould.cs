using System;
using Xunit;

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
    }
}
