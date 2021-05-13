#include <iostream>
#include <conio.h>

using namespace std;

typedef struct element_stosu *wsk_do_elementu;

struct element_stosu
{
    string imie, nazwisko;
    int rok_urodzenia;
    wsk_do_elementu wskaznik_nast;
};

wsk_do_elementu na_stos(wsk_do_elementu x)
{
    wsk_do_elementu wsk_tymczasowy;
    wsk_tymczasowy = new element_stosu;

    cout << "\nPodaj imie: ";
    cin >> wsk_tymczasowy->imie;
    cout << "Podaj nazwisko: ";
    cin >> wsk_tymczasowy->nazwisko;
    cout << "Podaj rok urodzenia: ";
    cin >> wsk_tymczasowy->rok_urodzenia;

    wsk_tymczasowy->wskaznik_nast = x;

    return wsk_tymczasowy;
}

wsk_do_elementu ze_stosu(wsk_do_elementu x)
{
    wsk_do_elementu wsk_tymczasowy;
    wsk_tymczasowy = x->wskaznik_nast;

    cout << "\nUsunięte dane: " + x->imie + " | " + x->nazwisko + " | " << x->rok_urodzenia << endl;

    delete x;

    return wsk_tymczasowy;
}

void wyswietl_stos(wsk_do_elementu x)
{
    element_stosu* tymczasowy = x;

    if (tymczasowy == NULL)
        cout << "Stos jest pusty!\n";
    else{
        cout << "\n";
        while (tymczasowy != NULL)
        {
            cout << tymczasowy->imie + " | " + tymczasowy->nazwisko + " | " << tymczasowy->rok_urodzenia << endl;
            tymczasowy = tymczasowy->wskaznik_nast;
        }
    }
}

void menu()
{
    cout << "*----------| Menu |----------*" << endl;
    cout << "| 1. Dodaj element osob      |" << endl;
    cout << "| 2. Usuń element z gory     |" << endl;
    cout << "| 3. Wyświetl stos           |" << endl;
    cout << "| 4. Koniec                  |" << endl;
    cout << "'----------------------------'" << endl;
}

void ini(){

    element_stosu* x = NULL;

    int numerMenu;
    bool koniec = false;
    do
    {
        menu();

        cout << "Wybierz opcje menu: ";
        cin >> numerMenu;
        

        switch (numerMenu)
        {
            case 1:
                x = na_stos(x);
                break;

            case 2:
                x = ze_stosu(x);
                break;

            case 3:
                wyswietl_stos(x);
                break;
            case 4:
                koniec = true;
                break;
            default:
                cout << "Wybrano nieprawidlową opcję\n";
                break;
        }

        cout << "\n__Wcisnij dowolny przycisk aby kontynuowac!___\n";
        _getch();
        system("cls");
    } while (koniec == false);
}

int main()
{
    setlocale(LC_CTYPE, "Polish");
    ini();
}