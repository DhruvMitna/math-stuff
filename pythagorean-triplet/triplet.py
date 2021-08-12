try:

    num = int(input("Enter the number you want to find the pythagorean triplet of: "))

    print(f"The pythagorean triplet of {num} is {int(num)}, {int(((num / 2) * (num / 2)) - 1)}, {int(((num / 2) * (num / 2)) + 1)}.")
    
except ValueError:
    
    print("Please enter a valid value.")