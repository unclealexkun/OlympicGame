size = int(input())
if size > 0:
    currentElement = int(input())
    newList = [currentElement]

    for index in range(1, size):
        element = int(input())
        if currentElement != element:
            newList.append(element)
            currentElement = element
        
    for element in newList:
        print(element)
