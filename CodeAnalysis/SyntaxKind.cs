using System;
using System.Collections.Generic;
using System.Linq;

namespace Minsk.CodeAnalysis
{
    enum SyntaxKind
    {
        NumberToken,
        WhitespaceToken,
        OpenParenthesisToken,
        SlashToken,
        StarToken,
        MinusToken,
        PlusToken,
        CloseParenteshisToken,
        BadToken,
        EndOfFileToken,
        NumberExpression,
        BinaryExpression,
        ParenthesizedExpression
    }
}