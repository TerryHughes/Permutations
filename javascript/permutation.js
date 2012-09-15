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

function optimize(original, permutated) {
    var internal = function() {
        var result = "";
        var visitedIndex = [];

        for (var i = 0; i < original.length; i++) {
            if (visitedIndex.indexOf(i) !== -1)
                continue;

            var swapStack = [];
            swapStack.push(i);
            result += "(" + original[i];

            while (swapStack.length > 0) {
                var current = swapStack.pop();

                visitedIndex.push(current);

                if (permutated[current] == original[i])
                    continue;

                swapStack.push(original.indexOf(permutated[current]));
                result += permutated[current];
            }

            result += ")";
        }

        return result;
    };

    var detailed = internal();
    var compacted = "";

    var matches = detailed.split(/([a-z][a-z]+)/);
    for (var i = 0; i < matches.length; i++)
        if (matches[i] != "")
            compacted += matches[i];

    return compacted;
}

function permutateAndOptimize(string, expression) {
    var p = permutate(string, expression);
    var o = optimize(string, p);

    return p + " " + o;
}
