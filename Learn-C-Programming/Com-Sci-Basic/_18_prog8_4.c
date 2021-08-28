//018_prog8_4.cpp
#include<stdio.h>
main()
{
	char Bbrand[15];
	float Bprice,Bpay,Payback;
	
	printf("\t *** Input Data ***\n");
	
		printf("Input brand of bicycle: ");
		scanf("%s", &Bbrand);
		
			printf("Input price of bicycle: ");
			scanf("%f", &Bprice);
			
				printf("Input your pay : ");
				scanf("%f", &Bpay);
	
	Payback = Bpay - Bprice;
	printf("\n\t *** Output Data *** \n");
	printf("You can receive money is %.2f\n",
		Payback);
		
	return 0;
}
