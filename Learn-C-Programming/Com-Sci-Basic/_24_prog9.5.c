//024_prog9.5.cpp
#include<stdio.h>
main()
{
	int choice;
	float radius, circum, area;
	printf("\n 1. Circumference of the circle \n");
	printf("\n 2. Area of the circle \n");
	printf(" Enter your choice 1 or 2 :");
	scanf("%f", &radius);
		
		if(choice ==1)
		{
			circum = 2 * 3.14159 * radius;
			printf("\n Circumference of the circle = %f \n",circum);
		}
		else
		{
			area = 3.14159 * radius * radius;
			printf("\n Area of the circle = %f\n", area);
			
		}
		return 0;
}
