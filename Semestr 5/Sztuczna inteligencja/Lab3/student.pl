:- dynamic(student/5). %Inicjacja faktu student
:- use_module(library(persistency)). %Dynamiczne tworzenie obiektu
:- persistent(student(id,name,surname,mark,studies)). %utworzenie dynamicznego obiektu
:- initialization(db_attach('student_db.pl', [])). %Inicjacja pliku danych

show:-
    nl, nl,
    write("1. Print all students"), nl,
    write("2. Search for a student by name"), nl,
    write("3. Search for a student by surname"),nl,
    write("4. Search for a student by field of study"), nl,
    write("5. Search for a student by average grade"), nl,
    write("6. Add a student"),nl,
    write("7. Modify the student"), nl,
    write("8. Delete the student"), nl,
    write("9. Exit"),nl,nl,
    write("Option: "),nl.

start:-
    show, %Wywo³aj predykat show/o
    read(A), %Wpisz pod zmienn¹ A liczbê z wejœcia standardowego
    option(A). %Wywo³aj predykat option/1 w zale¿noœci od zmiennej A

option(1):-
    write("All students: "), nl,
    %Setof przerzuca wybrane parametry (W tym przypadku 5) z faktu do listy
    setof(
    (ID, Name, Surname, Grade, Studies),
    (student(ID, Name, Surname, Grade, Studies)), List),
    (
        print_elements(List); %Wypisz wszystkie elementy lub napisze, ¿e nie ma studentów w bazie
        write("There is not students in database!")
    ),
    start.

option(2):-
    write("Name: "), nl,
    read(Name),
    by_name(Name),
    start.

option(3):-
    write("Surname: "), nl,
    read(Surname),
    by_surname(Surname),
    start.

option(4):-
    write("Studies: "), nl,
    read(Studies),
    by_field_of_study(Studies),
    start.

option(5):-
    write("Average Grade: "), nl,
    read(Required_grade),
    by_grades(Required_grade),
    start.

option(6):-
    write("Write ID, Name, Surname, Grade, Field of study: "), nl,
    read(A),
    (
        (
           student(A,_,_,_,_) %Jeœli istnieje student, który ma ID równe wartoœci zmiennej A
           -> %Implikacja
           write("This student already exists!")
           ; %W przeciwnym wypadku
           read(B), read(C), read(D), read(E),
           add_student(A,B,C,D,E)
        )
    ),
    start.

option(7):-
    write("Students ID: "), nl,
    read(A),
    (
        modify_student(A)
        ;%Jeœli nie znaleziono studenta o danym ID
        write("Didnt find any student.")
    ),
    start.

option(8):-
    write("Students ID: "), nl,
    read(A),
    (
        remove_student(A)
        ;%Jeœli nie znaleziono studenta o danym ID
        write("Didn't find any student.")
    ),
    start.

option(9):-
    write("Exit").

option(_):-
    %Else
    start.

add_student(ID, Name, Surname, Grade, Studies):-
    with_mutex(student_db, assert_student(ID, Name, Surname, Grade, Studies)).


remove_student(ID):-
    with_mutex(student_db,retract_student(ID,_,_,_,_)).

modify_student(ID):-
    student(ID,_,_,_,_) %szukamy
    ->
    (
        write("Name: "), nl, read(Name),
        write("Surname: "), nl, read(Surname),
        write("Grade: "), nl, read(Mark),
        write("Field of study: "), nl, read(Studies),
        remove_student(ID),
        add_student(ID, Name, Surname, Mark, Studies)
    )
    ;%Jeœli nie znaleziono studenta o danym ID
    write("We didnt find any student."), nl.

print_elements([]).
print_elements([Head|Tail]):-
    write(Head),
    nl,
    print_elements(Tail).

print_grades([],_).
print_grades([[A,B,C,D,E]|Tail], Required_grade):-
    (
        (
            D >= Required_grade) %Jesli ocena jest wyzsza niz wymagana
            ->
            (
                write(A), write(","), write(B), write(","), write(C), write(","), write(D), write(","),write(E), nl)
                ;
                true %W przeciwnym wypadku nie rób nic
            ),
            (
                number(D)->
                print_grades(Tail, Required_grade)
            ).


by_name(Name):-
    setof(
        (ID, Name, Surname, Grade, Studies),
        (
            student(ID, Name, Surname, Grade, Studies)
        ), List),
    length(List, Length), %Podaje d³ugoœæ listy
    write("With name \""), write(Name),
    write("\" found "), write(Length),
    write(" student (s): "), nl,
    print_elements(List)
    ;%Wypisz elementy lub napisz, ¿e nie znaleziono studentów

    !,
    write("Didn't find any student.").


by_grades(Required_grade):-
    setof(
        [ID, Name, Surname, Grade, Studies],
        (
            student(ID, Name, Surname, Grade, Studies)
        ), List),
    length(List, Length), %Podaje d³ugoœæ listy
    write("With grade \""), write(Required_grade),
    write("\" found "), write(Length),
    write(" student (s): "), nl,
    print_grades(List, Required_grade)
    ;%Wypisz elementy lub napisz, ¿e nie znaleziono takich studentów
    !,
    write("Didn't find any student.").

by_surname(Surname):-
    setof(
        (ID, Name, Surname, Grade, Studies),
        (
            student(ID, Name, Surname, Grade, Studies)
        ), List),
    length(List, Length), %Podaje d³ugoœæ listy
    write("With surname \""), write(Surname),
    write("\" found "), write(Length),
    write(" student (s): "), nl,
    print_elements(List)
    ;%Wypisz elementy lub napisz, ¿e nie znaleziono takich studentów
    !,
    write("Didn't find any student.").

by_field_of_study(Studies):-
    setof(
        (ID, Name, Surname, Grade, Studies),
        (
            student(ID, Name, Surname, Grade, Studies)
        ), List),
    length(List, Length), %Podaje d³ugoœæ listy
    write("With field of study \""), write(Studies),
    write("\" found "), write(Length),
    write(" student (s): "), nl,
    print_elements(List)
    ;%Wypisz elementy lub napisze, ¿e nie znaleziono takich studentów
    !,
    write("Didn't find any student.").
