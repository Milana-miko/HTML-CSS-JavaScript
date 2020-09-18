/*function funcPlus() {
    let number1, number2, result;

    number1 = document.getElementById('n1').value;
    number1 = parseInt(number1);

    number2 = document.getElementById('n2').value;
    number2 = parseInt(number2);

    result = number1 + number2;
    document.getElementsByTagName('p')[0].innerHTML = 'Result is' + result;
    //document.getElementById('out').innerHTML = 'Result is' + result;
}*/

/*function funcMinus() {

    let number1, number2, result;

    number1 = document.getElementById('n1').value;
    number1 = parseInt(number1);

    number2 = document.getElementById('n2').value;
    number2 = parseInt(number2);

    result = number1 - number2;

    document.getElementsByTagName('p')[0].innerHTML = 'Result is' + result;

    //document.getElementById('out').innerHTML = 'Result is' + result;
}*/

function calculator() {
    let number1 = parseFloat(document.getElementById('n1').value);
    let number2 = parseFloat(document.getElementById('n2').value);
    const operators = document.getElementById('oper').value;
    /*
    if(typeof(number1) === 'number' && typeof(number2) === 'number' && number1 !== NaN && number2 !== NaN && number1 !== Infinity && number2 !== Infinity && number1 !== -Infinity && number2 !== -Infinity) {
    if(operators === '+') {
        document.getElementById('result').value = number1 + number2;
    }
    else if(operators === '-') {
    document.getElementById('result').value = number1 - number2;
    }
    else if(operators === '/') {
        document.getElementById('result').value = number1 / number2;
    }
    else {
        document.getElementById('result').value = number1 * number2;
    }
    }
}
    */

    if(typeof(number1, number2) === 'number' && typeof(number1, number2) !== 'string' && typeof(number1, number2) !== 'symbol' && number1,
    number2 !== NaN && number1, number2 !== Infinity && number1, number2 !== -Infinity) {
        switch(operators) {
        case'+':
            document.getElementById('result').value = number1 + number2;
            break;
        case'-':
            document.getElementById('result').value = number1 - number2;
            break;
        case'/':
            document.getElementById('result').value = number1 / number2;
            break;
        default:
            document.getElementById('result').value = number1 * number2;
    }
    }
}

