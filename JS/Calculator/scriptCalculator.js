function insert(mathSigns) {
    document.formForTextResult.textview.value = document.formForTextResult.textview.value + mathSigns;
}

function clean() {
    document.formForTextResult.textview.value = '';
}

function back() {
    let backSign = document.formForTextResult.textview.value;
    document.formForTextResult.textview.value = backSign.substring(0, backSign.length - 1);
}

function equal() {
    let eq = document.formForTextResult.textview.value;
    if(eq) {
        document.formForTextResult.textview.value = eval(eq);
    }
} 