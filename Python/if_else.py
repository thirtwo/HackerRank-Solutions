#!/bin/python3

def IsOdd(number):
    if(number % 2 == 0):
        return False
    else:
        return True

def SetWeirdness(number,is_odd):
    if(is_odd):
        print("Weird")
    elif(number >= 2 and number <= 5):
        print ("Not Weird")
    elif(number >= 6 and number <= 20 ):
        print("Weird")
    else:
        print ("Not Weird")
        
if __name__ == '__main__':
    n = int(input().strip())
    SetWeirdness(n, IsOdd(n))