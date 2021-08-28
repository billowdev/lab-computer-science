#include<stdio.h>
int main()
{
	int a=9;
	int c;
	c=a;
	printf("line-1 value &c = %d\n",c);
	c+=a;
	printf("line-2 value &c = %d\n",c);
	c-=a;
	printf("line-3 value &c = %d\n",c);
	c*=a;
	printf("line-4 value &c = %d\n",c);
	c/=a;
	printf("line-5 value &c = %d\n",c);
	c=200;
	c%=a;
	printf("line-6 value &c = %d\n",c);
	c<<=2;
	printf("line-7 value &c = %d\n",c);
	c>>=2;
	printf("line-8 value &c = %d\n",c);
	c&=2;
	printf("line-9 value &c = %d\n",c);
	c^=2;
	printf("line-10 value &c = %d\n",c);
	c|=2;
	printf("line-11 value &c = %d\n",c);
}
