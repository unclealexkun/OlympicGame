size = int(input())
count = 0
maxLenght = 0

for index in range(0, size):
    value = int(input())
    if value == 0:
        if maxLenght < count:
            maxLenght = count
        count = 0
    else:
        count += 1
        if index == size - 1:
            if maxLenght < count:
                maxLenght = count

print(maxLenght)
