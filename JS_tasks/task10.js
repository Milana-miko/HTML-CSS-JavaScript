//Даны числа a и b. Найдите сумму квадратов чисел между a и b включительно. Неизвестно, какое из чисел a или b больше.

Sample Input 1:

9 4
Sample Output 1:

271

function testCycle(a, b) {
    var x = 0;
    for (i = a; i <= b; i ++){
        x = x + (i * i);
    }
    for (i = a; i >= b; i --){
        x = x + (i * i);
    }
    if (a == b){
        x = a*a;
    }

    return x;
}