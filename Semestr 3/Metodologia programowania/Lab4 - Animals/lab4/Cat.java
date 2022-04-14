package pl.gdynia.amw.ojp.lab4;

public class Cat extends Animal{

    public Cat(String name) {
        super(name);
    }

    @Override
    public void voice() {
        System.out.println("Miau miau");
    }
}
