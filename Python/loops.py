def Square(number):
    return number * number

def SquareLoop(range_number):
    for i in range(range_number):
        print(Square(i))

if __name__ == '__main__':
    n = int(input())
    SquareLoop(n)