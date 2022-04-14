package pl.gdynia.amw.ojp.lab6;

import java.time.LocalTime;

public class Reminder extends Event{

    public Reminder(String description, Priority priority) {
        this.description = description;
        this.priority = priority;
        this.typeName = "Reminder";
    }
}
