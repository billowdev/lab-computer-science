#include<stdio.h>
int g;//global varriavles
int main()
{
	int a,b;
	a=30;
	b=60;
	g=a+b;
	printf("Value of a is %d b is %d and g is %d\n",a,b,g);
	return(0);
}

