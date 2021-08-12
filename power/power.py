try:

    num = int(input("Enter the number you want to find the power of: "))
    power = int(input("Enter the power that you want to find: "))
    Num = num

    for _ in range(power - 1):
        
        Num *= num
        
    print(f"{num}^{power} is {Num}")
    
except ValueError:
    
    print("Please enter a valid value.")