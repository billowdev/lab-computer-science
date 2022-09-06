#include<stdio.h>
int main() {
	// declare variable statement
	int i=20;
	// process statement
	while (i <= 20){
		printf("%3d", i);
		if ( i == 12) break;
		i--;
	}
	return 0;
}
