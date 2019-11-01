text_one = input().lower()
text_two = input().lower()

if len(text_one) != len(text_two):
    print(0)

text_one = sorted(text_one).strip()
text_two = sorted(text_two).strip()

isAnagram = True

for index in range(0, len(text_one)):
    if text_one[index] != text_two[index]:
        isAnagram = False
        break

if isAnagram:
    print(1)
else:
    print(0)
