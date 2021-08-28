#include<stdio.h>
 main()
{
			char name[30];
			int age;
		
			float GPA;
			
		
		
		printf("What is you name? : ");
		scanf("%s",&name);
		printf("Your name is %s \n", name);
		
		
		printf("How old are you ? : ");
		scanf("%d",&age);
		printf("Your age is %ld years old !\n",age);
		
		printf("What your grade ?\n");
		scanf("%f",&GPA);
		printf("Your grade is %.2f",GPA);
		
		return 0;
		
	
		
	
}
