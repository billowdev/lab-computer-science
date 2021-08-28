
def read_base():
	b = input("Enter base: ")
	return int(b)

def read_height():
	h = input("Enter height: ")
	return int(h)

def compute_area(base,height):
    return 0.5*base*height

def show_area(area):
	print("Triangle area is", area)

b = read_base()
h = read_height()
a = compute_area(b,h)
show_area(a)