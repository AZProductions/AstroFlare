using System;

namespace AstroFlare.Compiler.CodeAnalysis.Binding
{
    internal abstract class BoundExpression : BoundNode 
    {
        public abstract Type Type { get; }
    }
}