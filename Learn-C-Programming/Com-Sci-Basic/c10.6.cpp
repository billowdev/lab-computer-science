#include<stdio.h>
int main() {
	// declare variable statement
	int count = 0;
	// process statement
	printf("\t\t *** Show number from 0 to 10 ***\n\n");
	while(count <= 10){
		printf("%5d", count);
		count++;
	}
	return 0;
}
