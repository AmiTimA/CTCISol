//console.log("Hello World!");

function factorial(value) {
    // Breaking condition
    if (value < 0) {
        return -1;
    } else if (value === 0){
        return 1;
    } else {
        return value * factorial(value - 1);
    }
}

console.log(factorial(4));