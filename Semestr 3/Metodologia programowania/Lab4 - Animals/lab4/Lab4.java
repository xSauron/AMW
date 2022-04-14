package pl.gdynia.amw.ojp.lab4;

public class Lab4 {

    public void lab4(){
        Animal dog = new Dog("Dog");
        dog.printName();
        dog.voice();

        Animal cat = new Cat("Cat");
        cat.printName();
        cat.voice();
    }
}
