namespace AstroFlare.CodeAnalysis.Syntax
{
    public abstract class MemberSyntax : SyntaxNode
    {
        private protected MemberSyntax(SyntaxTree syntaxTree)
            : base(syntaxTree)
        {
        }
    }
}