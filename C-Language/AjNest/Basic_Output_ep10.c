#include<stdio.h>
int main()
{
	int a=69;
	int b=30;
	int c;
	c=a+b;
	
	printf("Operator1-value of c is %d\n",c);
	
	c=a-b;
	printf("Operator2-value of c is %d\n",c);
	
	c=a*b;
	printf("Operator3-value of c is %d\n",c);
	
	c=a/b;
	printf("Operator4-value of c is %d\n",c);
	
	c=a%b;
	printf("Operator5-value of c is %d\n",c);
	
	c = a++;
	printf("Operator6-value of c is %d\n",c);
	printf("%d\n",a);
	
	c = a--;
	printf("Operator6-2-value of c is %d\n",c);
	printf("%d\n",a);
	
	c = b++;
	printf("Operator7-value of c is %d\n",c);
	printf("%d\n",b);
	
	
	c = b--;
	printf("Operator7-value of c is %d\n",c);
	printf("%d\n",b);
	
	
	
	
}
