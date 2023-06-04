namespace Minsk.CodeAnalysis
{
    internal static class SyntaxFacts
    {
        public static int GetUnaryOperatorPrecedence(this SyntaxKind kind)
        {
            switch (kind)
            {
                case SyntaxKind.PlusToken:
                    return 1;
                case SyntaxKind.MinusToken:
                    return 1;
                default: return 0;
            }
        }
        public static int GetBinaryOperatorPrecedence(this SyntaxKind kind)
        {
            switch (kind)
            {
                case SyntaxKind.StarToken:
                    return 2;
                case SyntaxKind.SlashToken:
                    return 2;
                case SyntaxKind.PlusToken:
                    return 1;
                case SyntaxKind.MinusToken:
                    return 1;
                default: return 0;
            }
        }
    }
}