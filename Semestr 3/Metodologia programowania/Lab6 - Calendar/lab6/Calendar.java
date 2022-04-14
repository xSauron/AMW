package pl.gdynia.amw.ojp.lab6;

import java.io.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;


public class Calendar {

    private List<Event>[] monthCalendar = new ArrayList[31];
    private final String filename = "calendar";

    public Calendar() {
        for (int i = 0; i < monthCalendar.length; i++) {
            monthCalendar[i] = new ArrayList<Event>();
        }

        readFromFile();
    }

    protected boolean addEvent(int day, Event event) {
        if (isCorrectDay(day)) {
            monthCalendar[day].add(event);
            saveToFile();
            return true;
        } else {
            return false;
        }

    }

    protected boolean removeEvent(int day, int eventID) {
        if (isCorrectDay(day)) {
            if (monthCalendar[day].get(eventID) != null) {
                monthCalendar[day].remove(eventID);
                saveToFile();
                return true;
            } else {
                return false;
            }
        } else {
            return false;
        }
    }

    private boolean isCorrectDay(int day) {
        return day >= 0 && day < 31;
    }

    private void readFromFile() {

        FileInputStream file = null;
        ObjectInputStream in = null;

        try {
            file = new FileInputStream(filename);
            in = new ObjectInputStream(file);

            this.monthCalendar = (List<Event>[]) in.readObject();

            System.out.println("Odczytano z pliku");
        } catch (IOException ex) {
            System.out.println("Błąd oczytu z pliku!");
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        } finally {
            try {
                in.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
            try {
                file.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }

    }

    private void saveToFile() {
        String filename = "calendar";
        FileOutputStream file = null;
        ObjectOutputStream out = null;

        try {
            file = new FileOutputStream(filename);
            out = new ObjectOutputStream(file);
            out.writeObject(monthCalendar);

            System.out.println("Zapisano do pliku");
        } catch (IOException ex) {
            System.out.println("Błąd zapisu!");
        } finally {
            try {
                out.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
            try {
                file.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }

    public List<Event>[] getMonthCalendar() {
        return monthCalendar;
    }
}
