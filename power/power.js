// Importing the necessary module.
const ps = require("prompt-sync")();
prompt = ps;

// Getting the user input.
num = parseInt(prompt("Enter the number you want to find the power of: "));
power = parseInt(prompt("Enter the power that you want to find: "));
Num = num;

// Caluclating the result.
for (i = 0; i < power - 1; i++) {

    Num *= num;

}

// Output.
console.log(`${num} ^ ${power} is ${Num}`);