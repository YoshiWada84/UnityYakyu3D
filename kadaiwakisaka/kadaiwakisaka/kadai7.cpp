#include<stdio.h>


int main(void)
{
	int yousogata[5] = { 0,1,2,3,4 };

	int score = 0;
	int high = 0;
	int low = 100000;
	int length = sizeof(yousogata) / sizeof(yousogata[0]); // �z��̒������v�Z


	for (int i = 0; i <= 4; i++)
	{
		printf("%d�Ԃ̐g���F",i+1);
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
	// ���ς��v�Z
	double avr = (double)score / length;

	printf("�ő�l: %d\n", high);
	printf("�ŏ��l: %d\n", low);
	printf("���ϒl: %.1f\n", avr);
	return 0;
}