//012_prog7_7.cpp

#include<stdio.h>
main()
{
	float Area, Wide, Height;
	printf("Input wide of rectangle :");
	scanf("%f", &Wide);
	printf("Input height of rectangle:");
	scanf("%f",&Height);
	Area = Wide * Height;
	printf("\nArea of rectangle is %.5f", Area);
	return 0;
}
