  
#include <stdio.h>

int main() {

    //VARS
    char imie[30], nazwisko[30];

    //DISPLAY
    printf("Podaj swoje imie i nazwisko (Oddzielone spacja): ");
    scanf("%s %s",imie,nazwisko);
    printf("Witaj %s %s!",nazwisko,imie);

    return 0;
}