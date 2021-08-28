#include<stdio.h>
main()
{	
	float a,b,result;
	int num;
	int p;
	printf("Enter your first number  :  ");
	scanf("%f",&a);
	printf("Enter your second number :  ");
	scanf("%f",&b);
	printf("Please Select Operater \n");
	printf("Press 1 for + \n");
	printf("Press 2 for - \n");
	printf("Press 3 for * \n");
	printf("Press 4 for / \n");
	printf("Press 5 for %% \n");
	
	printf("\n\t Please Select : ");
	scanf("%d",&p);
	switch(p){
	
		case(1):
			result = a+b;
			printf("%f",result);
			break;
		case(2):
			result = a-b;
			printf("%f",result);
			break;
		case(3):
			result = a*b;
			printf("%f",result);
			break;
		case(4):
			result = a/b;
			printf("%f",result);
			break;
		
			
	
	
	}
	
	
}
