num = int(input("Enter the number you want to find the square root of: "))
Num, factors, Factors, underroot, sqrt, factorsProduct = num, [],[],[], 1,1

for smallerNum in range(2, Num):
    
    while Num % smallerNum == 0:
        
        factors += smallerNum
        Num /= smallerNum
        
for factor in factors:
    
    while factors.count(factor) % 2 == 0:
        
        Factors += factor
        factors -= factor
        factors -= factor
        
for Factor in Factors:
    
    sqrt *= Factor
    
if len(factors) > 0:
    
    for factor in factors:
        
        factorsProduct *= factor
    
    print(f"The square root of {num} is {sqrt}√{factorsProduct}")