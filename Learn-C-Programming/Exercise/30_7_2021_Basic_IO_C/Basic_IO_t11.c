#include <stdio.h>
#include <conio.h>

int main(){
	int x, y;
	printf("Enter two integers\n");
	scanf("%d%d",&x,&y);
	x=x+3;
	y=5*y;
	printf("x = %d\ny = %d", x,y);
	return 0;
}