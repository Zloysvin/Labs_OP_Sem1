n = int(input())
k = 1.0
d = 1.0

for i in range(n):
	t = k + 1
	d*= k/t
	k+=2
print(d)
