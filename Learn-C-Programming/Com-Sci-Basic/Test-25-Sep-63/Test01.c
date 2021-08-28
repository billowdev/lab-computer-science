#include<stdio.h>
int main()
{

	float sum,width,height,length,AreaT,AreaR;
	int menu;
	do{
		printf(" \n\t\t *** Menu *** \n");
		printf("\n\t1.Area of the trapezium\n");
		printf("\n\t2.Area of the rectangle\n");
		printf("\n\t3.Exit program\n");
		printf("\n\tSelect menu 1 or 2 or 3: ");
		scanf("%d", &menu);
		
		if (menu==1)
		{
			printf("\n\t\t*** You are select menu 1 ***\n");
			printf("\n\tInput Sum of parallel sides : ");
			scanf("%f", &sum);
			printf("\n\tInput height : ");
			scanf("%f", &height);
			AreaT = 0.5 * sum * height;
			printf("\n\tArea of the trapezium is %.2f\n",AreaT);
			printf("\n\t\t\t---------\n");
		}	
		
		else if (menu==2)
		{
			printf("\n\t\t*** You are select menu 2 ***\n");
			printf("\n\tInput width : ");
			scanf("%f", &width);
			printf("\n\tInput length : ");
			scanf("%f", &length);
			AreaR = width * length;
			printf("Area of the ractangle is %.2f\n", AreaR);
			printf("\n\t\t\t---------\n");
		}
		
		else if (menu==3)
		{
			printf("\n\t\t*** You are select menu 3 ***\n");
			printf("\n\t Select exit program\n");
			
		}
		
		else
		{
			printf("\n\t\t---------\n");
			printf("\n\t *** Select wrong menu !!! \n");
			printf("\n\t\t---------\n");
		}
		
	} while(menu!=3);
	return 0;
}
