#include<stdio.h>
int main()
{
	int a,b;
	a=9,b=30;
	if(a&&b){
		printf("Line-1 condition is true\n");
	}
	if(a||b){
		printf("Line-2 condition is true\n");
	}
	a=0,b=20;
	if(a&&b){
		printf("Line-3 condition is true\n");
	}
	else{
		printf("Line-3 condition is false\n");
	}
	if(!a&&b){
		printf("Line-4 condition is true\n");
	}
	return(0);
	/*
	Output are :
	Line-1 condition is true
	Line-2 condition is true
	Line-3 condition is false
	Line-4 condition is true
	*/
}
