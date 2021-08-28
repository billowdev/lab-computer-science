#include <stdio.h>
int main()
{
	int a = 20;
	int b,c,d;
	float k = 2.9898989,z;
	char m = 'A',n = 'y';
	b = 99;
	c = a;
	d = a+15;
	z = b+k;
	
	printf("Output a = %d\n",a);
	printf("Output b = %d\n",b);
	printf("Output c = %d\n",c);
	printf("Output d = %d\n",d);
	printf("Output z = %f\n",z);
	printf("Output Text = %c|%d|%f|%c",m,b,k,n);
	return(0);
}
