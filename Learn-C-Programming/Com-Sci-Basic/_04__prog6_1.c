//004__prog6_1.cpp
#include<stdio.h>
main()
{
	char a = 'A';
	int b = 50;
	float c = 345.0;
	double d = 78.2593;
	
	printf("*** Before Implicit Type Conversion *** \n\n");
	printf("Charater is %c \n",a);
	printf("Numeric charater is %d \n",a);
	printf("Integer is %d \n",b);
	printf("Floating is %f \n",c);
	printf("Double is %f \n", d);
	b = b+a;
	c = c+a;
	d = d+a;
	printf("\n *** After Implicit Type Conversion ***\n\n");
	printf("Character is %c \n",a);
	printf("Numeric character is %d\n",a);
	printf("Integer is %d\n",b);
	printf("Floating is %f\n",c);
	printf("Double is %f\n",d);
	return(0);
	
}
