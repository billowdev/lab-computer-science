"""
##ตัวอย่าง: ผลการสอบ (nested-if)##
คุณได้รับคะแนนการสอบ
ถ้าคะแนนมากกว่า 8 จะถือว่าได้คะแนนดี
ถ้าคะแนนมากกว่า 4 แต่น้อยกว่าเท่ากับ 8 คุณจะสอบผ่าน
ถ้าคะแนนน้อยกว่าหรือเท่ากับ 4, ถือว่าสอบตก

"""
score = int(input("Input Your Score:" ))
if score > 8:
    print("Good")
else:
    if score > 4:
        print("Passed")
    else:
        print("Failed")