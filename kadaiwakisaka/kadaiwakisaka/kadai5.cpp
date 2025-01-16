#include<stdio.h>


int main(void)
{
	int yousogata[3] = { 10,9,-5 };
	int youso = 5;
	int youso2 = 5;
	printf("----------------------\nA\n----------------------\n");
	for (int i = 3; i > 0; i--)
	{
		youso += yousogata[i-1];
		printf("%d\n", youso);
		youso = youso2;
	}
	printf("----------------------\nB\n----------------------\n");
	for (int i = 3; i > 0; i--)
	{
		youso += yousogata[i-1];
		printf("%d\n", youso);
		youso = youso2;
	}
	printf("----------------------\n");

	return 0;
}