package pl.gdynia.amw.ojp.lab3;

public class Triangle extends Figure{
    private double a;
    private double b;
    private double c;
    private double h;

    public Triangle() {

    }

    @Override
    public void printSurfaceArea(){
        System.out.println("Pole powierzchni trójkąta prostokątnego: " + (a * h)/2);
    }

    @Override
    public void printCicuit(){
        System.out.println("Obwód trójkąta: " + (a+b+c));
    }

    public double getA() {
        return a;
    }

    public void setA(double a) {
        this.a = a;
    }

    public double getB() {
        return b;
    }

    public void setB(double b) {
        this.b = b;
    }

    public double getC() {
        return c;
    }

    public void setC(double c) {
        this.c = c;
    }

    public double getH() {
        return h;
    }

    public void setH(double h) {
        this.h = h;
    }
}
