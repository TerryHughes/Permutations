namespace Permutations
{
    using Machine.Specifications;

    class when_optimizing
    {
        Establish context =()=>
        {
            expression = "(ace)(ea)";
            original = "abcdefg";
            permutated = "cbadefg";
        };

        Because of =()=> result = original.Optimize(permutated);

        It should_optimize =()=> result.ShouldNotEqual(expression);

        It should_result_in_the_same_permutation =()=> original.Permutate(result).ShouldEqual(permutated);

        static string expression;
        static string original;
        static string permutated;
        static string result;
    }
}
