//017_prog8_3.cpp
#include<stdio.h>
main()
{
	char name[15];
	int age;
	float weight, height;
	printf("\t *** Input Data ***\n");
	
		printf("Input your name: ");
		scanf("%s",name);
		
			printf("Input your age");
			scanf("%d", &age);
			
				printf("Input your weight");
				scanf("%f", &weight);
				
					printf("Input your height");
					scanf("%f", height);
	
	printf("\n\t *** Output your Data ***\n");
	
	printf("Name is %s\n", name);
	printf("Age is %d", age);
	printf("Weight is %.2f\n", weight);
	printf("Height is %.2f\n", height);
	
	return 0;
	
}
