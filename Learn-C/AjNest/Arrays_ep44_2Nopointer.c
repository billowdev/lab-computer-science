#include<stdio.h>
long add(int n1,int n2,int n3,int n4,int n5);

void main(void)
{
	int a[5]={1,1,1,1,1};
	int b[5]={2,2,2,2,2};
	int c[5]={3,3,3,3,3};
	long sum_a;
	long sum_b;
	long sum_c;
	sum_a = add(a[0],a[1],a[2],a[3],a[4]);
	sum_b = add(b[0],b[1],b[2],b[3],b[4]);
	sum_c = add(c[0],c[1],c[2],c[3],c[4]);
	printf("sum a=%lu\n",sum_a);
	printf("sum_b=%lu\n",sum_b);
	printf("sum c=%lu\n",sum_c);
}
long add(int n1,int n2,int n3,int n4,int n5)
{
	int i;
	long sum=0;
			sum = n1+n2+n3+n4+n5;
		return (sum);
}
