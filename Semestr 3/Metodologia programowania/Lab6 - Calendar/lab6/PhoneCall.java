package pl.gdynia.amw.ojp.lab6;

import java.time.LocalTime;

public class PhoneCall extends EventTime{

    private final String phoneNumber;

    public PhoneCall(LocalTime startTime, LocalTime endTime, String description, Priority priority,String phoneNumber) {
        this.startTime = startTime;
        this.endTime = endTime;
        this.description = description;
        this.priority = priority;
        this.phoneNumber = phoneNumber;
        this.typeName = "PhoneCall";
    }

    @Override
    public String toString(){
        return startTime.toString() + " <-> " + endTime.toString() + " [ " + phoneNumber +  " ] " +  " [ " + description +  " ] " + " ( " + priority + " )";
    }
}
