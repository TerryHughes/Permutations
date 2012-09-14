namespace Permutations
{
    public static class PermutationStringExtension
    {
        public static string Permutate(this string @string, string expression)
        {
            var firstCharacter = expression[1];
            var secondCharacter = expression[2];

            return @string
                .Replace(secondCharacter, '*')
                .Replace(firstCharacter, secondCharacter)
                .Replace('*', firstCharacter)
                ;
        }
    }
}
