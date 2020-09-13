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

function isPrime(value){
    //for (i = 2; i * i <= value; i++){
    for (i = 2; i <= Math.sqrt(value); i++) {
        if(value % i === 0) {
            return false;
        }
    }

    return true;
}

//console.log(factorial(4));
//console.log(isPrime(11));