text_one = input()
text_two = input()

text_one = sorted(text_one)
text_two = sorted(text_two)

if text_one == text_two:
    print(1)
else:
    print(0)