#include<stdio.h>
int main()
{
	unsigned a=60;//0011 1100
	unsigned b=13;//0000 1101
	int c=0;
	c = a&b;
	printf("Line1-Value &c is %d\n",c);
	c=a|b;
	printf("Line2-Value &c is %d\n",c);
	c=a^b;
	printf("Line3-Value &c is %d\n",c);
	c=~a;
	printf("Line4-Value &c is %d\n",c);
	c=a<<2;
	printf("Line5-Value &c is %d\n",c);
	c=a>>2;
	printf("Line6-Value &c is %d\n",c);
	return(0);
}
