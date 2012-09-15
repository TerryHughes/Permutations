namespace Permutations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

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

        static string InternalOptimize(string original, string permutated)
        {
            var result = String.Empty;
            var visitedIndex = new List<int>();

            for (var i = 0; i < original.Length; i++)
            {
                if (visitedIndex.Contains(i))
                    continue;

                var swapStack = new Stack<int>();
                swapStack.Push(i);
                result += "(" + original[i];

                while (swapStack.Count > 0)
                {
                    var current = swapStack.Pop();

                    visitedIndex.Add(current);

                    if (permutated[current] == original[i])
                        continue;

                    swapStack.Push(original.IndexOf(permutated[current]));
                    result += permutated[current];
                }

                result += ")";
            }

            return result;
        }

        public static string Optimize(this string original, string permutated)
        {
            var detailed = InternalOptimize(original, permutated);
            var compacted = String.Empty;

            var regex = new Regex(@"\([a-z][a-z]+\)");
            foreach (var match in regex.Matches(detailed))
                compacted += match;

            return compacted;
        }
    }
}
