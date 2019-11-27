text_one = input().lower().strip()
text_two = input().lower().strip()

if len(text_one) != len(text_two) and not(text_one.isalpha or text_two.isalpha):
    print(0)

text_one = sorted(text_one)
text_two = sorted(text_two)

isAnagram = True

for index in range(0, len(text_one)):
    if text_one[index] != text_two[index]:
        isAnagram = False
        break

if isAnagram:
    print(1)
else:
    print(0)