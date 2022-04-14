package pl.gdynia.amw.ojp.lab4;

public abstract class Animal {

    private String name;

    public Animal(String name) {
        this.name = name;
    }

    public abstract void voice();

    public void printName(){
        System.out.println(name);
    }


}
