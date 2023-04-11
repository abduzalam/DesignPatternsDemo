using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DryDemoLibraryTestxUnit
{
    public class DryDemoLibraryTestxUnit
    {
        [Theory]
        [InlineData("Timoty", "Corey", "TimoCore")]
        public void GenerateEmployeeId_ShouldCalculate(string firstName, string lastName, string expectedStart)
        {
            // Arrange
            EmployeeProcessor processor = new EmployeeProcessor();

            // Act
            string actualStart = processor.GenerateEmployeeID(firstName, lastName);

            // Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}
