#include <stdio.h>

int main() {
    int gakusei[] = { 334, 180, 450, 380, 264 }; // 配列の初期化
    int score = 0;
    
    int length = sizeof(gakusei) / sizeof(gakusei[0]); // 配列の長さを計算

    // 配列の要素を合計
    for (int i = 0; i < length; i++) {
        printf("%d人目の合計点：%d点\n",i+1, gakusei[i]);
        score += gakusei[i];
    }

    // 平均を計算
    double avr = (double)score / length;

    // 結果を表示
    printf("合計: %d点\n", score);
    printf("平均: %.1f点\n", avr);

    return 0;
}