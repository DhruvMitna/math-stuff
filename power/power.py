try:

    # Getting the user input.
    num = int(input("Enter the number you want to find the power of: "))
    power = int(input("Enter the power that you want to find: "))
    Num = num

    # Calculating the result.
    for _ in range(power - 1):

        Num *= num

    # Output.
    print(f"{num} ^ {power} is {Num}")

# If the user enters a string instead of an integer, then this message is printed out instead of the program crashing with an error. 
except ValueError:

    print("Please enter a valid value.")