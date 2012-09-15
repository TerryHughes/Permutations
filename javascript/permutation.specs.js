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

describe("when there are multiple units", function() {
    var string = "abcdefg";
    var expression = "(ac)(bd)";

    var result = permutate(string, expression);

    it("should swap a with c and b with d", function() {
        expect(result).toBe("cdabefg");
    });
});

describe("when optimizing", function() {
    var expression = "(ace)(ea)";
    var original = "abcdefg";
    var permutated = "cbadefg";

    var result = optimize(original, permutated);

    it("should optimize", function() {
        expect(result).toNotBe(expression);
    });

    it("should result in the same permutation", function() {
        expect(permutate(original, result)).toBe(permutated);
    });
});
