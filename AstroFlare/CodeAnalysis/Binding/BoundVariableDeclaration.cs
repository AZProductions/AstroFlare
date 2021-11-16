using AstroFlare.CodeAnalysis.Symbols;
using AstroFlare.CodeAnalysis.Syntax;

namespace AstroFlare.CodeAnalysis.Binding
{
    internal sealed class BoundVariableDeclaration : BoundStatement
    {
        public BoundVariableDeclaration(SyntaxNode syntax, VariableSymbol variable, BoundExpression initializer)
            : base(syntax)
        {
            Variable = variable;
            Initializer = initializer;
        }

        public override BoundNodeKind Kind => BoundNodeKind.VariableDeclaration;
        public VariableSymbol Variable { get; }
        public BoundExpression Initializer { get; }
    }
}
