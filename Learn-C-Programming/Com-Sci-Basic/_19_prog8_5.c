//019_prog8_5.cpp
#include<stdio.h>
main()
{
	float sum_pair,height,area;
	printf("\t *** Input Data ***\n");
	
		printf("Input summation of pair of parallel : ");
		scanf("%f", &sum_pair);
		
			printf("Input height of trapezoid : ");
			scanf("%f", &height);
	
	area = 0.5 * sum_pair * height;
	
	printf("\n \t *** Output Data *** \n");
	printf("Area of trapezoid is %.2f \n", area);
	
	return 0;
}
