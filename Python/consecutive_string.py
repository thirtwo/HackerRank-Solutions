def GenerateConsecutiveString(range_number):
    consecutivestr = ""
    for i in range(range_number):
         consecutivestr += str(i + 1)
    return consecutivestr

if __name__ == '__main__':
    n = int(input())
    print(GenerateConsecutiveString(n))