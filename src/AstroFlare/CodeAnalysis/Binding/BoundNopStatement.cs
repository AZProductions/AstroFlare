using AstroFlare.CodeAnalysis.Syntax;

namespace AstroFlare.CodeAnalysis.Binding
{
    internal sealed class BoundNopStatement : BoundStatement
    {
        public BoundNopStatement(SyntaxNode syntax)
            : base(syntax)
        {
        }

        public override BoundNodeKind Kind => BoundNodeKind.NopStatement;
    }
}
