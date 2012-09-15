namespace Permutations
{
    using System;
    using System.Linq;

    public static class PermutationStringExtension
    {
        public static string Permutate(this string @string, string expression)
        {
            var result = @string;
            var units = expression.Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var indexes in units.Select(unit => unit.Select(c => result.IndexOf(c)).ToArray()))
            {
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
            }

            return result;
        }
    }
}
