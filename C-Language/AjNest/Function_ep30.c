#include<stdio.h>
int Multiplication();
int main()
{
	int Multi;
	Multi=Multiplication();
	printf("\nMultiplication of a and b is %d\n",Multi);
	return(0);
}
int Multiplication()
{
	int Multi,a=20,b=10;
	Multi = a*b;
	return Multi;
}
