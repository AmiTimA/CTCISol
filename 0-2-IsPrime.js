function isPrime(value){
    //for (i = 2; i * i <= value; i++){
    for (i = 2; i <= Math.sqrt(value); i++) {
        if(value % i === 0) {
            return false;
        }
    }

    return true;
}

console.log(isPrime(11));