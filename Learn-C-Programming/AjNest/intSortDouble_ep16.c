#include<stdio.h>
int main()
{
	int a=6;
	short b;
	double c;
	int* ptr;
	//"sizeof" it will tell size of variable to you
	printf("Line-1 size of a = %d \n",sizeof(a));
	printf("Line-2 size of b = %d\n",sizeof(b));
	printf("Line-3 size of c = %d\n",sizeof(c));
	ptr = &a;
	
	printf("Value of a is %d\n",*ptr);
	a=8;
	


	b=(a==8)?20:30;
	printf("Value of b is %d\n",b);
	
	/*	b=(a==8)?20:30;	it like 

	b=(a==8);
	if(b=8){
			printf("Value b is %d\n",20);
			}
	else{
		printf("Value b is %d\n",30);
		}
	*/
	
	return(0);
}
