def generate(size, result, count_open_brace, count_close_brace):
    if count_open_brace + count_close_brace == 2 * size:
        print(result)
    if count_open_brace < size:
        generate(size, result + '(', count_open_brace + 1, count_close_brace)
    if count_open_brace - count_close_brace > 0:
        generate(size, result + ')', count_open_brace, count_close_brace + 1)

size = int(input())
output = ''
generate(size,output, 0, 0)
