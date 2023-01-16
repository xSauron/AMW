usun(X,[X|R],R).
usun(X,[Y|O],[Y|R]):-
	usun(X,O,R).

del([_|O],O,1).
del([G|O],B,N) :-
    K is N-1,
    del(O,C,K),
    B = [G|C].