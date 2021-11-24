import math

current = 1.0
previous = 0.0

while abs(current - previous) > 0.000001:
	previous = current
	current = (2 - previous**2)/5
print(current)
