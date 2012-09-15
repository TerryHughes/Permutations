namespace Permutations
{
    using Machine.Specifications;

    class when_swapping_more_than_two_characters
    {
        Establish context =()=>
        {
            @string = "abcdefg";
            expression = "(ace)";
        };

        Because of =()=> result = @string.Permutate(expression);

        It should_swap_a_with_c_c_with_e_and_e_with_a =()=> result.ShouldEqual("cbedafg");

        static string @string;
        static string expression;
        static string result;
    }
}
