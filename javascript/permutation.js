function permutate(string, expression) {
    var firstCharacter = expression[1];
    var secondCharacter = expression[2];

    return string
        .replace(secondCharacter, "*")
        .replace(firstCharacter, secondCharacter)
        .replace("*", firstCharacter)
        ;
}
