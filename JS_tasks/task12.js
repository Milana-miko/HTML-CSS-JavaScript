//Дано число n (n > 0). Проверьте, простое оно или составное. Если число простое - верните из функции строку "Простое число", если нет - "Составное число". Воспользуйтесь методом перебора делителей числа.

Sample Input 1:

2
Sample Output 1:

Простое число

function testCycle(n) {
  var x = 2;
  while (x <= n) {
      if (n % x == 0 && n != x) {
          return "Составное число"; }
      else if (n % x != 0) {
          x++; }
      else {
          return "Простое число"; }
} 
}