//ep.40
#include<stdio.h>
int main()
{
	int n[10];
	int j,i;
	for(i=0;i<=10;i++)
	{
		n[i]= i+200;
	}
	for(j=0;j<10;j++)
	{
		printf("Element[%d]=%d\n",j,n[j]);
	}
	printf("Select n[6]=%d\n",n[6]);
	return(0);
}
