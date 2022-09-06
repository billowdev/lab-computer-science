#include<stdio.h>
int main() {
	// declare variable statement
	int num;
	// process statemen      
	// num = num - 5  or num-=5
	for (num=100; num >= 60; num-=5){
		printf("%5d", num);
	}
	return 0;
}
