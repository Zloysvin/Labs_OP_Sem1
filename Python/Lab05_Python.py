a = int(input())
b = int(input())
for i in range(a, b):
	sum = 0
	for j in range(1, i):
		if i%j == 0:
			sum+=j
	if sum == i:
		print(i)
