"""
คำสั่งเงื่อนไขแบบซ้อน (nested if)
เราสามารถเขียนคำสั่ง if ซ้อนอยู่ในคำสั่ง if อีกทีได้
ตัวอย่างโปรแกรมตรวจสอบเลขบวก เลขลบ หรือศูนย์ แบบใช้ if – elif - else

"""
n=int(input("input integer: "))
if (n>0):
    print("it is positive number")
elif (n<0):
    print("it is negative number")
else:
    print("It is zero number")