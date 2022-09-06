#include<stdio.h>
int main() {
	// declare variable statement
	float key;
	int p=0,z=0,n=0,c=1;
	// process statement
	while(c <=10){
		printf("Enter a value %d: ", c);
		scanf("%f", &key);
		if(key < 0.0)
			n++;
		else if(key == 0.0)
			z++;
		else
			p++;
		c++;
	}
	printf("\n Negative = %d", n);
	printf("\n Positive = %d", p);
	printf("\n Zero = %d", z);	
	return 0;
}
