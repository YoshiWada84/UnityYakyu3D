#include<stdio.h>


int main(void)
{
	int yousogata[5] = { 4,3,2,1,0 };
	int youso = 5;
	int youso2 = 5;
	for (int i = 0; i < youso2; i++)
	{
		youso += yousogata[i];
		printf("%d\n", youso);
		
	}
	return 0;
}