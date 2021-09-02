try:

    # Getting the required values from the user.
    num = int(input("Enter the number you want to check to be a prime number or not: "))
    nonDivisibles = 0

    if num > 1:
        
        for divisor in range(2, num):
            
            if num % divisor == 0:
                
                print("The number is composite.")
                break

            else:
                
                nonDivisibles += 1
                
        if nonDivisibles == num - 2:
            
            print("The number is prime.")
        
    else:
        
        print("Please enter a positive number.")
  
# If the user enters an invalid value, then this message is printed out instead of the program crashing with an ugly error.        
except ValueError:
    
    print("Please enter a valid value.")