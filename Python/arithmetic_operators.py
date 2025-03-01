def PrintSum(number_a,number_b):
    print(number_a+number_b)

def PrintExtraction(number_a,number_b):
    print(number_a-number_b)

def PrintProduct(number_a,number_b):
    print(number_a*number_b)

if __name__ == '__main__':
    a = int(input())
    b = int(input())
    PrintSum(a,b)
    PrintExtraction(a,b)
    PrintProduct(a,b)