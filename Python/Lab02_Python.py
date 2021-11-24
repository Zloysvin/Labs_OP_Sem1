print("R1")
R1 = int(input())
print("R2")
R2 = int(input())
print("X")
X = int(input())
print("Y")
Y = int(input())
dist = X*X + Y*Y

if dist >= R1*R1 and dist <= R2*R2:
	print("point is in the circle")
else:
	print("point is out of the circle")	
