#include <stdio.h>
#include <stdlib.h>

struct lista{
    int x;
    struct lista* next;
    struct lista* prev;
};

struct lista* glowa = NULL;
struct lista* koniec = NULL;

void wyswietlListeOdPoczatku(){
    struct lista* tymczasowa = glowa;
    while(tymczasowa != NULL){
        printf("%d ", tymczasowa->x);
        tymczasowa = tymczasowa->next;
    }
    printf("\n");
}

void wyswietlListeOdKonca(){
    struct lista* tymczasowa = koniec;
    while(tymczasowa != NULL){
        printf("%d ", tymczasowa->x);
        tymczasowa = tymczasowa->prev;
    }
    printf("\n");
}

void dodajNaPoczatek(int wartosc){
    struct lista* nowyElement = (struct lista*) malloc(sizeof(struct lista));
    nowyElement->x = wartosc;
    nowyElement->next = glowa;
    nowyElement->prev = NULL;
    if(glowa != NULL){
        glowa->prev = nowyElement;
    }
    glowa = nowyElement;
    if(koniec == NULL){
        koniec = nowyElement;
    }
}

void dodajNaKoniec(int wartosc) {
    struct lista* nowyElement = (struct lista*)malloc(sizeof(struct lista));
    nowyElement->next = NULL;
    nowyElement->prev = koniec;
    nowyElement->x = wartosc;

    if (glowa == NULL) {
        glowa = nowyElement;
    } else{
        koniec->next = nowyElement;
    }
    koniec = nowyElement;
}

void dodajPoElemencie(int element, int wartosc){
    struct lista* nowyElement = (struct lista*)malloc(sizeof(struct lista));
    struct lista* tymczasowa = glowa;

    nowyElement->x=wartosc;

    while(tymczasowa->x != element) {

        tymczasowa = tymczasowa->next;
    }

    nowyElement->next = tymczasowa->next;
    nowyElement->prev = tymczasowa;
    tymczasowa->next = nowyElement;

}

void usun(int wartosc){
    struct lista* tymczasowa = glowa;
    struct lista* poprzednia = NULL;


    while(tymczasowa->x != wartosc) {

            poprzednia = tymczasowa;
            tymczasowa = tymczasowa->next;
    }

    if(tymczasowa == koniec){
        koniec = koniec->prev;
        if(tymczasowa == glowa){
            glowa = NULL;
        }
    }
    else if(tymczasowa == glowa) {
        glowa = glowa->next;
    } else {
        poprzednia->next = tymczasowa->next;
        poprzednia->next->prev = poprzednia;
    }
    free(tymczasowa);
}

int sprawdzWystepowanie(int wartosc){
    struct lista* tymczasowa = glowa;

    if(glowa == NULL) {
        return 0;
    }
    while(tymczasowa->x != wartosc) {
        if(tymczasowa->next == NULL) {
            return 0;
        } else {
            tymczasowa = tymczasowa->next;
        }
    }
    return 1;
}