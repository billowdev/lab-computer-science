//021_prog9.2.cpp
#include<stdio.h>
main()
{
	int age;
	
	printf("How old are you?: ");
	scanf("%d",&age);
	
	if(age<18)
		printf("You are young\n");
	printf("\nYou are %d years old",age);
	return 0;
	
}
