#include <stdio.h>
#include <string.h>

int main() {
    char stra[257]; // 256文字+終端文字のため257
    int count[26] = { 0 }; // 'a'から'z'までのカウント用配列

    printf("文字列を入力してください（256文字以内）：\n");
    scanf_s("%256[^\n]", stra); // スペースを含む入力を受け取る

    // 文字列内の各文字をカウント
    for (int i = 0; i < strlen(stra); i++) {
        if (stra[i] >= 'a' && stra[i] <= 'z') {
            count[stra[i] - 'a']++;
        }
    }

    // 結果を表示
    for (int i = 0; i < 26; i++) {
        if (count[i] > 0) {
            printf("%c: %d\n", 'a' + i, count[i]);
        }
    }

    return 0;
}