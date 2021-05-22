#include <iostream>
#include <vector>
#include <string>
#include <conio.h>

using namespace std;


void bucketSort(char tab[], int n)
{
    vector<char> k[128];

    for (int i = 0; i < n; i++) {
        int ki = tab[i];
        ki = ki;
        k[ki].push_back(tab[i]);
    }

    int index = 0;
    for (int i = 0; i < 128; i++) {
        for (int j = 0; j < k[i].size(); j++) {
            tab[index] = k[i][j];
            index = index + 1;
        }
    }

    for (int i = 0; i < 128; i++) {
        k[i].clear();
    }
}

int main()
{
    setlocale(LC_CTYPE, "Polish");
    int n;
    cout << "Wprowadź liczbę liter: ";
    cin >> n;

    char* tab = new char[n];
    cout << "\n";
    for (int i = 0; i < n; i++)
    {
        cout << "Wprowadź litere " << i + 1 << ": ";
        cin >> tab[i];

    }
    bucketSort(tab, n);

    cout << "\nPosortowane: \n";
    for (int i = 0; i < n; i++)
        cout << i + 1 << ": " << tab[i] << endl;

    delete[] tab;
    cout << "\n__Wcisnij dowolny przycisk aby zakonczyć!___\n";
    _getch();
    return 0;
}