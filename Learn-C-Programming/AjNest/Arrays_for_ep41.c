#include<stdio.h>
int main()
{
	int a[5][2]={{0,0},{1,2},{2,4},{3,6},{4,8}};
	int i,j;
	for(i=0;i<5;i++)
	{
		for(j=0;j<2;j++)
	{
		printf("a[%d][%d]=%d\n",i,j,a[i][j]);
	}
	}
	printf("select n[3][1]=%d\n",a[3][1]);
	return(0);
}
