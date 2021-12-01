using Xunit;

namespace AstroFlare.Tests
{
    public class LexerTests
    {
        [Fact]
        public void CheckCommentMistakes()
        {
            Assert.Equal("Example Text !", AstroFlare.Lexer.Text.CommentTrim.TrimComment("Example /*IgnoreTheseCharacters/And?These!*/Text !//Ignore this too!"));
            Assert.Equal("include internal System.(*); func Main(string args){ Out.PrintL(\"HelloWorld\"); }; ", AstroFlare.Lexer.Text.CommentTrim.TrimComment("include internal System.(*); func Main(string args){ Out.PrintL(\"HelloWorld/*This is example text*/\"); }; //This is the most bare-bone helloworld program written in AstroFlare."));
        }
    }
}