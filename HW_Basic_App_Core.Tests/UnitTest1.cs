using HW_Basic_App_Github;

namespace HW_Basic_App_Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            // Arrange
            Class1 tp = new Class1();
            // Act
            var result = tp.Name;
            // Assert
            Assert.Equal("[Haylie Williamson] - The Code Master", result);
        }
    }
}