void calculate(){
    //SWITCH & CALCULATE
    switch(calc.operation) {
        case '+':
            calc.result = calc.number1 + calc.number2;
            break;
        case '-':
            calc.result = calc.number1 - calc.number2;
            break;
        case '*':
            calc.result = calc.number1 * calc.number2;
            break;
        case '/':
            if(calc.number2 == 0) {
                printf("Blad!\n Dzielenie przez 0!");
                calc.result = 0;
            }
            else if(calc.number2 > 0)
                calc.result=(float)calc.number1/(float)calc.number2;
            break;
        default:
            printf("Blad!\nWybrano nieodpowiednia operacje (+,-,*,/)!");
    }

}

void displayResult(){
    printf("Rownanie: %d %c %d = %.2f\n",calc.number1,calc.operation,calc.number2,calc.result);
}