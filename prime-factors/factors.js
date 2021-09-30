// Importing the necessary module.
const ps = require("prompt-sync")();
prompt = ps;

// Defining a function for ranges
function rangeFor(start, end) {

    let rangeList = []

    for (i = 0; i < end; i++) {

        rangeList.push(i)

    }

    return rangeList

}

// Getting the user input.
num = parseInt(prompt("Enter the number you wnat to find the prime factors of: "));
Num = num;

// Calculating the ouput.
console.log(`The prime factors of ${num} are-:\n`)

for (smallerNum in rangeFor(2, num)) {

    while (Num % smallerNum === 0) {

        console.log(`\t${smallerNum}`)
        Num /= smallerNum

    }

}

// Composite case.
if (num === Num) console.log(`${num} has no prime factors (except ${num} itself)`)