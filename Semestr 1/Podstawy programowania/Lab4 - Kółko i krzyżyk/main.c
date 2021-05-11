
                printf("| %c ", plansza[w][k]);
            }
        }
        printf("\n");
    }
}

int wpiszPole(int pole, int gracz){
    char znak;
    int k,w; //Kolumna, wiersz

    if(pole <= 0 || pole > wielkosc*wielkosc){
        printf("Pole poza zakresem wyboru!");
        return 0;
    }

    if(gracz == 1){
        znak = 'O';
    }else{
        znak = 'X';
    }

    k = (pole-1)%wielkosc;
    w = (pole-1)/wielkosc;

    //printf("K: %d\nW: %d\n", k, w); //DEBUG DO SPRAWDZANIA KOORDYNATOW;

    if(plansza[w][k] == ' '){
        printf("Ruch zatwierdzony!");
        plansza[w][k] = znak;
        return 1;
    }else{
        printf("Pole jest juz zajete. Powtorz ruch!");
        return 0;
    }

}