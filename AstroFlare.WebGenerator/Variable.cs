using System.IO;

namespace AstroFlare.WebGenerator
{
    public class Variable
    {
        public static readonly string Log = "[grey]LOG: [/]";
        public static readonly string WorkingDirectory = Directory.GetCurrentDirectory().Replace(@"\", "/").Replace("/bin/Debug/net6.0", string.Empty).Replace(@"/AstroFlare.WebGenerator", string.Empty) + "/";
    }
}
