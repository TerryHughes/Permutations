**Permutations**  
Take a string, say '*abcdefg*' and scramble it into '*cgdaefb*'.  
There is an expression form for this permutation: *(acd)(bg)*.  
Read this expression as follows left to right:  
"a becomes c, c becomes d, and d becomes a"  (note: the last letter inside the parentheses loops back to the first)  
then  
"b becomes g, g becomes b"

The permutations of (e), and (f) are not explicitly stated in the expression, but it is not illegal to do so. "Multiplying" these expressions is the same as applying them in sequence against the starting string. The above expression is just that a multiplication of (acd) times (bg). Note that multiplication is not NECCESARILY commutative. The "unit" permutation is "()".

**Challenge**  
In language of your choice write a program/method that takes an input string and arbitrary permutation expression, applies it, and returns the resulting string, and, a valid simplified expression of the final result.

**Example**  
String: *abcdefg*  
Expression: *(acfg)(bcd)(aed)(fade)(bgfae)*

Result: *dcegbfa (gad)(ebc)*
