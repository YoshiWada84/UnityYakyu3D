#include <stdio.h>
#include <string.h>

int main() {
    char a[100], b[100];

    // �X�y�[�X���܂ޕ��������͂��邽�߂ɁAscanf�̑����fgets���g�p���܂�
    printf("������A����͂��Ă�������: ");
    fgets(a, sizeof(a), stdin);
    a[strcspn(a, "\n")] = '\0'; // ���s�������폜

    printf("������B����͂��Ă�������: ");
    fgets(b, sizeof(b), stdin);
    b[strcspn(b, "\n")] = '\0'; // ���s�������폜

    // ������A�ɕ�����B���܂܂�邩���`�F�b�N
    char* pos = strstr(a, b);
    if (pos != NULL) {
        // ��v�����ŏ��̕����ʒu��\��
        printf("%ld �����ڂ����v\n", pos - a + 1);
    }
    else {
        printf("��v���镔����������܂���ł����B\n");
    }

    return 0;
}
