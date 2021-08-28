//005__prog6_2.cpp
#include<stdio.h>
main()
{
	int x = 20;
	int y =3;
	double z;
	z = x/y;
	printf("*** Not casting *** \n\n");
	printf("Result of z is : %f \n\n",z);
	z = (double)(x/y);
	printf("\n*** Casting result of x/y *** \n\n");
	printf("Result of z is : %f \n\n",z);
	z = (double)x/y;
	printf("\n *** Not casting result of x/y but casting value of x***\n\n");
	return(0);
}
