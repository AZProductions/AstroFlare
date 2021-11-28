using AstroFlare.CodeAnalysis.Symbols;
using AstroFlare.CodeAnalysis.Syntax;

namespace AstroFlare.CodeAnalysis.Binding
{
    // TODO: Should the error expression accept an array of bound nodes so that we don't drop
    //       parts of the bound tree on the floor?

    internal sealed class BoundErrorExpression : BoundExpression
    {
        public BoundErrorExpression(SyntaxNode syntax)
            : base(syntax)
        {
        }

        public override BoundNodeKind Kind => BoundNodeKind.ErrorExpression;
        public override TypeSymbol Type => TypeSymbol.Error;
    }
}
