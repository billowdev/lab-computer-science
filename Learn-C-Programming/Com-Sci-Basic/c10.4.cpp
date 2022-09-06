#include<stdio.h>
int main() {
	// declare variable statement
	int x, y, check;
	// process statement
	printf("Prime number between 1 to 100 is\n\n...");
	for (x=1; x <= 100; x++){
		check = 1;
		for(y=2; y<x; y++){
			if (!(x%y)){
				check=0;
			}
		}	
		if(check){
			printf("%d \t", x);
		}
	}
	return 0;
}
