krol(boleslaw_chrobry, 992,1025).
krol(mieszko_2, 1025, 1031).
krol(jan_1, 1323, 1355).

rzadzil(Krol,Rok):-
	krol(Krol,Rok1,Rok2),
	Rok >= Rok1,
	Rok =< Rok2.

