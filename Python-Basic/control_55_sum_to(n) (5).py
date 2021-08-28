"""
เขียนฟังก์ชัน sum_to(n) ทื่คำนวณและคืนค่า 1 + 2 + … + n.

ห้ามใช้สูตร n*(n+1)/2.

เราสามารถเริ่มต้นจากเขียนโปรแกรมที่คำนวณค่าดังกล่าว
แล้วค่อยเปลี่ยนให้เป็นฟังก์ชัน

def sum_to(n):
    i=0
    while i<=n:
        j=(n*n)
        j+=n
        i += 1
    print(j2)
"""
n=int(input("input n: "))
def sum_to(n):
    t = 0
    i = 1
    while i<=n:
        t += i
        i += 1
    print(t)
sum_to(n)

"""
def sum_to(n):
    total = 0
    i = 1
    
    while i <= n:
    total = total + 1
    i = i + 1
    return total
"""
