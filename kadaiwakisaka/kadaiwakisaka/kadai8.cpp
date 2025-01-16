#include <iostream>
#include <cstring>

int main() {
    char str[256*2];
    char wordToReplace[11];
    char replacementWord[11];

    std::cout << "文字列を入力してください（256文字以内）: ";
    std::cin.getline(str, 256);

    std::cout << "変換したい単語を入力してください（10文字以内）: ";
    std::cin >> wordToReplace;

    std::cout << "新しい単語を入力してください（10文字以内）: ";
    std::cin >> replacementWord;

    char* pos = strstr(str, wordToReplace);
    while (pos != nullptr) {
        int len = strlen(wordToReplace);
        int newLen = strlen(replacementWord);
        int diff = newLen - len;

        if (diff > 0) {
            memmove(pos + newLen, pos + len, strlen(pos + len) + 1);
        }
        else if (diff < 0) {
            memmove(pos + newLen, pos + len, strlen(pos + len) + 1);
        }

        memcpy(pos, replacementWord, newLen);
        pos = strstr(pos + newLen, wordToReplace);
    }

    std::cout << "変換後の文字列: " << str << std::endl;

    return 0;
}