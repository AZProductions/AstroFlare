using AstroFlare.Imports.Tokens;

namespace AstroFlare.Imports
{
    internal class Importer
    {
        public Importer(Tokens.ImportKind kind)
        {
            Kind = kind;
        }

        public ImportKind Kind { get; }
    }
}