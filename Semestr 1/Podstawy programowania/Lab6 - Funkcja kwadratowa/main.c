#include <stdio.h>
#include <math.h>

struct Punkt
{
    int x,y;
    float xf,yf;
};

struct FunkcjaKwadratowa
{
    int a,b,c;
    int delta;
    float x1,x2;
    struct Punkt wierzcholek;
};

struct FunkcjaKwadratowa fx;

void wpiszDane();
void obliczDelte();
void obliczMiejscaZerowe();
void wypiszDane();
void obliczWierzcholek();

int main()
{
    wpiszDane();
    obliczDelte();
    obliczMiejscaZerowe();
    obliczWierzcholek();
    wypiszDane();
    return 0;
}
void wpiszDane()
{
    printf("---[ Wprowadz dane ]---\n");
    printf("Podaj liczbe a:");
    scanf("%d",&fx.a);

    printf("Podaj liczbe b:");
    scanf("%d",&fx.b);

    printf("Podaj liczbe c:");
    scanf("%d",&fx.c);

}

void obliczDelte(){

    fx.delta = (fx.b*fx.b)-(4*(fx.a*fx.c));

}

void obliczMiejscaZerowe(){

    if(fx.delta > 0){
        fx.x1 = (-fx.b - sqrt(fx.delta))/(2*fx.a);
        fx.x2 = (-fx.b + sqrt(fx.delta))/(2*fx.a);

    }
    else if(fx.delta == 0){
        fx.x1 = (float)(-fx.b)/(2*fx.a);
    }

}

void obliczWierzcholek(){

    fx.wierzcholek.x = (-fx.b) / (2*fx.a);
    fx.wierzcholek.xf = (float)(-fx.b) / (2*fx.a);
    if(fx.delta == 0){
        fx.wierzcholek.y = 0;
        fx.wierzcholek.yf = 0;
    }else{
        fx.wierzcholek.y = (-fx.delta) / (4*fx.a);
        fx.wierzcholek.yf = (float)(-fx.delta) / (4*fx.a);
    }

}

void wypiszDane(){

    printf("\n---[ Funkcja Kwadratowa ]---\n");
    printf("f(x) = %dx^2 + %dx + %d\n", fx.a,fx.b,fx.c);
    printf("Delta = %d\n",fx.delta);

    if(fx.delta > 0){
        printf("x1 = %.2f, x2 = %.2f\n", fx.x1, fx.x2);
    }
    else if(fx.delta == 0){
        printf("x0 = %.2f\n", fx.x1);
    }else{
        printf("Brak miejsc zerowych!\n");
    }

    printf("Wierzcholek (p,q) = (%d, %d)\n", fx.wierzcholek.x, fx.wierzcholek.y);
    printf("Wierzcholek (p,q) = (%f, %f)", fx.wierzcholek.xf, fx.wierzcholek.yf);
}