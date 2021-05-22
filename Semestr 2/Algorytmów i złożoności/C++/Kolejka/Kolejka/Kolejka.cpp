#include <iostream>
#include <conio.h>

using namespace std;

typedef struct element_kolejki* wsk_kolejki;

struct element_kolejki {
    string imie, nazwisko;
    int rok_urodzenia;
    wsk_kolejki wsk_nastepny;
} * początek;

element_kolejki dodaj_element()
{
    element_kolejki tymczasowy;

    cout << "\nPodaj imie: ";
    cin >> tymczasowy.imie;
    cout << "Podaj nazwisko: ";
    cin >> tymczasowy.nazwisko;
    cout << "Podaj rok urodzenia: ";
    cin >> tymczasowy.rok_urodzenia;

    return tymczasowy;
}

void wyswietl_kolejke(element_kolejki* x)
{
    element_kolejki* iterator = x;

    if (iterator == NULL)
    {
        cout << "\n_!_ Kolejka jest pusta _!_";
    }
    else
    {
        while (iterator != NULL)
        {
            cout << "\nImie: " << iterator->imie << endl;
            cout << "Nazwisko: " << iterator->nazwisko << endl;
            cout << "Rok urodzenia: " << iterator->rok_urodzenia << endl;
            iterator = iterator->wsk_nastepny;
        }
    }
}

wsk_kolejki do_kolejki(wsk_kolejki x, element_kolejki y)
{
    wsk_kolejki wsk_pom;

    wsk_pom = new element_kolejki;

    wsk_pom->imie = y.imie;
    wsk_pom->nazwisko = y.nazwisko;
    wsk_pom->rok_urodzenia = y.rok_urodzenia;

    if (początek == NULL)
    {
        początek = wsk_pom;
    }
    if (x != NULL)
    {
        x->wsk_nastepny = wsk_pom;
    }

    wsk_pom->wsk_nastepny = NULL;

    return wsk_pom;
}

wsk_kolejki z_kolejki(wsk_kolejki x)
{
    wsk_kolejki wsk_pom;

    if (x != NULL)
    {
        wsk_pom = x->wsk_nastepny;

        cout << "\n\/ Usunięte dane: \/" << endl;
        cout << "Imie: " << x->imie << endl;
        cout << "Nazwisko: " << x->nazwisko << endl;
        cout << "Rok urodzenia: " << x->rok_urodzenia << endl;

        delete x;

        return wsk_pom;
    }
    else
    {
        cout << "\n_!_ Kolejka jest pusta _!_";
        return x;
    }
}

void menu()
{
    cout << "*----------| Menu |----------*" << endl;
    cout << "| 1. Dodaj element osoba     |" << endl;
    cout << "| 2. Usuń element            |" << endl;
    cout << "| 3. Wyświetl kolejke        |" << endl;
    cout << "| 4. Koniec                  |" << endl;
    cout << "'----------------------------'" << endl;
}

void ini() {

    element_kolejki* koniec = NULL;
    element_kolejki t;

    int numerMenu;
    do
    {
        menu();

        cout << "Wybierz opcje menu: ";
        cin >> numerMenu;


        switch (numerMenu)
        {
            case 1:
                t = dodaj_element();
                koniec = do_kolejki(koniec, t);
                break;

            case 2:
                początek = z_kolejki(początek);
                break;

            case 3:
                wyswietl_kolejke(początek);
                break;
            case 4:
                exit(0);
                break;
            default:
                cout << "Wybrano nieprawidlową opcję\n";
                break;
        }

        cout << "\n__Wcisnij dowolny przycisk aby kontynuowac!___\n";
        _getch();
        system("cls");
    } while (1);
}


int main()
{
    setlocale(LC_CTYPE, "Polish");
    ini();
}
