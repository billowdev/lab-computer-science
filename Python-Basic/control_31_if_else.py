"""
จงเขียนส่วนของโปรแกรมที่ใช้ในตรวจสอบคะแนนของนักเรียน
ว่าผ่านการทดสอบหรือไม่

"""
def score(s):
    if s<50:
        print("You faield.")
    else:
        print("You passed")

sc = int(input("Input Your score: "))
score(sc)