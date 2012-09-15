namespace Permutations
{
    using System.Linq;

    public static class PermutationStringExtension
    {
        public static string Permutate(this string @string, string expression)
        {
            var result = @string;
            var indexes = expression.Substring(1, expression.Length - 2).Select(c => result.IndexOf(c)).ToArray();

            for (var i = 0; i < indexes.Length - 1; i++)
            {
                var firstCharacter = result[indexes[i]];
                var secondCharacter = result[indexes[i + 1]];

                result = result
                    .Replace(secondCharacter, '*')
                    .Replace(firstCharacter, secondCharacter)
                    .Replace('*', firstCharacter)
                    ;
            }

            return result;
        }
    }
}
