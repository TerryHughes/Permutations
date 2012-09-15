namespace Permutations
{
    using Machine.Specifications;

    class when_swapping_two_characters
    {
        Establish context =()=>
        {
            @string = "abcdefg";
            expression = "(ac)";
        };

        Because of =()=> result = @string.Permutate(expression);

        It should_swap_a_and_c =()=> result.ShouldEqual("cbadefg");

        static string @string;
        static string expression;
        static string result;
    }
}
