function input(elements) {
    document.calculator.display.value = document.calculator.display.value + elements;
}

function clean() {
    document.calculator.display.value = '';
}

function backFunction() {
    let backSign = document.calculator.display.value;
    document.calculator.display.value = backSign.substring(0, backSign.length - 1);
}

function equal() {
    document.calculator.display.value = eval(document.calculator.display.value);
}
