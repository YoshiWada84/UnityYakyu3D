#include <stdio.h>

int main() {
    int gakusei[] = { 334, 180, 450, 380, 264 }; // �z��̏�����
    int score = 0;
    
    int length = sizeof(gakusei) / sizeof(gakusei[0]); // �z��̒������v�Z

    // �z��̗v�f�����v
    for (int i = 0; i < length; i++) {
        printf("%d�l�ڂ̍��v�_�F%d�_\n",i+1, gakusei[i]);
        score += gakusei[i];
    }

    // ���ς��v�Z
    double avr = (double)score / length;

    // ���ʂ�\��
    printf("���v: %d�_\n", score);
    printf("����: %.1f�_\n", avr);

    return 0;
}