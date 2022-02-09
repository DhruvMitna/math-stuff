try:

    num = int(
        input("Enter the even number that you want to find the prime parts of: "))
    primes = []

    for possible in range(2, num):

        nonDivisibles = 0

        for divisor in range(2, possible):

            if possible % divisor == 0:

                break

            else:

                nonDivisibles += 1

        if nonDivisibles == possible - 2:

            primes.append(possible)

    if primes:

        outputList = []

        for prime in primes:

            for prime2 in primes:

                if prime + prime2 == num:

                    outputList.append(f"{prime} + {prime2}")

        if len(outputList) % 2 == 0:

            for _ in range(len(outputList) // 2):

                outputList.pop(-1)

        print(f"\nThe prime parts of {num} are-:\n")

        for output in outputList:

            print(output)

except ValueError:

    print("Please enter a valid value.")
