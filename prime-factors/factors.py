try:

    # Getting the user input.
    num = int(input("Enter the number you wnat to find the prime factors of: "))
    Num = num

    print(f"The prime factors of {num} are-:\n")

    # Calculating the output.
    for smallerNum in range(2, num):

        while Num % smallerNum == 0:

            print(f"\t{smallerNum}")
            Num /= smallerNum

    # Composite case.
    if Num == num:

        print(f"{num} has no prime factors (except {num} itself)")

# If the user enters a string instead of an integer, this message is printed out instead of the program crashing with an error.
except ValueError:

    print("Please enter a valid value.")