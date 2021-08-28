//016_prog8_2.cpp
#include<stdio.h>
main()
{
	char Bbrand[15],Bseries[10],Bcolor[7];
	float Bprice;
	printf("\t *** Input Data *** \n");
	
		printf("Input brand of bicycle : ");
		scanf("%s",Bbrand);
		
			printf("Input series of bicycle : ");
			scanf("%s",Bseries);
			
				printf("Input color of bicycle : ");
				scanf("%s",Bcolor);
				
					printf("Input price of bicycle : ");
					scanf("%f",&Bprice);
	
	printf("\n\t *** Output Data of Bicycle ***\n");
	
	printf("Brand is %s \n",Bbrand);
	printf("Series is %s \n",Bseries);
	printf("Color is %s \n",Bcolor);
	printf("Price is %.2f \n",Bprice);
	
	return 0;
}
