#include<stdio.h>
int main()
{
	int a=10;
	do{
		printf("Value of a is %d\n",a);
		a+=1;
	}while(a<20);
	
	printf("\nFinal a value is %d\n",a);
	return(0);
}
