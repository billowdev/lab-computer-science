#include<stdio.h>
int main()
{
	float Base,Height;
	float volume;
	
	
	
	printf("Please input Base Value: ");
	scanf("%f",&Base);
	
	printf("Please input Height value: ");
	scanf("%f",&Height);
	//0.333333333 or 1/3
	volume =  0.333333333 * Base * Height;

	printf("Volume of pyramid is %f", volume);
	return 0; 
}
