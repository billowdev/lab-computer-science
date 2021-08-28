//011_prog7_6.cpp
#include <stdio.h>
main()
{
	char id[15], name[20];
	float gpa;
	printf("Input your ID : ");
	
	scanf("%s", &id);
	printf("Input your Name: ");
	scanf("%s", &name);
	printf("Input your GPA:");;
	scanf("%f", &gpa);
	printf("\n######################################\n");
	printf("# ID \t\tName \t\tGPA#\n");
	printf("\n######################################\n");
	printf("\n # %s \t %s \t%.2f# \n",id,name,gpa);
	printf("\n######################################\n");
	return 0;
	
}
