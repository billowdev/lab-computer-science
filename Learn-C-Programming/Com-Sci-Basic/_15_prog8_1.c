//015_prog8_1.cpp
#include<stdio.h>
main()
{
	int num1,num2,num3,num4,num5,total;
	
	printf("\t *** Input Data ***\n");
	
		printf("Input integer number 1 :");
			scanf("%d",&num1);
		
		printf("Input integer number 2 :");
			scanf("%d",&num2);
		
			printf("Input integer number 3 :");
				scanf("%d",&num3);
			
				printf("Input integer number 4 :");
					scanf("%d",&num4);
				
					printf("Input integer number 5 :");
						scanf("%d",&num5);
		
	total = num1+num2+num3+num4+num5;
	
	printf("\n\t ***Output Data ***\n");
	printf("Total of 5 numbers is %d \n", total);
	return 0;
}
