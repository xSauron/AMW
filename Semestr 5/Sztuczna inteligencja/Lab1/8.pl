odliczanie_w_dol(0).

odliczanie_w_dol(X):-
	N is X-1, % za ka�dym przej�ciem rekurencji zmniejszamy X o 1 i przypisujemy do nowej zmiennej
	write(X), nl, % wypisanie zmiennej X
	odliczanie_w_dol(N). % rekurencyjne wywo�anie regu�y z warto�ci� mniejsz� o 1.
