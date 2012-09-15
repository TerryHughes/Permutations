namespace Permutations
{
    using Machine.Specifications;

    class example
    {
        Establish context =()=>
        {
            @string = "abcdefg";
            expression = "(acfg)(bcd)(aed)(fade)(bgfae)";
        };

        Because of =()=>
        {
            var result = @string.PermutateAndOptimize(expression).Split(' ');

            permutated = result[0];
            optimization = result[1];
        };

        It should_permutate =()=> permutated.ShouldEqual("dcegbfa");

        It should_optimize =()=> optimization.ShouldNotEqual(expression);

        It should_result_in_the_same_permutation =()=> @string.Permutate(optimization).ShouldEqual(permutated);

        static string @string;
        static string expression;
        static string permutated;
        static string optimization;
    }
}
