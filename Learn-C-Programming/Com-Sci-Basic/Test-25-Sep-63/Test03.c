#include<stdio.h>
int main()
{
	int menu;
	float d1, d2, AreaT, width, length, AreaR;
	do{
		printf("\n\t\t***Menu***\n");
		printf("\n\t1.Area of the rhomboid\n");
		printf("\n\t2.Area of the ractangle\n");
		printf("\n\t3.Exit program");
		printf("\n\t\tSelect menu 1 or 2 or 3 : ");
		scanf("%d", &menu);
		
		if(menu==1)
		{
			printf("\n\t\t-----------------\n");
			printf("\n\tYou are select menu 1 \n");
			printf("\n\t\t-----------------\n");
			printf("\n\tInput diagonal 1 : ");
			scanf("%f", &d1);
			printf("\n\tInput diagonal 2 : ");
			scanf("%f", &d2);
			AreaT = 0.5 * (d1*d2);
			printf("\n\t\t-----------------\n");
			printf("\n\tArea of the right rhomboid is %.2f\n", AreaT);
			printf("\n\t\t-----------------\n");
			
		}
		
		else if(menu==2)
		{
			printf("\n\t\t-----------------\n");
			printf("\n\tYou are select menu 2 \n");
			printf("\n\t\t-----------------\n");
			printf("\n\tInput width : ");
			scanf("%f", &width);
			printf("\n\tInput length : ");
			scanf("%f", &length);
			AreaR = width * length;
			printf("\n\t\t-----------------\n");
			printf("\n\tArea of the rectangle is %.2f\n", AreaR);
			printf("\n\t\t-----------------\n");
			
		}
		
		else if(menu==3)
		{
		
			printf("\n\t\t-----------------\n");
			printf("\n\tYou are select menu 3 \n");
			printf("\n\t\t-----------------\n");
			printf("\n\t Select exit program \n");
			printf("\n\t\t-----------------\n");
		}
		
		else
		{
			printf("\n\t\t-----------------\n");
			printf("\n\tSelect wrong menu !!! \n");
			printf("\n\t\t-----------------\n");
		}
	}while(menu!=3);
}
