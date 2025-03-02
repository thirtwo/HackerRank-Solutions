import math

def FindMax(array):
    maxVal = array[0]
    for runner in array:
        if(runner > maxVal):
            maxVal = runner
    return maxVal
    
def FindRunnerUpScore(array):
    first = FindMax(array)
    second = -math.inf
    for runner in array:
        if(runner < first and runner >second):
            second = runner
    return second

if __name__ == '__main__':
    n = int(input())
    arr = map(int, input().split())
    print(FindRunnerUpScore(list(arr)))
