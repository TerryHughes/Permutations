describe("when swapping two characters", function() {
    var string = "abcdefg";
    var expression = "(ac)";

    var result = permutate(string, expression);

    it("should swap a and c", function() {
        expect(result).toBe("cbadefg");
    });
});

describe("when swapping more than two characters", function() {
    var string = "abcdefg";
    var expression = "(ace)";

    var result = permutate(string, expression);

    it("should swap a with c, c with e, and e with a", function() {
        expect(result).toBe("cbedafg");
    });
});
