"""
แฟคตอเรียลของ n (เขียนแทนด้วย n!) มีนิยามคือ
1 x 2 x … x n,
หรือ 1 เมื่อ n = 0.
เขียนฟังก์ชัน fact(n) ที่คำนวณ n!.
ในการเริ่มต้น สามารถละเว้นไม่พิจารณากรณีที่ n = 0 ได้

"""
n=int(input("input n for calculate factorial: "))
def fact(n):
    i=1
    fac=1
    while i<=n:
        fac*=i
        i+=1
    print(fac)
fact(n)