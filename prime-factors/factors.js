const ps = require("prompt-sync")();
prompt = ps;

function rangeFor(start, end) {

    let rangeList = []

    for (i = 0; i < end; i++) {

        rangeList.push(i)

    }

    return rangeList

}

num = parseInt(prompt("Enter the number you wnat to find the prime factors of: "));
Num = num;

console.log(`The prime factors of ${num} are-:\n`)

for (smallerNum in rangeFor(2, num)) {

    while (Num % smallerNum === 0) {

        console.log(`\t${smallerNum}`)
        Num /= smallerNum

    }

}

if (num === Num) console.log(`${num} has no prime factors (except ${num} itself)`)