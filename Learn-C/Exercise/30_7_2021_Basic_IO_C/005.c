#include<stdio.h>
int main()
{
	float price = 54000;
	float onsale = (price * 20 )/100;
	float result = price - onsale;
	printf("result is %.3f", result);
	return 0;
	
}
