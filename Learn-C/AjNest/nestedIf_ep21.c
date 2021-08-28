#include<stdio.h>
int main()
{
		int number1=15,number2=10,number3=5,min;
		
		if(number1<number2)
		{
			if(number1<number3)
			min=number1;
			else(min=number3);
		}
		else
		{
			if(number2<number3)
			min=number2;
			else(min=number3);
		}
		printf("Among %d,%d,%d minimum number is %d\n",number1,number2,number3,min);
		
			
}
