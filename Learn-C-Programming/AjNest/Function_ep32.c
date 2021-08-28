#include<stdio.h>
int Multiplication(int,int);
int main()
{
	int a,b,Multi;
	printf("Please enter two integer values: \n");
	scanf("%d %d",&a,&b);
	Multi = Multiplication(a,b);
	printf("\nMultiplication of %d and %d is %d",a,b,Multi);
	return (0);
	
}
int Multiplication(int a,int b)
{
	int Multi;
	Multi = a*b;
	return(Multi);
}
