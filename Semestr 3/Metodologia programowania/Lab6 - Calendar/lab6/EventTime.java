package pl.gdynia.amw.ojp.lab6;

import java.time.LocalTime;

public abstract class EventTime extends Event{

    protected LocalTime startTime;
    protected LocalTime endTime;
    public static final LocalTime earliestTimeEventCanStart = LocalTime.parse("08:00");

    @Override
    public String toString(){
        return startTime.toString() + " <-> " + endTime.toString() + " [ " + description +  " ] " + " ( " + priority + " )";
    }

}
