/// <summary>
/// Useful C# snippets from CambiaResearch.com
/// </summary>
namespace AstroFlare.UI.Theme
{
    using System;
    using System.Drawing;
    using System.Text.RegularExpressions;
    public class ThemeBrushConverter
    {
             /// <summary>
      /// Convert a hex string to a .NET Color object.
      /// </summary>
      /// <param name="hexColor">a hex string: "FFFFFF", "#000000"</param>
      public static Color HexStringToColor(string hexColor)
      {
         string hc = ExtractHexDigits(hexColor);
         if (hc.Length != 6)
         {
            // you can choose whether to throw an exception
            //throw new ArgumentException("hexColor is not exactly 6 digits.");
            return Color.Empty;
         }
         string r = hc.Substring(0, 2);
         string g = hc.Substring(2, 2);
         string b = hc.Substring(4, 2);
         Color color = Color.Empty;
         try
         {
            int ri 
               = Int32.Parse(r, System.Globalization.NumberStyles.HexNumber);
            int gi 
               = Int32.Parse(g, System.Globalization.NumberStyles.HexNumber);
            int bi 
               = Int32.Parse(b, System.Globalization.NumberStyles.HexNumber);
            color = Color.FromArgb(ri, gi, bi);
         }
         catch
         {
            // you can choose whether to throw an exception
            //throw new ArgumentException("Conversion failed.");
            return Color.Empty;
         }
         return color;
      }
      /// <summary>
      /// Extract only the hex digits from a string.
      /// </summary>
      public static string ExtractHexDigits(string input)
      {
         // remove any characters that are not digits (like #)
         Regex isHexDigit 
            = new Regex("[abcdefABCDEF\\d]+", RegexOptions.Compiled);
         string newnum = "";
         foreach (char c in input)
         {
            if (isHexDigit.IsMatch(c.ToString()))
               newnum += c.ToString();
         }
         return newnum;
      }
    }
}