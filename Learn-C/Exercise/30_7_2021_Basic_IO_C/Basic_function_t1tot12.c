#include <stdio.h>
#include <conio.h>
int num1(){
	printf("Hello World\n");
	getch();
	return 0;
}

int num2(){
	int i=7;
	printf("%d",i);
	getch();
	return 0;
}

int num3(){
	float i=8.23;
	printf("%f",i);
	getch();
	return 0;
}

int num4(){
	float i=8.23;
	printf("%.2f",i);
	getch();
	return 0;
}

int num5(){
	printf("Hello World\n");
	printf("SPPK");
	getch();
	return 0;
}

int num6(){
	char c2='a';
	printf("%c",c2);
	getch();
	return 0;
}

int num7(){
	int i=5,j=10,sum=0;
	sum = i+j;
	printf("TOTAL = %d",sum);
	getch();
	return 0;
}

int num8(){
	int i=500,j=100,sum=0;
	sum=i-j;
	printf("TOTAL = %d", sum);
	getch();
	return 0;
}

int num9(){
	int i=8,j=6,sum=0;
	sum=i*j;
	printf("TOTAL = %d", sum);
	getch();
	return 0;
}

int num10(){
	float i=5,j=10,sum=0;
	sum=i/j;
	printf("TOTAL = %f", sum);
	getch();
	return 0;
}

int num11(){
	int x, y;
	printf("Enter two integers\n");
	scanf("%d%d",&x,&y);
	x=x+3;
	y=5*y;
	printf("x = %d\ny = %d", x,y);
	return 0;
}

int num12(){
		int a,b,c,d;
	a=2;
	b=3;
	b += a;
	c = b%a+a;
	c++;
	d = (c+a) * (a/b);
	printf("Values of variables after calculate are :: \n");
	printf("a:%d\n", a);
	printf("b:%d\n", b);
	printf("c:%d\n", c);
	printf("d:%d\n", d);
	getch();
	return 0;
}
int main(){
	printf("\n\nnum1\n---------------\n");
	num1();
	printf("\n\nnum2\n---------------\n");
	num2();
	printf("\n\nnum3\n---------------\n");
	num3();
	printf("\n\nnum4\n---------------\n");
	num4();
	printf("\n\nnum5\n---------------\n");
	num5();
	printf("\n\nnum6\n---------------\n");
	num6();
	printf("\n\nnum7\n---------------\n");
	num7();
	printf("\n\nnum8\n---------------\n");
	num8();
	printf("\n\nnum9\n---------------\n");
	num9();
	printf("\n\nnum10\n---------------\n");
	num10();
	printf("\n\nnum11\n---------------\n");
	num11();
	printf("\n\nnum12\n---------------\n");
	num12();
}
