#include<stdio.h>
int main() {
	// declare variable statement
	int num = 10;
	// process statement
	printf("\t *** Show number from 10 to 0 ***\n\n");
	do {
		printf("%5d", num);
		num--;
		// num-= 1
		// num = num - 1	
	} while(num >= 0);
	return 0;
}
