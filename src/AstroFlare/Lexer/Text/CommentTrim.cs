using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroFlare.Lexer.Text
{
    public static class CommentTrim
    {
        // CommentTrim Class. #10
        // 1. Clear SectionToSection
        // 2. Clear LineToEnd
        // 3. Return
        public static string TrimComment(string inputString) 
        {
            string outputString = inputString;

            // Clear LineToEnd.
            if (inputString.Contains("//")) 
                outputString = TrimToken(outputString, CommentToken.LineToEnd);

            if(inputString.Contains("/*") && inputString.Contains("*/"))
                outputString = TrimToken(outputString, CommentToken.SectionToSection);

            return outputString;
        }

        private static string TrimToken(string inputString, CommentToken token) 
        {
            string outputString = inputString;
            if (token == CommentToken.LineToEnd)
            {
                int index = outputString.LastIndexOf("/");
                if (index >= 0)
                    outputString = outputString.Substring(0, index-1);
            }

            if (token == CommentToken.SectionToSection) 
            {
                int index = outputString.LastIndexOf("/*");
                int index2 = outputString.LastIndexOf("*/");
                if (index >= 0)
                {
                    outputString = outputString.Remove(index, index2 + 2 - index);
                }
            }
            return outputString;
        }
    }
}
