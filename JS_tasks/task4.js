//В этом задании вам нужно вычислить сумму всех четных чисел, встречающихся в ряду от 1 до числа (включительно), передаваемого в нашу функцию (переменная "а").

Sample Input:

3
Sample Output:

2

function testWhile(a) {
    var x=0;
    var b = 0;
    while(b<=a){
        if(b%2==0){
            x = x + b;}
        b ++;}
    return x;
    }