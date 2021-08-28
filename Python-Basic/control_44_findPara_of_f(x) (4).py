"""
จงเขียนส่วนของโปรแกรมที่หาค่าของฟังก์ชันที่กำหนดให้ต่อไปนี้
        | 2x+10,  x ≤  5
f(x) =  | x2+10,  5 < x ≤  20
        | x-10,   20 < x < 30
        | 3x,  x ≥ 30
"""
x = int(input("Input x for find function: "))
def f(x):
    if x <= 5:
        print("F(x)= 2x+10 when x<= 5 \n equal: ",2 * (x) + 10)
    elif 5 < x <= 20:
        print("F(x) = x2+10 when 5 < x ≤  20 \n equal: ",((x) * 2) + 10)
    elif 20 < x < 30:
        print("F(x) = x-10 when 20 < x < 30 \n equal: ",x - 10)
    else:
        print("F(x) = 3x when x ≥ 30 \n equal: ",3*x)
f(x)