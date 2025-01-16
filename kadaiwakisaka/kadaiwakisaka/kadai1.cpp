#include<stdio.h>


int main(void)
{
	int yousogata[5] = {0,1,2,3,4};
	int youso = 5;
	int youso2 = 5;
	for (int i = 0; i < youso2; i++)
	{
		youso += yousogata[i];
		printf("%d\n", youso);
		
	}
	return 0;
}