#include <stdio.h>
#include "functions.h"

void instrukcja() {
    printf("\n---[ LISTY ]---\n");
    printf("1. Wyswietl liste od poczatku.\n");
    printf("2. Wyswietl liste od konca.\n");
    printf("3. Dodaj element na koniec listy.\n");
    printf("4. Dodaj element na poczatku listy.\n");
    printf("5. Dodaj element po elemencie z listy.\n");
    printf("6. Usun z listy.\n");

    printf("\nWybierz element z menu:");
}

void menu(){
    int numerMenu;
    int wartosc;
    int element;
    int min;
    int max;

    do{
        instrukcja();

        fflush(stdin);
        scanf("%d", &numerMenu);

        switch(numerMenu){
            case 1:
                wyswietlListeOdPoczatku();
                break;
            case 2:
                wyswietlListeOdKonca();
                break;
            case 3:
                printf("Podaj liczbe do dodania:");
                scanf("%d", &wartosc);
                if(sprawdzWystepowanie(wartosc) == 0){
                    dodajNaKoniec(wartosc);
                }else{
                    printf("\nTaki element juz wystepuje podaj unikatowy!\n");
                }

                break;
            case 4:
                printf("Podaj liczbe do dodania:");
                scanf("%d", &wartosc);
                if(sprawdzWystepowanie(wartosc) == 0){
                    dodajNaPoczatek(wartosc);
                }else{
                    printf("\nTaki element juz wystepuje podaj unikatowy!\n");
                }
                break;
            case 5:
                printf("Podaj element po ktorym chcesz dodac liczbe:");
                scanf("%d", &element);
                if(sprawdzWystepowanie(element) == 1){
                    printf("Podaj liczbe do dodania:");
                    scanf("%d", &wartosc);
                    if(sprawdzWystepowanie(wartosc)==0){
                        dodajPoElemencie(element,wartosc);
                    }else{
                        printf("\nTaki element juz wystepuje podaj unikatowy!\n");
                    }

                }else{
                    printf("\nTaki element nie wystepuje na liscie!\n");
                }
                break;
            case 6:
                printf("Podaj liczbe do usuniecia:");
                scanf("%d", &wartosc);
                if(sprawdzWystepowanie(wartosc) == 1){
                    usun(wartosc);
                }else{
                    printf("\nTaki element nie wystepuje na liscie!\n");
                }
                break;
            case 7:
                printf("Podaj minimum:");
                scanf("%d", &min);
                printf("Podaj maximum:");
                scanf("%d", &max);
                for(int i = min; i <= max; i++){
                    if(sprawdzWystepowanie(i) == 0){
                        dodajNaKoniec(i);
                    }
                }
                break;
            default:
                printf("\nBlad! Wybrano zly element menu, sprobuj ponownie!\n\n");
                break;
        }

    }while(1);


}