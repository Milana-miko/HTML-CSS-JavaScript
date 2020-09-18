function chekValue() {
    //console.log('Barev');
    let inputValue = document.getElementById("writeNumber");
    //console.log(inputValue.value);
    let x = Math.floor(Math.random() * 10) +1;
    console.log(x);
    if(inputValue.value > x) {
        console.log('You win!');
    } else if(inputValue.value < x) {
        console.log('You loose!');
    } else {
        console.log('We are equal!');
    }
    document.getElementById('writeNumber').value = '';
}

function testNegPos() {
    const inputValue = document.getElementById('negPos');
    const newInputValue = inputValue.value * 1;
    const x = Math.abs(newInputValue);
    if(x === newInputValue) {
        console.log('Positive!')
    } else {
        console.log('Negative!')
    }

}

//htmlic elemntneri vercnelu dzevery
//htmli meg 3hat batom, guyn tal, red, yellow, green 1functia grel vor batoni vra sexmel gri you clic red batom
//1-2 jamy