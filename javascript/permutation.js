function permutate(string, expression) {
    var result = string;

    var units = [];
    var matches = expression.split(/\(|\)/);
    for (var i = 0; i < matches.length; i++)
        if (matches[i] != "")
            units.push(matches[i]);

    for (var u = 0, unit; unit = units[u++];) {
        var indexes = [];

        for (var i = 0, c; c = unit[i++];)
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
    }

    return result;
}
