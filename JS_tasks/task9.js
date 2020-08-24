//Даны числа a и b. Выведите строку с числами от большего числа до меньшего. Известно, что и a и b больше либо равно 1, но неизвестно, какое из них больше.
Sample Input 2:

11 14
Sample Output 2:

14 13 12 11

function testCycle(a, b) {
    var x = " ";
     for(var i=a; i >= b; i--) {
     x +=" "+ i;
     }
   
    for(var y = b; y >= a; y--){
       x +=" " + y;
    }
    
    if (a == b){
        x = a;
           }
    
    return x;
}