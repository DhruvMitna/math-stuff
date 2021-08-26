try:

    num = int(input("Enter the number that you want to factorize: "))
    Num = num

    if num > 0:

        print("The factors are-:\n")

        for lesserNum in range(2, num):

            while Num % lesserNum == 0:

                print(f"\t{lesserNum}")
                Num /= lesserNum

except ValueError:

    print("Please enter a valud value.")