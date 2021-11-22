namespace AstroFlare.Imports.Tokens
{
    internal enum ImportType 
    {
        Internal, // Current-file reference
        External, // Program-wide reference.
        Other // Throws exeption.
    }
}
