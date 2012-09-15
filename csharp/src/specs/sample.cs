namespace Permutations
{
    using Machine.Specifications;

    class sample
    {
        Establish context =()=>
        {
            @string = "abcdefg";
            expression = "(acd)(bg)";
        };

        Because of =()=> result = @string.PermutateAndOptimize(expression).Split(' ')[0];

        It should_permutate =()=> result.ShouldEqual("cgdaefb");

        static string @string;
        static string expression;
        static string result;
    }
}
