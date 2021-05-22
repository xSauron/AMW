#include <iostream>
#include <vector>
#include <string>
#include <conio.h>

using namespace std;

void kubelkiSortuj(string tab[], int n)
{
    vector<string> k[128];

    int dl = tab[0].length();

    for (int p = dl;p >= 0; p--){
        for (int i = 0; i < n; i++) {
            int ki = tab[i][p];
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
        for (int i = 0; i < 128; i++){
            k[i].clear();
        }
    }
}

int main()
{   
    setlocale(LC_CTYPE, "Polish");
    int n;
    cout << "Wprowadź liczbę słów: ";
    cin >> n;

    string* tab = new string[n];
    cout << "\n";
    for (int i = 0; i < n; i++)
    {
        cout << "Wprowadź słowo " << i + 1 << ": ";
        cin >> tab[i];

    }
    kubelkiSortuj(tab, n);

    cout << "\nPosortowane: \n";
    for (int i = 0; i < n; i++)
        cout << i+1 << ": " << tab[i] << endl;

    delete[] tab;
    cout << "\n__Wcisnij dowolny przycisk aby zakonczyć!___\n";
    _getch();
    return 0;
}