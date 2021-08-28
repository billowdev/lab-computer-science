#include<Stdio.h>
int main()
{
	int a=20;
	int b=10;
	int c=15;
	int d=5;
	int e;
	e=(a+b) * c/d;
	// (20+10)*15/5 output = 90
	printf("value c is %d\n",e);
	
	e=((a+b)*c)/d;
	printf("value c is %d\n",e);
	
	e=(a+b)*(c/d);
	printf("value c is %d\n",e);
	
	e=a+(b*c)/d;
	printf("value &c is %d\n",e);
	return(0);
	
}
