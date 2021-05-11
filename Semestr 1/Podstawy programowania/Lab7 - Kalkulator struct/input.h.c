#include <stdio.h>

//VARS
struct parameters{
    int type;
    int number1;
    int number2;
    int inputs;
    float result;
    char operation;
};

struct parameters calc;

void instruction(){
    printf("---[ KALKULATOR ]---");
    printf("\nWybierz opcje wprowadzenia danych:");
    printf("\n1. Wzor");
    printf("\n2. Formularz");
}

int pickType(){
    int success = 0;
    do{
        fflush(stdin);
        printf("\nOpcja: ");
        scanf("%i", &(calc.type));
        if(calc.type == 1 || calc.type == 2){
            success = 1;
        }else{
            success = 0;
            printf("\nWprowadzono zla opcje, sprobuj ponownie!");
        }
    }while(success == 0);

}

void displayType(){

    if(calc.type == 1){
        printf("\nWybrano *Wzor*, wprowadz rownanie wedlug wzoru: a (+,-,*,/) b\n");

        int success = 0;
        do{
            fflush(stdin);
            calc.inputs = scanf("%i %c %i", &(calc.number1), &(calc.operation), &(calc.number2));

            //Check if user passed 3 variables.
            if (calc.inputs != 3) {
                printf("Bledny wzor sprobuj ponownie.\n");
            }else{
                success = 1;
            }

            //Check if operation is correct.
            if(calc.operation == '+' || calc.operation == '-' || calc.operation == '*' || calc.operation == '/'){
                success = 1;
            }else{
                success = 0;
                printf("Bledna operacja sprobuj ponownie.\n");
            }

        }
        while(success != 1);
    }
    else if(calc.type == 2){

        printf("\nWybrano *Formularz*.\n\n");

        int success = 0;
        do{
            fflush(stdin);
            printf("Podaj liczbe A:\n");
            scanf("%i", &(calc.number1));
            printf("Podaj liczbe B:\n");
            scanf("%i", &(calc.number2));

            printf("Podaj operacje (+,-,*,/):\n");
            scanf(" %c", &(calc.operation));

            //Check if operation is correct.
            if(calc.operation == '+' || calc.operation == '-' || calc.operation == '*' || calc.operation == '/'){
                success = 1;
            }else{
                success = 0;
                printf("\nBledna operacja sprobuj ponownie!\n\n");
            }

        }
        while(success != 1);
    }
}

void start(){
    instruction();
    pickType();
    displayType();
}