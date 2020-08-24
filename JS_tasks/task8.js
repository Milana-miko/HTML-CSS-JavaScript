//Даны числа a и b. Выведите строку с числами между а и b включая границы, отсортированными по возрастанию. Неизвестно, какое из чисел больше, но известно, что и a и b больше 0.

Sample Input 1:

8 1
Sample Output 1:

1 2 3 4 5 6 7 8

function testCycle(a, b) {
    var x = " ";
     for(var i=a; i <= b; i++) {
     x +=" "+ i;
     }
   
    for(var y = b; y <= a; y++){
       x +=" " + y;
    }
    
    if (a == b){
        x = a;
           }
    
    return x;
}