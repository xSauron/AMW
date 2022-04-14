package pl.gdynia.amw.ojp.lab6;

import java.time.LocalTime;
import java.util.List;
import java.util.Scanner;

public class UserHandler {

    private final Calendar calendar;
    Scanner scanner;

    public UserHandler(Calendar cal) {
        this.calendar = cal;
        scanner =  new Scanner(System.in);
        menu();
    }

    public void menu(){
        int end = 0;
        int selected;
        while(end == 0){
            System.out.println("\n======= MENU ========");
            System.out.println("1. Dodaj event");
            System.out.println("2. Usun event");
            System.out.println("3. Wyswietl eventy");
            System.out.println("4. Wyswietl eventy z priorytetem");
            System.out.println("5. Wyswietl eventy danym typem");
            System.out.println("6. Koniec");
            System.out.print("\nOpcja: ");

            selected = Integer.parseInt(scanner.nextLine());

            switch (selected){
                case 1:
                    userAddEvent();
                    break;
                case 2:
                    userRemoveEvent();
                    break;
                case 3:
                    userPrintEvents();
                    break;
                case 4:
                    userPrintEventsWithPriority();
                    break;
                case 5:
                    userPrintEventsWithType();
                    break;
                case 6:
                    end = 1;
                    break;
                default:
                    System.out.println("\nPodaj poprawną opcje menu!");
                    break;
            }
        }
        System.exit(0);
    }


    private void userAddEvent(){
        try {
            System.out.println("----- DODAWANIE -----");
            System.out.println("Dzień w miesiącu 1-31: ");
            int day = Integer.parseInt(scanner.nextLine());
            if(day <= 31 && day > 0){
                day = day + 1;
            }
            else {
                System.out.println("Podałeś złe dane!");
                return;
            }
            System.out.println("Wybierz typ eventu (meeting/phoneCall/reminder): ");
            String type = scanner.nextLine();

            if(type.equalsIgnoreCase("meeting")){
                System.out.println("Godzina rozpoczęcia: ");
                LocalTime startTime = LocalTime.parse(scanner.nextLine());
                if(!startTime.isAfter(EventTime.earliestTimeEventCanStart)) {
                    System.out.println("Meeting jest za wcześnie");
                    return;
                }
                System.out.println("Godzina zakończenia: ");
                LocalTime endTime = LocalTime.parse(scanner.nextLine());
                System.out.println("Opis: ");
                String description = scanner.nextLine();


                System.out.println("Priorytet (low/medium/high): ");
                var prio = scanner.nextLine().toUpperCase();

                if(prio != "LOW" || prio != "MEDIUM" || prio != "HIGH") {
                    throw new BadPriority("Invalid priority");
                }

                Event.Priority priority = Event.Priority.valueOf(prio);

                if(calendar.addEvent(day, new Meeting(startTime,endTime,description,priority))){
                    System.out.println("Pomyślnie dodano!");
                }
            }else if(type.equalsIgnoreCase("phonecall")){
                System.out.println("Numer telefonu: ");
                String phoneNumber = scanner.nextLine();
                System.out.println("Godzina rozpoczęcia: ");
                LocalTime startTime = LocalTime.parse(scanner.nextLine());

                if(!startTime.isAfter(EventTime.earliestTimeEventCanStart)) {
                    System.out.println("Meeting jest za wcześnie");
                    return;
                }

                System.out.println("Godzina zakończenia: ");
                LocalTime endTime = LocalTime.parse(scanner.nextLine());
                System.out.println("Opis: ");
                String description = scanner.nextLine();


                System.out.println("Priorytet (low/medium/high): ");

                var prio = scanner.nextLine().toUpperCase();

                if(prio != "LOW" || prio != "MEDIUM" || prio != "HIGH") {
                    throw new BadPriority("Invalid priority");
                }

                Event.Priority priority = Event.Priority.valueOf(prio);

                if(calendar.addEvent(day, new PhoneCall(startTime,endTime,description,priority, phoneNumber))){
                    System.out.println("Pomyślnie dodano!");
                }
            }
            else if(type.equalsIgnoreCase("reminder")){
                System.out.println("Opis: ");
                String description = scanner.nextLine();
                System.out.println("Priorytet (low/medium/high): ");
                var prio = scanner.nextLine().toUpperCase();

                if(prio != "LOW" || prio != "MEDIUM" || prio != "HIGH") {
                    throw new BadPriority("Invalid priority");
                }

                Event.Priority priority = Event.Priority.valueOf(prio);

                if(calendar.addEvent(day, new Reminder(description,priority))){
                    System.out.println("Pomyślnie dodano!");
                }
            }

        }
        catch (Exception ex){
            ex.printStackTrace();//uncached
            System.out.println("Podałeś złe dane!");
        }
    }

