# Exsample ผลการทดสอบ คำสั่ง elif
score = int(input("Input Score: "))
"""
score = int(input("Input Your Score:" ))
if score > 8:
    print("Good")
else:
    if score > 4:
        print("Passed")
    else:
        print("Failed")
"""
if score > 8:
    print("Good")
elif score > 4:
    print("Passed")
else:
    print("Failed")