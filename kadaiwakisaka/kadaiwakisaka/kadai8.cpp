#include <iostream>
#include <cstring>

int main() {
    char str[256*2];
    char wordToReplace[11];
    char replacementWord[11];

    std::cout << "���������͂��Ă��������i256�����ȓ��j: ";
    std::cin.getline(str, 256);

    std::cout << "�ϊ��������P�����͂��Ă��������i10�����ȓ��j: ";
    std::cin >> wordToReplace;

    std::cout << "�V�����P�����͂��Ă��������i10�����ȓ��j: ";
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

    std::cout << "�ϊ���̕�����: " << str << std::endl;

    return 0;
}