    private void userRemoveEvent() {
        try {
            System.out.println("----- USUWANIE -----");
            System.out.println("Dzień w miesiącu 1-31: ");
            int day = Integer.parseInt(scanner.nextLine())-1;
            printEvents(day);
            System.out.println("Który meeting usunąć: ");
            int eventID = Integer.parseInt(scanner.nextLine())-1;

            if(calendar.removeEvent(day, eventID)){
                System.out.println("Pomyślnie usunięto!");
            }
        }
        catch (Exception ex){
            System.out.println("Podałeś złe dane!");
        }
    }

    private void userPrintEvents(){
        try {
            System.out.println("Dzień w miesiącu 1-31: ");
            int day = Integer.parseInt(scanner.nextLine())-1;

            printEvents(day);
        }
        catch (Exception ex){
            System.out.println("Podałeś złe dane!");
        }
    }

    private void userPrintEventsWithPriority(){
        try {
            System.out.println("Dzień w miesiącu 1-31: ");
            int day = Integer.parseInt(scanner.nextLine())-1;

            System.out.println("Priorytet (low/medium/high): ");
            Meeting.Priority priority = Meeting.Priority.valueOf(scanner.nextLine().toUpperCase());

            printEventsWithPriority(day, priority);
        }
        catch (Exception ex){
            System.out.println("Podałeś złe dane!");
        }
    }

    private void userPrintEventsWithType(){
        try {
            System.out.println("Dzień w miesiącu 1-31: ");
            int day = Integer.parseInt(scanner.nextLine())-1;
            System.out.println("Typ eventu (meeting/phonecall/reminder): ");
            String type = scanner.nextLine();

            printEventsWithType(day, type);
        }
        catch (Exception ex){
            System.out.println("Podałeś złe dane!");
        }


    }

    private void printEvents(int day){
        List<Event> eventsToday = calendar.getMonthCalendar()[day];

        System.out.println("\nLISTA Z DNIA = " + (day + 1) + ": ");

        if(eventsToday.size() == 0){
            System.out.println("Brak eventów na ten dzień");
            return;
        }

        int[] idx = { 0 };
        eventsToday.stream()
                .forEach(event -> {
                    idx[0]++;
                    System.out.println(idx[0] + ". " + event.typeName + " | " + event);
                });
    }

    private void printEventsWithPriority(int day, Event.Priority priority){
        List<Event> eventsToday = calendar.getMonthCalendar()[day];
        System.out.println("\nLISTA Z DNIA = " + (day+1) + " Z PRIORYTETEM = " + priority.toString() + ": ");

        if(eventsToday.size() == 0){
            System.out.println("Brak eventów na ten dzień");
            return;
        }

        int[] idx = { 0 };
        eventsToday.stream()
                .filter(event -> event.getPriority() == priority)
                .forEach(event -> {
                    idx[0]++;
                    System.out.println(idx[0] + ". " + event.typeName + " | " + event);
                });


    }

    private void printEventsWithType(int day, String type){

        if(!(type.equalsIgnoreCase("meeting")  || type.equalsIgnoreCase("phonecall") || type.equalsIgnoreCase("reminder"))){
            System.out.println("Nie rozpoznanu typu");
            return;
        }
        List<Event> eventsToday = calendar.getMonthCalendar()[day];
        System.out.println("\nLISTA Z DNIA = " + (day+1) + " Z TYPEM = " + type + ": ");

        if(eventsToday.size() == 0){
            System.out.println("Brak eventów na ten dzień");
            return;
        }

        int[] idx = { 0 };
        eventsToday.stream()
                .filter(event -> event.typeName.equalsIgnoreCase(type))
                .forEach(event -> {
                    idx[0]++;
                    System.out.println(idx[0] + ". " + event.typeName + " | " + event);
                });
    }
}
