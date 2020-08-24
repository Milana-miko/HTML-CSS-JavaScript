//Дано число n (n > 1). Верните из функции n-ное число Фибоначчи

Sample Input 2:

7
Sample Output 2:

13

function testCycle(n) {
    let prev = 0, next = 1;
    for(let i = 0; i < n; i++){
    next = prev + next;
    prev = next - prev;
  }
  return prev;
}