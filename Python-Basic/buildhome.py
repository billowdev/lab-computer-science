import turtle

def build_walls(turtle,size):
	for i in range(4):
		turtle.forward(size)
		turtle.right(90)

def build_roof(turtle,size):
	turtle.left(60)
	turtle.forward(size)
	turtle.right(120)
	turtle.forward(size)
	turtle.right(120)
	turtle.forward(size)
	turtle.right(180)

def build_house(turtle,size):
	build_walls(turtle,size)
	build_roof(turtle,size)

t=Turtle()
build_house(t,300)

