#include<stdio.h>
long add(int *num);
void main(void)
{
	int a[5]={1,1,1,1,1};
	int b[5]={2,2,2,2,2};
	int c[5]={3,3,3,3,3};
	long sum_a;
	long sum_b;
	long sum_c;
	
	sum_a = add(a);
	sum_b = add(b);
	sum_c = add(c);
	printf("sum_a = %lu\n",sum_a);
	printf("sum_b = %lu\n",sum_b);
	printf("sum_c = %lu\n",sum_c);
}
long add(int *num)
{
	int i;
	long sum = 0;
	for(i=0;i<5;i++)
	{
		sum = sum + num[i];	
	}
	return(sum);
}


