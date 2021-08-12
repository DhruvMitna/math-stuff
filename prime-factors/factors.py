try:    

    num = int(input("Enter the number you wnat to find the prime factors of: "))
    Num = num

    print(f"The prime factors of {num} are-:\n")

    for smallerNum in range(2, num):

        while Num % smallerNum == 0:

            print(smallerNum)
            Num /= smallerNum

    if Num == num:

        print(f"{num} has no prime factors (except {num} itself)")

except ValueError:

    print("Please enter a valid value.")