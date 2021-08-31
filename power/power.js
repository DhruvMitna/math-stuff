const ps = require("prompt-sync")();
prompt = ps;

num = parseInt(prompt("Enter the number you want to find the power of: "));
power = parseInt(prompt("Enter the power that you want to find: "));
Num = num;

for (i = 0; i < power - 1; i++) {

    Num *= num;

}

console.log(`${num} ^ ${power} is ${Num}`);