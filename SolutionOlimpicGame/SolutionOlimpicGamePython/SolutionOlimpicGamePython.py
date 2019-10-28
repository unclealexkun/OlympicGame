size = int(input())
count = 0
maxLenght = 0

for index in range(0, size):
    value = int(input())
    if value > 0:
        count += 1
        if maxLenght < count:
            maxLenght = count
    else:
        
        count = 0

print(maxLenght)
