using AstroFlare.Tokens.Exeptions;

namespace AstroFlare.Tokens
{
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
