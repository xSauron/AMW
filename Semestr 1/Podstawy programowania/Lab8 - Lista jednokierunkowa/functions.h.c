#include <stdio.h>
#include <stdlib.h>

struct lista{
    int x;
    struct lista* next;
};

struct lista* glowa = NULL;

void wyswietlListe(){
    struct lista* tymczasowa = glowa;
    while(tymczasowa != NULL){
        printf("%d ", tymczasowa->x);
        tymczasowa = tymczasowa->next;
    }
    printf("\n");
}

void dodajNaPoczatek(int wartosc){
    struct lista* nowyElement = (struct lista*) malloc(sizeof(struct lista));
    nowyElement->x = wartosc;
    nowyElement->next = glowa;
    glowa = nowyElement;
}

void dodajNaKoniec(int wartosc) {
    struct lista* nowyElement = (struct lista*)malloc(sizeof(struct lista));
    nowyElement->next = NULL;
    nowyElement->x=wartosc;

    if (glowa == NULL) {
        glowa = nowyElement;
        glowa->next = NULL;
    } else{
        struct lista* tymczasowa = glowa;
        while (tymczasowa->next != NULL){
            tymczasowa = tymczasowa->next;
        }
        tymczasowa->next = nowyElement;
    }

}

void dodajPoElemencie(int element, int wartosc){
    struct lista* nowyElement = (struct lista*)malloc(sizeof(struct lista));
    struct lista* tymczasowa = glowa;

    nowyElement->x=wartosc;


    while(tymczasowa->x != element) {

        tymczasowa = tymczasowa->next;
    }

    nowyElement->next = tymczasowa->next;
    tymczasowa->next = nowyElement;

}

void usun(int wartosc){
    struct lista* tymczasowa = glowa;
    struct lista* poprzednia = NULL;


    while(tymczasowa->x != wartosc) {

            poprzednia = tymczasowa;
            tymczasowa = tymczasowa->next;
    }

    if(tymczasowa == glowa) {
        glowa = glowa->next;
    } else {
        poprzednia->next = tymczasowa->next;
    }
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