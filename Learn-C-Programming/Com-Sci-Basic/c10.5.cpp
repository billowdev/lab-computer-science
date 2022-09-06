#include<stdio.h>
main() {
	// declare variable statement
	char ch;
	// process statement
	printf("Input character: ");
	scanf("%c", &ch);
	while(ch != 'z'){
		scanf("%c", &ch);
	}
	return 0;
}
