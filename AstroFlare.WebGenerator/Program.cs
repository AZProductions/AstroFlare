using System;
using System.Threading;
using Spectre.Console;
using Console = Spectre.Console.AnsiConsole;

namespace AstroFlare.WebGenerator
{
    class Program
    {
        internal static void Main()
        {
            AnsiConsole.Write(new FigletText("AstroFlare.WebGenerator").RightAligned().Color(Color.White));
            Console.Status().Start("Initializing template response...", ctx =>
            {
                AnsiConsole.MarkupLine($"{Variable.Log}Got Working Directory: [green]{Variable.WorkingDirectory}[/]");
                Thread.Sleep(new Random().Next(1000, 4000)); //Simulate wait, for the user to accept or dissagree the path.
                

                // Error when running this code, to fix: use multiple spinners in an async operation.
                // if (!AnsiConsole.Confirm($"Is this the correct base path? : {Variable.WorkingDirectory}"))
                // {
                //     return;
                // }

                ctx.Status("Doing nothing...");
                ctx.Spinner(Spinner.Known.Default);
                ctx.SpinnerStyle(Style.Parse("green"));

                AnsiConsole.MarkupLine($"{Variable.Log}Doing some more work...");
                Thread.Sleep(2000);
            });
        }
    }
}
