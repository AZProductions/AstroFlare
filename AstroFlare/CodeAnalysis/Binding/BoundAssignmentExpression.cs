using System;
using AstroFlare.CodeAnalysis.Symbols;
using AstroFlare.CodeAnalysis.Syntax;

namespace AstroFlare.CodeAnalysis.Binding
{
    internal sealed class BoundAssignmentExpression : BoundExpression
    {
        public BoundAssignmentExpression(SyntaxNode syntax, VariableSymbol variable, BoundExpression expression)
            : base(syntax)
        {
            Variable = variable;
            Expression = expression;
        }

        public override BoundNodeKind Kind => BoundNodeKind.AssignmentExpression;
        public override TypeSymbol Type => Expression.Type;
        public VariableSymbol Variable { get; }
        public BoundExpression Expression { get; }
    }
}
