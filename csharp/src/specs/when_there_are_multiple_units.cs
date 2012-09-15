namespace Permutations
{
    using Machine.Specifications;

    class when_there_are_multiple_units
    {
        Establish context =()=>
        {
            @string = "abcdefg";
            expression = "(ac)(bd)";
        };

        Because of =()=> result = @string.Permutate(expression);

        It should_swap_a_with_c_and_b_with_d =()=> result.ShouldEqual("cdabefg");

        static string @string;
        static string expression;
        static string result;
    }
}
