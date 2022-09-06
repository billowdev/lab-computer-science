#include<stdio.h>
int main() {
	// declare variable statement
	int i = 30;
	// process statement
	while(i >= 15){
		printf("%3d", i);
		if(i == 25) {
			i = i - 5;
			continue;
		}
		i--;
	}	
	return 0;
}
