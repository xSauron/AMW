#include <stdio.h>


#define wielkosc 4

char plansza[wielkosc][wielkosc]={0};
int iloscRuchow = wielkosc * wielkosc;
int graWToku = 1;
void  graj();
void wyswietlInstrukcje();
void wyswietlPlansze();
int wpiszPole(int, int);
int wygenerujPlansze();
int sprawdzWygrana();


int main() {

	@@ -44,7 +50,10 @@ void graj(){
    wyswietlInstrukcje();
    wygenerujPlansze();

    int gracz = 1;
    int pole = 0;
    int rezultat = 0;


    do{
        fflush(stdin);
	@@ -80,10 +89,13 @@ void graj(){

        wyswietlPlansze();

    }while(iloscRuchow>0 && graWToku);

    if(graWToku){
        printf("REMIS");
    }else{
        printf("Wygral gracz %d", gracz);
    }
}

void wyswietlPlansze()
	@@ -124,10 +136,85 @@ int wpiszPole(int pole, int gracz){
    if(plansza[w][k] == ' '){
        printf("Ruch zatwierdzony!");
        plansza[w][k] = znak;

        if(sprawdzWygrana()==1){
            graWToku = 0;
            return 0;
        }

        return 1;
    }else{
        printf("Pole jest juz zajete. Powtorz ruch!");
        return 0;
    }

}

int sprawdzWygrana(){
    char pierwszyZnak;
    int wygrana = 0;

    //Sprawdzanie wierszy
    for(int w = 0; w < wielkosc; w++){
        pierwszyZnak = plansza[w][0];
        if(pierwszyZnak == ' '){
            continue;
        }
        wygrana = 1;
        for(int k = 0; k < wielkosc; k++){
            if(pierwszyZnak != plansza[w][k]){
                wygrana = 0;
                break;
            }
        }
        if(wygrana == 1){
            return 1;
        }
    }
    //Sprawdzenie kolumn
    for(int k = 0; k < wielkosc; k++){
        pierwszyZnak = plansza[0][k];
        if(pierwszyZnak == ' '){
            continue;
        }
        wygrana = 1;
        for(int w = 0; w < wielkosc; w++){
            if(pierwszyZnak != plansza[w][k]){
                wygrana = 0;
                break;
            }
        }
        if(wygrana == 1){
            return 1;
        }
    }
    //Sprawdz przekatne
    wygrana = 1;
    for(int i=0; i < wielkosc; i++){
        if(plansza[0][0] == ' '){
            wygrana = 0;
            break;
        }
        if(plansza[i][i] != plansza[0][0]){
            wygrana = 0;
            break;
        }
    }
    if(wygrana == 1){
        return 1;
    }

    wygrana = 1;
    for(int i=0; i < wielkosc; i++){
        if(plansza[0][wielkosc-1] == ' '){
            wygrana = 0;
            break;
        }
        if(plansza[i][wielkosc-1-i] != plansza[0][wielkosc-1]){
            wygrana = 0;
            break;
        }
    }

    return wygrana;
}