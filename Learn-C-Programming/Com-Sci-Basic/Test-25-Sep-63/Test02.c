#include<stdio.h>
int main()
{
	int menu;
	float height, base, d1, d2, AreaT, AreaR;
	do{	
		printf("\n\t\t*** Menu ***\n");
		printf("\n\t1.Area of the right triangle\n");
		printf("\n\t2.Area of the rhomboid\n");
		printf("\n\t3.Exit program");
		printf("\n\t\tSelect menu 1 or 2 or 3 : ");
		scanf("%d", &menu);
		
		if(menu==1)
		{
			printf("\n\tYou are select menu1 \n");
			printf("\n\tInput height : ");
			scanf("%f", &height);
			printf("\n\tInput base : ");
			scanf("%f", &base);
			AreaT = 0.5 * height * base;
			printf("\n\t\t------------\n");
			printf("Area of the right triangle is %.2f\n", AreaT);
			printf("\n\t\t------------\n");
		}
		else if(menu==2)
		{
			printf("\n\tYou are select menu2 \n");
			printf("\n\tInput diagonal 1 : ");
			scanf("%f", &d1);
			printf("\n\tInput diagonal 2 : ");
			scanf("%f", &d2);
			AreaR = 0.5 * (d1*d2);
			printf("\n\t\t------------\n");
			printf("\nArea of the rhomboid is %.2f\n", AreaR);
			printf("\n\t\t------------\n");
		}
		else if(menu==3)
		{
			printf("\n\tYou are select menu3 \n");
			printf("\n\tSelect exit program\n");
		}
		else
		{
			printf("\n\t\t------------\n");
			printf("Select wrong menu !!!");
			printf("\n\t\t------------\n");
		}
			
	}while(menu!=3);
	return 0;
}
