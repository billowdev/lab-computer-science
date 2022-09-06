#include<stdio.h>
int main() {
	// declare variable statement
	int count = 0;
	float num = 0.0, total = 0.0, avg;
	// process statement
	printf("***** Input Data ***** \n\n");
	do{
		printf(" Enter float number %d: ", count+1);
		scanf("%f", &num);
		total += num;
		count++;
	} while(count < 5);
	avg = total /5;
	printf("\n Result ");
	printf(" Average = %f", avg);
	
	
	return 0;
}
