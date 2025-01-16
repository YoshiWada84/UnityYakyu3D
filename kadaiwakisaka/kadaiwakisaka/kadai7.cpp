#include<stdio.h>


int main(void)
{
	int yousogata[5] = { 0,1,2,3,4 };

	int score = 0;
	int high = 0;
	int low = 100000;
	int length = sizeof(yousogata) / sizeof(yousogata[0]); // 配列の長さを計算


	for (int i = 0; i <= 4; i++)
	{
		printf("%d番の身長：",i+1);
		scanf_s("%d", &yousogata[i]);
		
		score += yousogata[i];
		if (high <= yousogata[i])
		{
			high = yousogata[i];
		}
		if (low >= yousogata[i])
		{
			low = yousogata[i];
		}
	}
	// 平均を計算
	double avr = (double)score / length;

	printf("最大値: %d\n", high);
	printf("最小値: %d\n", low);
	printf("平均値: %.1f\n", avr);
	return 0;
}