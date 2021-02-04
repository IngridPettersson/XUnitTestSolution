using System;
using Xunit;

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
    }
}
