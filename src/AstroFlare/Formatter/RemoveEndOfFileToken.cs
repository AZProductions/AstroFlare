using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroFlare.Formatter
{
    internal class RemoveEndOfFileToken
    {
        public RemoveEndOfFileToken(string input, ref string output)
        {
            Input = input;
            Output = output;
            output = input.TrimEnd(';');
        }

        public string Input { get; }
        public string Output { get; }
    }
}
