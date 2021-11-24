using Spectre.Console;
namespace AstroFlare.Exeptions.Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.Write(new FigletText("AstroFlare.Exeptions.Generator V1").LeftAligned().Color(Color.Red));
            AnsiConsole.Status()
            .Start("Thinking...", ctx =>
            {
                AnsiConsole.MarkupLine("Generating Error code...");
                Thread.Sleep(new Random().Next(0, 2000));
                AnsiConsole.MarkupLine("[blue]ASTROF" + new Random().Next(0, 10) + new Random().Next(0, 10) + new Random().Next(0, 10) + new Random().Next(0, 10) + new Random().Next(0, 10)+"[/]");
                Thread.Sleep(1000);
                ctx.Status("Requesting input..");
                ctx.SpinnerStyle(Style.Parse("green"));
                Thread.Sleep(new Random().Next(0, 2000));
            });
            string description = AnsiConsole.Ask<string>("Description of the [green]Error Code[/]:");
            if (!AnsiConsole.Confirm("Do you want to add this to '[blue]./AstroFlare.Exeptions/ErrorCodes/ErrorCodeKind.cs[/]'?"))
            {
                return;
            }
        }
    }
}