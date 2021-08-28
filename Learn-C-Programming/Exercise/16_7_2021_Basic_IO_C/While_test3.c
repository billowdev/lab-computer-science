#include <stdio.h>
int main() {
	
	int i=1;
	while (i<=10){
		if (i==1){
			printf("d\n");
			i+=1;
		}	
		if (i>1 && i<=10){
			printf("%d\n", i);
			i+=1;	
		}
	//	i+=1;
	}
		
	i=-10;

	while (i<=-1){
		printf("%d\n", i);
		i+=1;
		if (i==-1){
			printf("d");
			i+=1;
		}
			
	}	
}