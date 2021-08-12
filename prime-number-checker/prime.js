// Importing the necessary functions from modules.
const ps = require("prompt-sync")()
prompt = ps

// Getting the necessary values from the user.
let num = parseInt(prompt("Enter the number you want to check to be a prime number or not: "))
let nonDivisibles = 0

if (num > 1) {

    for (divisor = 2; divisor < num; divisor ++) {

        if (num % divisor == 0) {

            console.log("The number is composite.")
            break

        } else nonDivisibles ++

    }

    if (nonDivisibles == num - 2) console.log("The number is prime.")

// If the user enters a negative value, this error is displayed.
} else  console.log("Please enter a valid value.")