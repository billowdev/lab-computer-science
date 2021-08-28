#include<stdio.h>
void Addition(); //Function Declaration
void main()
{
	int a,b;

	printf("Please Enter two integer values\n");
	scanf("%d %d",&a,&b);
	Addition(a,b);
}
void Addition(int a,int b)//Calling a Function
{
	int	sum = a+b;
	printf("\nAddition of %d and %d is %d",a,b,sum);
		
}
