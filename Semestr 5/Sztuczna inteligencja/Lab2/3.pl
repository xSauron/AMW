zakres(L,L,[L]).
zakres(P,K,[P|L]):-
    P<K, 
    N is P+1, 
    zakres(N,K,L).