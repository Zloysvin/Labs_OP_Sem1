def H(a, b):
 	return a/(1 + b ** 2) + b/(1 + a ** 2) - (a - b) ** 3

def max(a, b):
	if a > b:
		return a
	else:
		return b


s = float(input())
t = float(input())

F = H(s, t) + max(H(s - t, s * t) ** 2, H(s - t, s + t) ** 4) + H(1, 1)
print(F)
