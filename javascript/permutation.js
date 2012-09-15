function permutate(string, expression) {
    var result = string;
    var trimmed = expression.substring(1, expression.length - 1);

    var indexes = [];
    for (var i = 0, c; c = trimmed[i++];)
        indexes.push(result.indexOf(c));

    for (var i = 0; i < indexes.length - 1; i++) {
        var firstCharacter = result[indexes[i]];
        var secondCharacter = result[indexes[i + 1]];

        result = result
            .replace(secondCharacter, "*")
            .replace(firstCharacter, secondCharacter)
            .replace("*", firstCharacter)
            ;
    }

    return result;
}
