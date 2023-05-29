using System;
using System.Collections.Generic;
using System.Linq;

namespace Minsk.CodeAnalysis
{
    public enum SyntaxKind
    {
        // Tokens
        BadToken,
        EndOfFileToken,
        WhitespaceToken,
        NumberToken,
        OpenParenthesisToken,
        SlashToken,
        StarToken,
        MinusToken,
        PlusToken,
        CloseParenteshisToken,

        //Expressions
        NumberExpression,
        BinaryExpression,
        ParenthesizedExpression
    }
}