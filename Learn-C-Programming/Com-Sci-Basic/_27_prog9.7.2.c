//027_prog9.7.2.cpp
#include<stdio.h>
main()
{
	int points;
	printf("Please enter your points: ");
	scanf("%d", &points);
		if(points >=80){
			printf("\n Congratulations !!!\n");
			printf("\n Computer Programming and Algorithm subject \n");
			printf("\n You get grade A \n");
		}
		else if(points >= 70)
			printf("\n You get grade B \n ");
		else if(points >= 60)
			printf("\n You get grade C \n ");
		else if(points >= 50)
			printf("\n You get grade D \n ");
		else
			printf("\n You get grade F \n ");
		printf("\n See you again !!! Next course ");
		return 0;
}
