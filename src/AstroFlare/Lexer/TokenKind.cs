namespace AstroFlare
{
    public static class TokenKinds
    {
        public enum TokenKind
        {
            None,
            Identifier,
            Number,
            String,
            Operator,
            Keyword,
            Comment,
            Whitespace,
            NewLine,
            EndOfFile
        }
    }
}