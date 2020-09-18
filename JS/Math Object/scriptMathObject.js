/*// 1. Gtnel tvi sin, cos.

function testSinCos(a) {
    if(typeof(a) === 'number' && a !== NaN && a !== Infinity) {
        console.log('sin(x) = ' + Math.sin(a * Math.PI / 180));
        console.log('cos(x) = ' + Math.cos(a * Math.PI / 180));
    }  else {
        console.log('Indefinite variable!!!');
    }
}
testSinCos(1,571); // 90° × π/180 = 1,571 рад

// 2. Gtnel erankyan makeresy. a ev b erankyan koxmeri erkarutyunnern en, isk c nranc mijev ankyunn e gradusnerov.

const a = 5;
const b = 15;
const c = 30;
console.log(1/2 * a * b * Math.sin(c * Math.PI / 180));

//3. Trvac e tiv. Hanel mnacordayin masy, imanal bacasakan e te drakan.
// Naev kloracnel tivy depi verev.

const a = 235.678;
console.log(Math.ceil(a));
console.log(Math.trunc(a));
console.log(Math.sign(a));

// 4. Unenk array. Bacasakan tvery darcnel drakan ev gtnel array amenamec ev poqr tvery.

array = [15, -25, 77, -12, 29, 88, -92];
for(let i = 0; i < array.length; i++) {
    if(array[i] < 0) {
        array[i] = Math.abs(array[i]);
    }
}
console.log(Math.max(...array));
console.log(Math.min(...array));
console.log(array);

//5. unenk erku tiv (a, b). Petk e stanank a bi astichanum.

let a = 5;
const b = 2;
console.log(Math.pow(a, b));

//6. Function stanum e 4 tiv. Petk e gtnel ayd tveri meci bajanman poqri vra resulty. patasxany petk e kloracnel depi motaka poqr amboxj tivy.

function testFloorMinMax(a, b, c, d) {
    if(typeof(a) === 'number' && a !== NaN && a !== 0 && a !== Infinity) {
        console.log(Math.floor(Math.max(a, b, c, d) / Math.min(a, b, c, d)));
    }
}
testFloorMinMax(25.2, 2, 8, 5);

//7. Gtnel random tiv 0ic x neraryal.

const x = 51;
console.log(Math.floor(Math.random() * (x + 1)));

//8. Trvac e tiv. Gtnel armat, patasxany kloracnel minchev amboxjner, tasnordakanner ev haryurdakanner.

const x = 379;
const y = Math.sqrt(x);
console.log(y);
console.log(Math.round(y));
console.log(y.toFixed(1));
console.log(y.toPrecision(4));


//9. Unenk datark array. Hamalrel array 10 hat patahakan tverov 0 minchev 20 neraryal.

let array = [];
for(let i = 0; i < 10; i++) {
    array[i] = Math.floor(Math.random() * (20 + 1));
}
console.log(array);

//10. Trvac e tiv. Gtnel tvi xoranardi armaty. Kloracnel depi verev ev nergev.

const x = 589;
const y = Math.cbrt(x);
console.log(y);
console.log(Math.floor(y));
console.log(Math.ceil(y));*/

