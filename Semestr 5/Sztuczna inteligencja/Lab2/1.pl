suma([],0).
suma([G|O],S):-
	suma(O,ST),
	S is ST + G.