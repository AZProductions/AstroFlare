using AstroFlare.Tokens.Exeptions;
using System;

namespace AstroFlare.Tokens
{
    public enum Tokens
    {
        EndOfFileToken
    }

    public class TokenConverter
    {
        char? SingleTokenConvert(Tokens kind) 
        {
            switch (kind) 
            {
                case Tokens.EndOfFileToken:
                    return ';';
                default:
                    throw new InvalidTokenConverterExeption();
            }
        }
    }
}

namespace AstroFlare.Tokens.Exeptions
{
    class InvalidTokenConverterExeption : Exception
    {
        public InvalidTokenConverterExeption() { }
        public InvalidTokenConverterExeption(AstroFlare.Tokens.Tokens kind) : base(String.Format("Invalid token kind, this function needs to be a single token kind. {0}", kind)) { }
    }
}
