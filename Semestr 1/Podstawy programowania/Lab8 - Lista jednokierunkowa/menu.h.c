#include <stdio.h>
#include "functions.h"

void instrukcja() {
    printf("\n---[ LISTY ]---\n");
    printf("1. Wypisz liste.\n");
    printf("2. Dodaj element na koniec listy.\n");
    printf("3. Dodaj element na poczatku listy.\n");
    printf("4. Dodaj element po elemencie z listy.\n");
    printf("5. Usun z listy.\n");

    printf("\nWybierz element z menu:");
}

void menu(){
    int numerMenu;
    int wartosc;
    int element;
    do{
        instrukcja();

        scanf("%d", &numerMenu);

        switch(numerMenu){
            case 1:
                wyswietlListe();
                break;
            case 2:
                printf("Podaj liczbe do dodania:");
                scanf("%d", &wartosc);
                if(sprawdzWystepowanie(wartosc) == 0){
                    dodajNaKoniec(wartosc);
                }else{
                    printf("\nTaki element juz wystepuje podaj unikatowy!\n");
                }

                break;
            case 3:
                printf("Podaj liczbe do dodania:");
                scanf("%d", &wartosc);
                if(sprawdzWystepowanie(wartosc) == 0){
                    dodajNaPoczatek(wartosc);
                }else{
                    printf("\nTaki element juz wystepuje podaj unikatowy!\n");
                }
                break;
            case 4:
                printf("Podaj element po ktorym chcesz dodac liczbe:");
                scanf("%d", &element);
                if(sprawdzWystepowanie(element) == 1){
                    printf("Podaj liczbe do dodania:");
                    scanf("%d", &wartosc);
                    dodajPoElemencie(element,wartosc);
                }else{
                    printf("\nTaki element nie wystepuje na liscie!\n");
                }
                break;
            case 5:
                printf("Podaj liczbe do usuniecia:");
                scanf("%d", &wartosc);
                if(sprawdzWystepowanie(wartosc) == 1){
                    usun(wartosc);
                }else{
                    printf("\nTaki element nie wystepuje na liscie!\n");
                }
                break;
            default:
                printf("\nBlad! Wybrano zly element menu, sprobuj ponownie!\n\n");
                break;
        }

    }while(1);


}