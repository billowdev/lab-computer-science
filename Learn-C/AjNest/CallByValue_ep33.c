#include<stdio.h>
void callbyvalue(int,int);
int main()
{
	int a,b;
	printf("Please input two integer\n");
	scanf("%d%d",&a,&b);
	printf("\nBefore calling callbyvalue() Funtion a=%d and b=%d\n",a,b);
	callbyvalue(a,b);
	printf("\n After calling callbyvalue() Function a=%d and b=%d\n",a,b);
	return (0);		
}
void callbyvalue(int a,int b)
{
	a=a*10;
	b=b*20;
	printf("\nFrom Function callbyvalue() function a=%d and b=%d\n",a,b);
	
}
