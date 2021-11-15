using Cocona;
using Spectre.Console;
using Console = Spectre.Console.AnsiConsole;
class Program
{
    static string[] IgniteAlias = { "a" };
    static string ProjectPath = string.Empty;

    static void Main(string[] args)
    {
        CoconaApp.Run<Program>(args, options =>
        {
            options.EnableConvertCommandNameToLowerCase = true;
            options.EnableShellCompletionSupport = true;
        });
    }

    [Command("ignite")]
    public void Ignite() => Run();

    [Command("run", Description = "Runs the AstroFlare project directly from the command line.")]
    public void Run() 
    {
        ProjectPath = Directory.GetCurrentDirectory().Replace(@"\", "/") + "/";
    }

    [Command("new", Description = "Creates a new AstroFlare project with configuration files already pre-installed.")]
    public void New([Argument(Description = "Give the name of your project.")]string ProjectName, [Option('d', Description = "Enable debugging of the 'Flare' CLI.")] bool Debug = false)
    {
        if (ProjectName is null)
        {
            throw new ArgumentNullException(nameof(ProjectName));
        }
        
        ProjectPath = Directory.GetCurrentDirectory().Replace(@"\", "/") + "/" + ProjectName + "/";
        AnsiConsole.Write(new FigletText("AstroFlare").LeftAligned().Color(Color.White));
        AnsiConsole.Status()
        .Start("Thinking...", ctx =>
        {
            // ctx.SpinnerStyle(Style.Parse("green"));
            ctx.Spinner(Spinner.Known.Default);
            AnsiConsole.MarkupLine("Running system check...");
            AnsiConsole.MarkupLine($"Creating directory... ({ProjectPath})");
            Directory.CreateDirectory(ProjectPath);
            Thread.Sleep(1000);
            ctx.Status("Importing Templates...");
            AnsiConsole.MarkupLine("Imported templates from API.");
            AnsiConsole.MarkupLine("Created templates.");
            Thread.Sleep(2000);
        });
    }

    // [Ignore]
}