//025_prog9.6.cpp
#include<stdio.h>
main()
{
	int x,y;
	printf("Enter an integer of X : ");
	scanf("%d",&x);
	printf("Enter an integer of Y : ");
	scanf("%d",&y);
	
		if(x==y)
				printf("\n X equal to Y = %d\n",x);
		else
				printf("\nX = %d not equal to Y = %d\n", x, y);
	return 0;
}
