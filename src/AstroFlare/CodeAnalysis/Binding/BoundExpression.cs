using System;
using AstroFlare.CodeAnalysis.Symbols;
using AstroFlare.CodeAnalysis.Syntax;

namespace AstroFlare.CodeAnalysis.Binding
{
    internal abstract class BoundExpression : BoundNode
    {
        protected BoundExpression(SyntaxNode syntax)
            : base(syntax)
        {
        }

        public abstract TypeSymbol Type { get; }
        public virtual BoundConstant? ConstantValue => null;
    }
}
