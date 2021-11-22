using AstroFlare.Imports;
using System;
namespace AstroFlare.Imports.Tests;

class Tests 
{
    static void Main(string[] args)
    {
        string input = /*"include internal System.(*); //hello";*/ "agfsadhksjf//hello world!";

        Console.WriteLine(Imports.ImportParser.ImportParse(input));
    }
}