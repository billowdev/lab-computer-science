#include<stdio.h>
int main()
{
	char grade;
	printf("Please input your Grade\nEx: A,B,C,D and F\n");
	printf("__________________\n\n");
	scanf("%c",&grade);
	printf("__________________\n\n");
	switch(grade){
		case'A':
			printf("Excellent\n");
			break;
		case'B':
		case'C':
			printf("Well Done\n");
			break;
		case'D':
			printf("You passed\n");
			break;
		case'F':
			printf("Better try again\n");
			break;
		default:
			printf("Invalid Grade\n");
		
	}
	printf("Your Grade is %c\n",grade);
	return(0);
}
