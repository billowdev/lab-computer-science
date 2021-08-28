//023_prog9.4.cpp
#include<stdio.h>
main()
{
	int age;
	printf("How old are you? : ");
	scanf("%d", &age);
	
	if(age<18){
		printf("You are less than 18 years old \n");
		printf("You are young \n");
	}
	
	printf("\n You are %d years old",age);
	return 0;
}
