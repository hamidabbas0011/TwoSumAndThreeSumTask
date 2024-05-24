A pair of numbers in an integer array whose sum is equal to 0. For ex: 
bool IsSumTwoZero(int[] a)
• Ex 1: [-7, -5, 4, 5, 6] = true
o We can add -5 and 5 to sum to zero
• Ex2: [-7, -3, 4, 6, 10, 15] = false
o We cannot find any two numbers whose sum is zero
1. A group of 3 numbers in an integer array whose sum is equal to 0. For ex: 
bool IsSumThreeZero(int[] a)
• Ex 1: [-7, -5, 4, 5, 6] = false
o Cannot find three numbers whose sum is zero
• Ex 2: [-7, -3, 4, 6, 10, 15] = true
o Sum of -7, -3, 10 = 0
