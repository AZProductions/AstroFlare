﻿namespace AstroFlare.Compiler.CodeAnalysis.Binding
{
    internal abstract class BoundNode 
    {
        public abstract BoundNodeKind Kind { get; }
    }
}