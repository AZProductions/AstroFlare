using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AstroFlare.CodeAnalysis;
using AstroFlare.CodeAnalysis.Syntax;
using AstroFlare.CodeAnalysis.Text;

namespace AstroFlare.Compiler
{
    internal static class Program
    {
        private static void Main()
        {
            var repl = new MinskRepl();
            repl.Run();
        }
    }
}