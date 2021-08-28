// 002__define1
#include<stdio.h>
#define NAME "Akkarapon"
#define NUM1 500
#define NUM2 NUM1 - 200
#define SUM(x,y) x + y
main()
{
	printf("My name is %s \n",NAME);
	printf("Num1 = %d \n", NUM1);
	printf("Num2 = %d \n",NUM2);
	printf("Sum = %d\n",SUM(40,10));
	return(0);
}
