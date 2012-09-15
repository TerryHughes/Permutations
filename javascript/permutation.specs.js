describe("when swapping two characters", function() {
    var string = "abcdefg";
    var expression = "(ac)";

    var result = permutate(string, expression);

    it("should swap a and c", function() {
        expect(result).toBe("cbadefg");
    });
});
