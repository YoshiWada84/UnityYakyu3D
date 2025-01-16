#include <stdio.h>
#include <string.h>

int main() {
    char a[100], b[100];

    // スペースを含む文字列を入力するために、scanfの代わりにfgetsを使用します
    printf("文字列Aを入力してください: ");
    fgets(a, sizeof(a), stdin);
    a[strcspn(a, "\n")] = '\0'; // 改行文字を削除

    printf("文字列Bを入力してください: ");
    fgets(b, sizeof(b), stdin);
    b[strcspn(b, "\n")] = '\0'; // 改行文字を削除

    // 文字列Aに文字列Bが含まれるかをチェック
    char* pos = strstr(a, b);
    if (pos != NULL) {
        // 一致した最初の文字位置を表示
        printf("%ld 文字目から一致\n", pos - a + 1);
    }
    else {
        printf("一致する部分が見つかりませんでした。\n");
    }

    return 0;
}
