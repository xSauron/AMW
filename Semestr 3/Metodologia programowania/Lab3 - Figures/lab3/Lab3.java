package pl.gdynia.amw.ojp.lab3;

public class Lab3 {
    public void lab3(){

        Figure figure = new Figure();
        figure.printSurfaceArea();
        figure.printCicuit();

        Square square = new Square();
        square.setA(5.5);
        square.printSurfaceArea();
        square.printCicuit();

        Triangle triangle = new Triangle();
        triangle.setA(1);
        triangle.setB(2);
        triangle.setC(3);
        triangle.setH(4.5);
        triangle.printSurfaceArea();
        triangle.printCicuit();

    }
}
