//022_prog9.3.cpp
#include<stdio.h>
main()
{
	int points;
	printf("Enter your examination points : ");
	scanf("%d",&points);
	
	if(points >= 50)
		printf("points >= 50");
	else
		printf("\n You didn't passed, Sorry try again !!! \n'");
	return 0;
}
