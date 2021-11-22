using Xunit;

namespace AstroFlare.Tests
{
    public class ImportTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(Imports.ImportParser.ImportParse("include internal System.(*); //hello") as string, "include internal System.(*); ");
        }

        [Fact]
        public void EmitErrorExeptions() 
        {
            Assert.Equal(Imports.ImportParser.ImportParse("include null//hello") as string, "include null");
        }
    }
}