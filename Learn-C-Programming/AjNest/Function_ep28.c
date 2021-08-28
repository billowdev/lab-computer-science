#include<stdio.h>
int max(int num1,int num2);
int main()
{
	int a;
	int b;
	
	printf("Please input your a number\n");
	scanf("%d",&a);
	printf("Please input your b number\n");
	scanf("%d",&b);
	
	int output;
	output = max(a,b);
	printf("Max value is %d\n",output);
	return(0);
}
int max(int num1,int num2){
	int result;
	if(num1>num2)
	result=num1;
	else
	result=num2;
	return result;
}

