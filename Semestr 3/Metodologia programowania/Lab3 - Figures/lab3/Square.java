package pl.gdynia.amw.ojp.lab3;

public class Square extends Figure{
    private double a;

    public Square() {

    }

    @Override
    public void printSurfaceArea(){
        System.out.println("Pole powierzchni kwadratu: " + Math.pow(a,2));
    }

    @Override
    public void printCicuit(){
        System.out.println("Obwód kwadratu: " + 4 * a);
    }

    public double getA() {
        return a;
    }

    public void setA(double a) {
        this.a = a;
    }
}
