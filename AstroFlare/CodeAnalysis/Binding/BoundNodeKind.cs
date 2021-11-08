﻿namespace AstroFlare.Compiler.CodeAnalysis.Binding
{
    internal enum BoundNodeKind 
    {
        LiteralExpression,
        VariableExpression,
        AssignmentExpression,
        UnaryExpression,
        BinaryExpression,
    }
}