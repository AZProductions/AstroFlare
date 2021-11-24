using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroFlare.Exeptions;
using Spectre.Console;
using Errata;

namespace Flare.Output
{
    internal class DialogWindow
    {
        public DialogWindow(ErrorCodeKind kind, string message, ErrorSeverityLevel level)
        {
            Kind = kind;
            Message = message;
            Level = level;
        }

        public void Show() 
        {
            var root = new Tree("Error");
        }

        public ErrorCodeKind Kind { get; }
        public string Message { get; }
        public ErrorSeverityLevel Level { get; }
    }
}
