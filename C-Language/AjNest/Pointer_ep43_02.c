//example intro 2 
//ep43 02
#include<stdio.h>
int main()
{
	int var=20;
	int *ip;
	ip = &var;
	printf("Address of var varriable: %x\n",&var);
	printf("Address stared ip varribe : %x\n",ip);
	printf("Value of *ip varriable : %d\n",*ip);

}
