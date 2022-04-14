package pl.gdynia.amw.ojp.lab4;

public class Dog extends Animal{

    public Dog(String name) {
        super(name);
    }

    @Override
    public void voice() {
        System.out.println("Hau hau");
    }
}
