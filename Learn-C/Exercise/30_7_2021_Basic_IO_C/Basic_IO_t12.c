#include <stdio.h>
#include <conio.h>

int main(){
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