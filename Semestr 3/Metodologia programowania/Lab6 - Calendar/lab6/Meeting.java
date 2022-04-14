package pl.gdynia.amw.ojp.lab6;

import java.time.LocalTime;

public class Meeting extends EventTime {

    public Meeting(LocalTime startTime, LocalTime endTime, String description, Priority priority) {
        this.startTime = startTime;
        this.endTime = endTime;
        this.description = description;
        this.priority = priority;
        this.typeName = "Meeting";
    }




}
