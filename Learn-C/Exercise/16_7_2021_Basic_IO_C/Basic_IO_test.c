#include <stdio.h>
#include <conio.h>

int main()
{
	float num1,num2,num3,num4;
	
 	printf("Enter num1: ");
 	scanf("%f",&num1);
 	printf("Enter num2: ");
 	scanf("%f",&num2);
 	printf("Enter num3: ");
 	scanf("%f",&num3);
 	printf("Enter num4: ");
 	scanf("%f",&num4);
 	
 	printf("\nNumber 1: %.2f\n",num1);
 	printf("Number 2: %.2f\n",num2);
 	printf("Number 3: %.2f\n",num3);
 	printf("Number 4: %.2f\n",num4);
 	
 	float sum =  num1+num2+num3+num4;
 	
	printf("\nSummation is : %.2f\n", sum);
 	printf("Average is : %.3f\n", sum/4 );
    return 0;
}