#include <stdio.h>
#include <string.h>

int main() {
    char stra[257]; // 256����+�I�[�����̂���257
    int count[26] = { 0 }; // 'a'����'z'�܂ł̃J�E���g�p�z��

    printf("���������͂��Ă��������i256�����ȓ��j�F\n");
    scanf_s("%256[^\n]", stra); // �X�y�[�X���܂ޓ��͂��󂯎��

    // ��������̊e�������J�E���g
    for (int i = 0; i < strlen(stra); i++) {
        if (stra[i] >= 'a' && stra[i] <= 'z') {
            count[stra[i] - 'a']++;
        }
    }

    // ���ʂ�\��
    for (int i = 0; i < 26; i++) {
        if (count[i] > 0) {
            printf("%c: %d\n", 'a' + i, count[i]);
        }
    }

    return 0;
}