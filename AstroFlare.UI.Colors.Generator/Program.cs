string dataSet = File.ReadAllText(@"D:\Github\AstroFlare\.local\input.txt");
string[] dataSets = dataSet.Split('\n');
List<string> Input = new List<string>();
List<string> Output = new List<string>();
foreach (string inValue in dataSets)
{
    Input.Add(inValue.Trim().Replace("<Color x:Key=" + '"', string.Empty).Replace('"' + ">", "[]").Replace("</Color>", string.Empty));
}

foreach (string inValue in Input)
{
    try
    {
        Output.Add("public static readonly string " + inValue.Split("[]")[0] + " = " + '"' + inValue.Split("[]")[1] + '"' + ";");
    }
    catch { }
}

foreach (string inValue in Output)
    Console.WriteLine(inValue);