#include<stdio.h>
void Swap(int*,int*);
int main()
{
	int a,b;
	printf("Please Enter two integer values\n");
	scanf("%d %d",&a,&b);
	printf("\nBefore Swap a = %d and b = %d",a,b);
	Swap(&a,&b);
	printf("\n After Swap Function a=%d and b=%d",a,b);
	return(0);

}
void Swap(int*x,int*y)
{
	int Temp;
	Temp = *x;
	*x = *y;
	*y = Temp;
//	printf("\nAfter Swaping from UDF a = %d and b = %d",*x,*y);
	
}
