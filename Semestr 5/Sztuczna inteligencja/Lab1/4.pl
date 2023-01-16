mezczyzna(adam).
mezczyzna(stefan).
mezczyzna(staszek).
mezczyzna(marek).
kobieta(ala).
kobieta(alina).
kobieta(maria).
kobieta(ania).
rodzice(stefan, staszek, maria).
rodzice(maria, adam, beata).
rodzice(ala, staszek, maria).
rodzice(ania, marek, alina).

rodzenstwo(X,Y) :-
	rodzice(X,O,M),
	rodzice(Y,O,M),
	X \= Y.
