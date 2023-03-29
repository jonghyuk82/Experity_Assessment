using Experity_Assessment.Services;

namespace Experity_Assessment.Tests
{
    public class PrintServiceTests
    {
        [Fact]
        public void GetRegisterResult_Returns_Correct_List()
        {
            // Arrange
            var printService = new PrintService();
            int start = 1;
            int end = 16;
            string type = "Register";

            // Act
            List<string> result = printService.GetRegisterResult(start, end, type);

            // Assert
            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
            Assert.Equal("Register", result[2]);
            Assert.Equal("4", result[3]);
            Assert.Equal("Patient", result[4]);
            Assert.Equal("Register", result[5]);
            Assert.Equal("7", result[6]);
            Assert.Equal("8", result[7]);
            Assert.Equal("Register", result[8]);
            Assert.Equal("Patient", result[9]);
            Assert.Equal("11", result[10]);
            Assert.Equal("Register", result[11]);
            Assert.Equal("13", result[12]);
            Assert.Equal("14", result[13]);
            Assert.Equal("Register Patient", result[14]);
        }

        [Fact]
        public void GetDiagnoseResult_Returns_Correct_List()
        {
            // Arrange
            var printService = new PrintService();
            int start = 1;
            int end = 16;
            string type = "Diagnose";

            // Act
            List<string> result = printService.GetDiagnoseResult(start, end, type);

            // Assert
            Assert.Equal("1", result[0]);
            Assert.Equal("Diagnose", result[1]);
            Assert.Equal("3", result[2]);
            Assert.Equal("Diagnose", result[3]);
            Assert.Equal("5", result[4]);
            Assert.Equal("Diagnose", result[5]);
            Assert.Equal("Patient", result[6]);
            Assert.Equal("Diagnose", result[7]);
            Assert.Equal("9", result[8]);
            Assert.Equal("Diagnose", result[9]);
            Assert.Equal("11", result[10]);
            Assert.Equal("Diagnose", result[11]);
            Assert.Equal("13", result[12]);
            Assert.Equal("Diagnose Patient", result[13]);
            Assert.Equal("15", result[14]);

        }
    }
}
