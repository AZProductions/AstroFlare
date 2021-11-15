using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AstroFlare.Compiler.CodeAnalysis;
using AstroFlare.Compiler.CodeAnalysis.Syntax;
using AstroFlare.Compiler.CodeAnalysis.Text;

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