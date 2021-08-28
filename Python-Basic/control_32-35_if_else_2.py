"""
เขียนโปรแกรมที่อ่านจำนวนเต็มหนึ่งจำนวนแล้วระบุว่า
จำนวนเต็มดังกล่าวเป็นจำนวนเต็มบวก จำนวนเต็มลบ หรือศูนย์
x > 0
x == 0
x < 0

"""
x = int(input("Enter an integer: "))
if x > 0:
    print("A positive integer")
else:
    if x < 0:
        print("A negative integer")
    else:
        print("A zero")
#สังเกตว่าเราใช้คำสั่ง if ภายในบล็อคของคำสั่ง if อีกคำสั่งหนึ่ง
