rodzic(kasia,robert).
rodzic(tomek,robert).
rodzic(tomek,ania).
rodzic(robert,gosia).
rodzic(robert,basia).
rodzic(basia,janek).

kobieta(kasia).
kobieta(ania).
kobieta(basia).
kobieta(gosia).

mezczyzna(tomek).
mezczyzna(robert).
mezczyzna(janek).

dziecko(X,Y) :-
	rodzic(Y,X).

matka(X,Y) :-
	rodzic(X,Y),
	kobieta(X).

ojciec(X,Y) :-
	rodzic(X,Y),
	mezczyzna(X).

dziadkowie(X,Y) :-
	rodzic(X,Z),
	rodzic(Z,Y).

dziadek(X,Y) :-
	dziadkowie(X,Y),
	mezczyzna(X).

babcia(X,Y) :-
	dziadkowie(X,Y),
	kobieta(X).

przodek(X,Y) :-
	rodzic(X,Y).
przodek(X,Z) :-
	rodzic(X,Y),
	przodek(Y,Z).

potomek(X,Y) :-
	rodzic(Y,X).
potomek(Z,X) :-
	rodzic(Y,Z),
	potomek(Y,X).


























