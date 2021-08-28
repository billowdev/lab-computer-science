#include<stdio.h>
int a=60;
int main()
{
	int a=30;
	int b=90;
	int c=0;
	printf("Value of a in main()=%d\n",a);
	c=sum(a,b);
	printf("Value of c in main()=%d",c);
	return(0);
}
int sum(int a,int b)
{
	printf("Value of a in sum() = %d\n",a);
	printf("Value of b in sum() = %d \n",b);
	return(a+b);
}
