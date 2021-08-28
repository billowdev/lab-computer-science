#include<stdio.h>
int main()
{
	int num;
	printf("Input score: \n");
	scanf("%d",&num);
	if(num>=90){
		printf("Grade:Exallent");
	}
	else if(num>=80&&num<90){
		printf("Grade:Very Good");
	}
	else if(num>=60&&num<80){
		printf("Grade:Good");
	}
	else if(num>=50&&num<60){
		printf("Grade:Average");
	}
	else if(num>=10&&num<50){
		printf("Grade:Poor");
	}
	else{
		printf("Grade:Not Promoted");
	}
	return(0);
}
