//003_struct2.c

#include "stdio.h"
#include "math.h"

void add(int, int);
int x,y=10;

main()
{
	x = pow(y, 4);
	add(x, 100);
}

void add(int a, int b)
{
	int z;
	z = a + b;
	printf("A = %d, B = %d, z = %d",a,b,z);
	getchar();
}
