#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MIN 5
#define MAX 15
#define ROZMIAR_TABLICY 12

int wygenerujTabliceLiczbPseudoLosowych(int* tablica);
int policzSume(int* tablica);
float policzSrednia(int* tablica);
void wygenerujHistogram(int* tablica, int* histogram);
void wypiszStatystyki(int* tablica, int suma, float srednia, int* histogram);
void wypiszTablice(int* tablica);

int main() {
    int tablica[ROZMIAR_TABLICY];
    int rezultatGenerowania = wygenerujTabliceLiczbPseudoLosowych(tablica);
    if(rezultatGenerowania == 1){
        wypiszTablice(tablica);

    }

    int suma;
    float srednia;
    int histogram[MAX-MIN+1]= {0};
    suma = policzSume(tablica);
    srednia = policzSrednia(tablica);
    wygenerujHistogram(tablica, histogram);
    wypiszStatystyki(tablica, suma, srednia, histogram);
    return 0;
}

int wygenerujTabliceLiczbPseudoLosowych(int* tablica) {

    srand(time(0));
    for(int i = 0; i < ROZMIAR_TABLICY; i++){
        tablica[i] = (rand() % (MAX+1 - MIN)) + MIN;
    }

    return 1;
}

int policzSume(int* tablica){

    int suma = 0;
    for(int i = 0; i < ROZMIAR_TABLICY; i++){
        suma += tablica[i];
    }

    return suma;
}

float policzSrednia(int* tablica) {

    float srednia = 0;
    int suma = policzSume(tablica);
    srednia = (float)suma/ROZMIAR_TABLICY;

    return srednia;
}

void wypiszTablice(int* tablica){

    printf("[ ");
    for(int i=0; i < ROZMIAR_TABLICY; i++){
        printf("%d ", tablica[i]);
    }
    printf("]\n");

}

void wygenerujHistogram(int* tablica, int* histogram) {

    for (int i = 0; i < ROZMIAR_TABLICY; i++) {
        histogram[tablica[i] - MIN]++;
    }

}

void wypiszStatystyki(int* tablica, int suma, float srednia, int* histogram) {

    printf("Suma: %d\n", suma);
    printf("Srednia: %.2f\n", srednia);
    printf("Histogram:\n");

    for(int i=0; i <= MAX-MIN; i++){
        printf("%d -> %d\n", i+MIN, histogram[i]);
    }

}