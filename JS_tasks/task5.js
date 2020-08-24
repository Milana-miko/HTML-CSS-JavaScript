//В этом задании вам нужно вычислить факториал для числа, передаваемого в нашу функцию.
Sample Input 1:

7
Sample Output 1:

5040

function testFactorial(a) {
    var x = 1;
    for (var i = 2; i <= a; i++)
    x *= i;
    return x;
}