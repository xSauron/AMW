package pl.gdynia.amw.ojp.lab6;


import java.io.Serializable;

public abstract  class Event implements Serializable {

    protected enum Priority{
        LOW,
        MEDIUM,
        HIGH
    }
    protected String description;
    protected Priority priority;
    protected String typeName;

    public String toString(){
        return " [ " + description +  " ] " + " ( " + priority + " )";
    }

    public Priority getPriority() {
        return priority;
    }
}
