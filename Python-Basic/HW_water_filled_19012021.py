import math

def caltimewater(diameter, height, flowrate):
    diameter = diameter*2.54
    height = height*2.54
    redius=diameter/2

    print("---------------")
    print("Diameter =",diameter,"cm")
    print("Height ",height,"cm")
    print("Redius",redius,"cm")

    def volume(redius,height):
        v = math.pi*(pow(redius, 2))*height
        return v

    volume=volume(redius,height)
    global time
    time = volume/flowrate # convert second to minutes
    time = time/60
    return time

diameter=float(input("Enter your Diameter(inch):"))
height=float(input("Enter your Height(inch): "))
flowrate=float(input("Enter your Flow rate (cc/second): "))
caltimewater(diameter, height, flowrate)
print("use time",time,"minutes")


